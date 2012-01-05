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
    public partial class CompanyForm : Form
    {
        private Controller.CompanyController control = new Controller.CompanyController();

        private int _comid { get; set; }
        public CompanyView _parent { get; set; }
        private DataTable DT;

        public CompanyForm()
        {
            InitializeComponent();
        }

        public CompanyForm(int comid)
        {
            _comid = comid;
            InitializeComponent();
        }

        private void CompanyForm_Load(object sender, EventArgs e)
        {
            if (_comid == 0)
            {
                this.Text = "New Company";
                TxtComNo.Text = "";
                TxtComName.Text = "";
                TxtComDate.Value = DateTime.Today;
                TxtComAdd.Text = "";
                TxtComTel.Text = "";
                TxtComFax.Text = "";
                TxtComID.Text = "";
            }
            else
            {
                DT = control.GetCompany(_comid);
                if (DT.Rows.Count > 0)
                {
                    this.Text = "Company :" + DT.Rows[0]["com_name"].ToString() ;
                    TxtComNo.Text = DT.Rows[0]["com_no"].ToString();
                    TxtComName.Text = DT.Rows[0]["com_name"].ToString();
                    TxtComDate.Value = (DateTime) DT.Rows[0]["com_date"];
                    TxtComAdd.Text = DT.Rows[0]["com_address"].ToString();
                    TxtComTel.Text = DT.Rows[0]["com_tel"].ToString();
                    TxtComFax.Text = DT.Rows[0]["com_fax"].ToString();
                    TxtComID.Text = DT.Rows[0]["com_id"].ToString();
                }
                
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (_comid == 0)
                control.InsertCompany(TxtComName.Text, TxtComNo.Text, TxtComDate.Value, TxtComAdd.Text, TxtComTel.Text, TxtComFax.Text, TxtComID.Text, Classes.CConstant.LoginID);
            else
                control.UpdateCompany(TxtComName.Text, TxtComNo.Text, TxtComDate.Value, TxtComAdd.Text, TxtComTel.Text, TxtComFax.Text, TxtComID.Text, Classes.CConstant.LoginID, _comid);

            _parent.Reload();
            CompanyForm_Load(this, new EventArgs());
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Classes.Messages.MSG_RequestDel, Classes.Messages.TTLDefault, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes && _comid != 0)
            {
                control.DeleteCompany(_comid);
                _parent.Reload();
                _comid = 0;
                CompanyForm_Load(this, new EventArgs());
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
