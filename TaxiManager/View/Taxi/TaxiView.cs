using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaxiManager.View.Taxi
{
    public partial class TaxiView : Form
    {
        private Controller.TaxiController control = new Controller.TaxiController();

        public TaxiView()
        {
            InitializeComponent();
        }

        private void TaxiView_Load(object sender, EventArgs e)
        {
            GVTaxi.AutoGenerateColumns = false;
            BtnSearch.PerformClick();
        }

        private void GVTaxi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnSelect.PerformClick();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            GVTaxi.DataSource = control.GetTaxi(TxtSearch.Text);
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (GVTaxi.SelectedRows.Count == 0)
            {
                MessageBox.Show(Classes.Messages.MSG_SelectRow, Classes.Messages.TTLDefault);
                return;
            }

            int RowIndex = Convert.ToInt32(GVTaxi.SelectedRows[0].Cells["taxiid"].Value);
            TaxiForm Form = new TaxiForm(RowIndex);
            Form.MdiParent = this.MdiParent;
            Form._Parent = this;
            Form.Show();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            TaxiForm Form = new TaxiForm();
            Form._Parent = this;
            Form.Show();
        }

        //Function
        public void RefreshPage()
        {
            TaxiView_Load(this, new EventArgs());
        }
    }
}
