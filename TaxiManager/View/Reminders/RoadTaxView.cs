using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace TaxiManager.View.Reminders
{
    public partial class RoadTaxView : Form
    {
        private int _TaxiID { get; set; }
        private int _TaxID { get; set; }
        private Controller.RoadTaxController control = new Controller.RoadTaxController();

        public RoadTaxView()
        {
            InitializeComponent();
        }

        public RoadTaxView(int taxiid)
        {
            InitializeComponent();
            _TaxiID = taxiid;

        }


        private void RoadTaxView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxi_managementDataSet.taxi' table. You can move, or remove it, as needed.
            GVRoadTax.AutoGenerateColumns = false;
            this.taxiTableAdapter.Fill(this.taxi_managementDataSet.taxi);
            if (_TaxiID != 0)
            {
                GVRoadTax.DataSource = control.GetPaidRoadTax(_TaxiID);
                DataTable DT = control.GetRoadTax(_TaxiID, "rtax_paid = FALSE");

                if (DT.Rows.Count > 0)
                {
                    _TaxID = Convert.ToInt32(DT.Rows[0]["rtaxid"]);
                    CmbTaxi.SelectedValue = DT.Rows[0]["rtax_taxiid"];
                    CmbTaxi.Enabled = false;
                    if (Convert.ToInt32(DT.Rows[0]["rtax_dtype"]) == 1)
                        Rbtn6Months.Checked = true;
                    else
                        Rbtn6Months.Checked = true;
                    TxtPayment.Text = Convert.ToString(DT.Rows[0]["rtax_payment"]);
                    ChkPaid.Checked = Convert.ToBoolean(DT.Rows[0]["rtax_paid"]);
                    DTPayDate.Value = Convert.ToDateTime(DT.Rows[0]["rtax_date"]);
                    LblExpireDate.Text = control.GetNextPayment(_TaxiID).ToString("dd-MM-yyyy");
                }
                else
                {
                    CmbTaxi.SelectedValue = _TaxiID;
                    CmbTaxi.Enabled = false;
                    LblExpireDate.Text = control.GetNextPayment(_TaxiID).ToString("dd-MM-yyyy");
                }
            }
            else
                ClearText();
        }
        
        private void CmbTaxi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChkPaid_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkPaid.Checked)
                DTPayDate.Enabled = true;
            else
                DTPayDate.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int TaxiID = Convert.ToInt32(CmbTaxi.SelectedValue);
            int Mths = Rbtn6Months.Checked? 1 : 2;
            double Payment = Convert.ToDouble(TxtPayment.Text);
            Boolean Paid = ChkPaid.Checked;
            DateTime PDay =  DTPayDate.Value;

            if (_TaxID == 0)
            {
                control.InsertRoadTax(PDay, Mths, Payment, TaxiID, Classes.CConstant.LoginID, Paid);
            }
            else
            {
                control.UpdateRoadTax(PDay, Mths, Payment, TaxiID, Classes.CConstant.LoginID, Paid, _TaxID);
            }

            RoadTaxView_Load(this, new EventArgs());
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LLViewRpt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        #region MyFunctions
        private void ClearText()
        {
            if (CmbTaxi.Enabled)
                CmbTaxi.SelectedIndex = -1;
            Rbtn6Months.Checked = true;
            TxtPayment.Text = "";
            ChkPaid.Checked = false;
            DTPayDate.Value = DateTime.Today;
            LblExpireDate.Text = control.GetNextPayment(Convert.ToInt32(CmbTaxi.SelectedValue)).ToShortDateString();
        }

        #endregion

    }
}
