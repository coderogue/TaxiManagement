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
    public partial class OwnerStatusView : Form
    {
        private Controller.OwnerStatusController control = new Controller.OwnerStatusController();

        public OwnerStatusView()
        {
            InitializeComponent();
        }

        private void OwnerStatusView_Load(object sender, EventArgs e)
        {
            GVOwnerStatus.AutoGenerateColumns = false;
            BtnSearch.PerformClick();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            GVOwnerStatus.DataSource = control.GetOwnerStatuses(TxtSearch.Text);
        }

        private void GVOwnerStatus_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int EditRow = Convert.ToInt32(GVOwnerStatus.Rows[e.RowIndex].Cells["osid"].Value);
            string EditValue = GVOwnerStatus.Rows[e.RowIndex].Cells["os_desc"].Value.ToString();

            control.UpdateOwnerStatus(EditValue, Classes.CConstant.LoginID, EditRow);
            OwnerStatusView_Load(this, new EventArgs());
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            OwnerStatusForm Form = new OwnerStatusForm();
            Form._Parent = this;
            Form.ShowDialog();
            OwnerStatusView_Load(this, new EventArgs());
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (GVOwnerStatus.SelectedRows.Count == 0)
            {
                MessageBox.Show(Classes.Messages.MSG_SelectRow, Classes.Messages.TTLDefault);
                return;
            }

            if (MessageBox.Show(Classes.Messages.MSG_RequestDel, Classes.Messages.TTLDefault, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int EditRow = Convert.ToInt32(GVOwnerStatus.SelectedRows[0].Cells["osid"].Value);
                control.DeleteOwnerStatus(EditRow);
                OwnerStatusView_Load(this, new EventArgs());
            }
        }

        //Functions
        public void RefreshView()
        {
            OwnerStatusView_Load(this, new EventArgs());
        }
    }
}
