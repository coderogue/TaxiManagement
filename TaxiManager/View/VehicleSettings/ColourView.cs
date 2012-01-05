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
    public partial class ColourView : Form
    {
        private Controller.ColourController control = new Controller.ColourController();

        public ColourView()
        {
            InitializeComponent();
        }

        private void ColourView_Load(object sender, EventArgs e)
        {
            GVMake.AutoGenerateColumns = false;
            BtnSearch.PerformClick();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            GVMake.DataSource = control.GetColourTable(TxtSearch.Text);
        }

        private void GVMake_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int EditRow = Convert.ToInt32(GVMake.Rows[e.RowIndex].Cells["colourid"].Value);
            string EditValue = GVMake.Rows[e.RowIndex].Cells["colour_desc"].Value.ToString();

            control.UpdateColour(EditValue, Classes.CConstant.LoginID, EditRow);
            ColourView_Load(this, new EventArgs());
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ColourForm Form = new ColourForm();
            Form.ShowDialog();
            BtnSearch.PerformClick();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (GVMake.SelectedRows.Count == 0)
            {
                MessageBox.Show(Classes.Messages.MSG_SelectRow, Classes.Messages.TTLDefault);
                return;
            }

            if (MessageBox.Show(Classes.Messages.MSG_RequestDel, Classes.Messages.TTLDefault, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int DeleteRow = (int)GVMake.SelectedRows[0].Cells["colourid"].Value;
                control.DeleteColour(DeleteRow);

                ColourView_Load(this, new EventArgs());
            }
        }
    }
}
