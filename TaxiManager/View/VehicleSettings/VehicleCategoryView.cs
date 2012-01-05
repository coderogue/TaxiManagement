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
    public partial class VehicleCategoryView : Form
    {
        private Controller.VehicleCategoryController control = new Controller.VehicleCategoryController();

        public VehicleCategoryView()
        {
            InitializeComponent();
        }

        private void VehicleCategoryView_Load(object sender, EventArgs e)
        {
            GVCategories.AutoGenerateColumns = false;
            BtnSearch.PerformClick();
        }

        private void GVCategories_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int EditRow = Convert.ToInt32(GVCategories.Rows[e.RowIndex].Cells["vcatid"].Value);
            string EditValue = GVCategories.Rows[e.RowIndex].Cells["vcat_desc"].Value.ToString();

            control.UpdateCategory(EditValue, Classes.CConstant.LoginID, EditRow);
            VehicleCategoryView_Load(this, new EventArgs());
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            GVCategories.DataSource = control.GetCategories(TxtSearch.Text);
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            VehicleCategoryForm Form = new VehicleCategoryForm();
            Form.ShowDialog();
            BtnSearch.PerformClick();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (GVCategories.SelectedRows.Count == 0)
            {
                MessageBox.Show(Classes.Messages.MSG_SelectRow, Classes.Messages.TTLDefault);
                return;
            }

            if (MessageBox.Show(Classes.Messages.MSG_RequestDel, Classes.Messages.TTLDefault, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int DeleteRow = Convert.ToInt32(GVCategories.SelectedRows[0].Cells["vcatid"].Value);
                control.DeleteCategory(DeleteRow);
                VehicleCategoryView_Load(this, new EventArgs());
            }
        }

    }
}
