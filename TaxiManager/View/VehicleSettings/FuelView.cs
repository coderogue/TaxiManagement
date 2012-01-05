using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaxiManager.View.VehicleSettings
{
    public partial class FuelView : Form
    {

        private Controller.FuelController control = new Controller.FuelController();

        public FuelView()
        {
            InitializeComponent();
        }

        private void FuelView_Load(object sender, EventArgs e)
        {
            GVFuelType.AutoGenerateColumns = false;
            BtnSearch.PerformClick();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            GVFuelType.DataSource = control.GetFuelTypes(TxtSearch.Text);
        }

        private void GVFuelType_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int EditingRow = Convert.ToInt32(GVFuelType.Rows[e.RowIndex].Cells["ftid"].Value);
            string EditingValue = GVFuelType.Rows[e.RowIndex].Cells["ft_desc"].Value.ToString();

            control.UpdateFuelType(EditingValue, Classes.CConstant.LoginID, EditingRow);
            FuelView_Load(this, new EventArgs());
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            VehicleSettings.FuelForm Form = new FuelForm();
            Form.ShowDialog();
            FuelView_Load(this, new EventArgs());
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (GVFuelType.SelectedRows.Count == 0)
            {
                MessageBox.Show(Classes.Messages.MSG_SelectRow, Classes.Messages.TTLDefault);
                return;
            }

            int DeletingRow = Convert.ToInt32(GVFuelType.SelectedRows[0].Cells["ftid"].Value);
            if (MessageBox.Show(Classes.Messages.MSG_RequestDel, Classes.Messages.TTLDefault, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                control.DeleteFuelType(DeletingRow);
                FuelView_Load(this, new EventArgs());
            }
        }
    }
}
