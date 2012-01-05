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
    public partial class BodyTypeView : Form
    {

        private Controller.BodyTypeController control = new Controller.BodyTypeController();


        public BodyTypeView()
        {
            InitializeComponent();
        }

        private void BodyTypeView_Load(object sender, EventArgs e)
        {
            GVBodyType.AutoGenerateColumns = false;
            BtnSearch.PerformClick();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            GVBodyType.DataSource = control.GetTypes(TxtSearch.Text);
        }

        private void GVBodyType_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int EditRow = Convert.ToInt32(GVBodyType.Rows[e.RowIndex].Cells["btid"].Value);
            string EditText = GVBodyType.Rows[e.RowIndex].Cells["bt_desc"].Value.ToString();

            control.UpdateBodyType(EditText, Classes.CConstant.LoginID, EditRow);
            BodyTypeView_Load(this, new EventArgs());
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            BodyTypeForm Form = new BodyTypeForm();
            Form.ShowDialog();
            BtnSearch.PerformClick();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (GVBodyType.SelectedRows.Count == 0)
            {
                MessageBox.Show(Classes.Messages.MSG_SelectRow, Classes.Messages.TTLDefault);
                return;
            }
            
            if (MessageBox.Show(Classes.Messages.MSG_RequestDel, Classes.Messages.TTLDefault, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                control.DeleteBodyType(Convert.ToInt32(GVBodyType.SelectedRows[0].Cells["btid"].Value));
                BtnSearch.PerformClick();
            }
        }
    }
}
