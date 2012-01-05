using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaxiManager.View.Companies
{
    public partial class CompanyView : Form
    {
        private Controller.CompanyController control = new Controller.CompanyController();

        public CompanyView()
        {
            InitializeComponent();
        }

        private void CompanyView_Load(object sender, EventArgs e)
        {
            GVCompany.AutoGenerateColumns = false;
            BtnSearch.PerformClick();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            GVCompany.DataSource = control.GetCompanies(TxtSearch.Text);
        }

        private void GVCompany_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnSelect.PerformClick();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (GVCompany.SelectedRows.Count == 0)
                MessageBox.Show("Row is not selected.", Classes.Messages.TTLDefault);
            else
            {
                int SelectedRow = Convert.ToInt32(GVCompany.SelectedRows[0].Cells["comid"].Value);
                CompanyForm Form = new CompanyForm(SelectedRow);
                Form._parent = this;
                Form.MdiParent = this.MdiParent;
                Form.Show();
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            CompanyForm Form = new CompanyForm();
            Form.MdiParent = this.MdiParent;
            Form._parent = this;
            Form.Show();
        }

        //functions
        public void Reload()
        {
            CompanyView_Load(this, new EventArgs());
        }
    }
}
