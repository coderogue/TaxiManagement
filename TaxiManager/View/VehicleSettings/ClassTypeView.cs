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
    public partial class ClassTypeView : Form
    {
        Controller.ClassTypeController control = new Controller.ClassTypeController();

        public ClassTypeView()
        {
            InitializeComponent();
        }

        private void ClassTypeView_Load(object sender, EventArgs e)
        {
            GVModel.AutoGenerateColumns = false;
            BtnSearch.PerformClick();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            GVModel.DataSource = control.GetClassTypes(TxtSearch.Text);
        }

        private void GVModel_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int EditRow = Convert.ToInt32(GVModel.Rows[e.RowIndex].Cells["ctid"].Value);
            string EditValue = GVModel.Rows[e.RowIndex].Cells["ct_desc"].Value.ToString();

            control.UpdateClassType(EditValue, Classes.CConstant.LoginID, EditRow);
            ClassTypeView_Load(this, new EventArgs());
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClassTypeForm Form = new ClassTypeForm();
            Form.ShowDialog();
            ClassTypeView_Load(this, new EventArgs());
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (GVModel.SelectedRows.Count == 0)
            {
                MessageBox.Show(Classes.Messages.MSG_SelectRow, Classes.Messages.TTLDefault);
                return;
            }

            if (MessageBox.Show(Classes.Messages.MSG_RequestDel, Classes.Messages.TTLDefault, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int DeleteRow = Convert.ToInt32(GVModel.SelectedRows[0].Cells["ctid"].Value);
                control.DeleteClassType(DeleteRow);
                ClassTypeView_Load(this, new EventArgs());
            }
        }
    }
}
