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
    public partial class CarBuildView : Form
    {
        private Controller.CarBuildController control = new TaxiManager.Controller.CarBuildController();
        private string EditingText = "";
        private int EditingRow = 0;

        public CarBuildView()
        {
            InitializeComponent();
        }

        private void CarBuildView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carBuildModel.car_made' table. You can move, or remove it, as needed.
            GVMake.AutoGenerateColumns = false;
            //GVMake.DataSource = control.GetMakeType();
            BtnSearch.PerformClick();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            CarBuildForm Form = new CarBuildForm();
            Form.ShowDialog();
            BtnSearch.PerformClick();
        }

        private void GVMake_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            EditingText = GVMake.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            EditingRow = Convert.ToInt32 (GVMake.Rows[e.RowIndex].Cells["cmid"].Value);
            control.UpdateRow(EditingText, Classes.CConstant.LoginID, EditingRow);
            CarBuildView_Load(this, new EventArgs());
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (GVMake.SelectedRows.Count == 0)
            {
                MessageBox.Show(Classes.Messages.MSG_SelectRow, Classes.Messages.TTLDefault);
                return;
            }
            
            if (MessageBox.Show(Classes.Messages.MSG_RequestDel, Classes.Messages.TTLDefault, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                control.DeleteRow(Convert.ToInt32( GVMake.SelectedRows[0].Cells["cmid"].Value));
                GVMake.DataSource = control.GetMakeType();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            GVMake.DataSource = control.GetMakeType(TxtSearch.Text);
        }

        private void GVMake_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show(Classes.Messages.MSG_RequestDel, Classes.Messages.TTLDefault, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                control.DeleteRow(Convert.ToInt32(e.Row.Cells["cmid"].Value));
                GVMake.DataSource = control.GetMakeType();
            }
        }

    }
}
