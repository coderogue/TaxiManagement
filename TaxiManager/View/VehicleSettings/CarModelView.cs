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
    public partial class CarModelView : Form
    {
        public CarModelView()
        {
            InitializeComponent();
        }

        private Controller.CarModelController control = new Controller.CarModelController();

        private void CarModelView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxi_managementDataSet.car_made' table. You can move, or remove it, as needed.
            this.car_madeTableAdapter.Fill(this.taxi_managementDataSet.car_made);
            GVModel.AutoGenerateColumns = false;
            BtnSearch.PerformClick();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            GVModel.DataSource = control.GetModels(TxtSearch.Text);
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            CarModelForm Form = new CarModelForm();
            Form.ShowDialog();
            BtnSearch.PerformClick();
        }

        private void GVModel_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int EditRow = Convert.ToInt32(GVModel.Rows[e.RowIndex].Cells["mmid"].Value);
            int EditMake = Convert.ToInt32(GVModel.Rows[e.RowIndex].Cells["mm_cmid"].Value);
            string EditModel = GVModel.Rows[e.RowIndex].Cells["mm_name"].Value.ToString();

            control.UpdateRow(EditMake, EditModel, Classes.CConstant.LoginID, EditRow);
            CarModelView_Load(this, new EventArgs());
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (GVModel.SelectedRows.Count == 0)
            {
                MessageBox.Show(Classes.Messages.MSG_SelectRow, Classes.Messages.TTLDefault);
                return;
            }

            if (MessageBox.Show(Classes.Messages.MSG_RequestDel, Classes.Messages.TTLDefault, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                control.DeleteRow(Convert.ToInt32(GVModel.SelectedRows[0].Cells["mmid"].Value));
                BtnSearch.PerformClick();
            }
        }
    }
}
