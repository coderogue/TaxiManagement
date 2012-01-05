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
    public partial class TaxiForm : Form
    {
        private int _TaxiID { get; set; }
        public TaxiView _Parent { get; set; }

        private Controller.TaxiController control = new Controller.TaxiController();
        private Classes.CValidation validator = new Classes.CValidation();

        public TaxiForm()
        {
            InitializeComponent();
        }

        public TaxiForm(int TaxiID)
        {
            InitializeComponent();
            _TaxiID = TaxiID;
        }

        private void TaxiForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxi_managementDataSet.made_model' table. You can move, or remove it, as needed.
            this.made_modelTableAdapter.Fill(this.taxi_managementDataSet.made_model);
            // TODO: This line of code loads data into the 'taxi_managementDataSet.class_type' table. You can move, or remove it, as needed.
            this.class_typeTableAdapter.Fill(this.taxi_managementDataSet.class_type);
            // TODO: This line of code loads data into the 'taxi_managementDataSet.owner_status' table. You can move, or remove it, as needed.
            this.owner_statusTableAdapter.Fill(this.taxi_managementDataSet.owner_status);
            // TODO: This line of code loads data into the 'taxi_managementDataSet.body_type' table. You can move, or remove it, as needed.
            this.body_typeTableAdapter.Fill(this.taxi_managementDataSet.body_type);
            // TODO: This line of code loads data into the 'taxi_managementDataSet.colours' table. You can move, or remove it, as needed.
            this.coloursTableAdapter.Fill(this.taxi_managementDataSet.colours);
            // TODO: This line of code loads data into the 'taxi_managementDataSet.fuel_type' table. You can move, or remove it, as needed.
            this.fuel_typeTableAdapter.Fill(this.taxi_managementDataSet.fuel_type);
            // TODO: This line of code loads data into the 'taxi_managementDataSet.made_model' table. You can move, or remove it, as needed.
            this.made_modelTableAdapter.Fill(this.taxi_managementDataSet.made_model);
            // TODO: This line of code loads data into the 'taxi_managementDataSet1.owner_status' table. You can move, or remove it, as needed.
            this.owner_statusTableAdapter.Fill(this.taxi_managementDataSet.owner_status);
            // TODO: This line of code loads data into the 'taxi_managementDataSet1.body_type' table. You can move, or remove it, as needed.
            this.body_typeTableAdapter.Fill(this.taxi_managementDataSet.body_type);
            // TODO: This line of code loads data into the 'taxi_managementDataSet1.class_type' table. You can move, or remove it, as needed.
            this.class_typeTableAdapter.Fill(this.taxi_managementDataSet.class_type);
            // TODO: This line of code loads data into the 'taxi_managementDataSet1.colours' table. You can move, or remove it, as needed.
            this.coloursTableAdapter.Fill(this.taxi_managementDataSet.colours);
            // TODO: This line of code loads data into the 'taxi_managementDataSet1.fuel_type' table. You can move, or remove it, as needed.
            this.fuel_typeTableAdapter.Fill(this.taxi_managementDataSet.fuel_type);
            // TODO: This line of code loads data into the 'taxi_managementDataSet1.made_model' table. You can move, or remove it, as needed.
            this.made_modelTableAdapter.Fill(this.taxi_managementDataSet.made_model);
            // TODO: This line of code loads data into the 'taxi_managementDataSet.car_made' table. You can move, or remove it, as needed.
            this.car_madeTableAdapter.Fill(this.taxi_managementDataSet.car_made);

            if (_TaxiID == 0)
            {
                this.Name = "New Taxi";
                TxtRegNo.Text = "";
                TxtOwner.Text = "";
                TxtComNo.Text = "";
                TxtAddress.Text = "";
                TxtEngineNo.Text = "";
                TxtCasisNo.Text = "";
                DDMake.SelectedIndex = -1;
                DDModel.SelectedIndex = -1;
                DDColour.SelectedIndex = -1;
                TxtHP.Text = "";
                DDFuel.SelectedIndex = -1;
                TxtSeatNo.Text = "";
                DDClass.SelectedIndex = -1;
                DDBodyType.SelectedIndex = -1;
                TxtYearMade.Text = "";
                DTRegDate.Value = DateTime.Today;
                DDOwnerStatus.SelectedIndex = -1;
                TxtRate6.Text = "";
                TxtRate12.Text = "";
            }
            else
            {
                DataTable DT = control.GetTaxi(_TaxiID);
                this.Name = "Taxi: " + DT.Rows[0]["taxi_regno"].ToString();
                TxtRegNo.Text = DT.Rows[0]["taxi_regno"].ToString();
                TxtOwner.Text = DT.Rows[0]["taxi_owner"].ToString();
                TxtComNo.Text = DT.Rows[0]["taxi_cono"].ToString();
                TxtAddress.Text = DT.Rows[0]["taxi_oaddress"].ToString();
                TxtEngineNo.Text = DT.Rows[0]["taxi_engineno"].ToString();
                TxtCasisNo.Text = DT.Rows[0]["taxi_casisno"].ToString();
                DDMake.SelectedValue = DT.Rows[0]["taxi_made"];
                DDModel.SelectedValue = DT.Rows[0]["taxi_model"];
                DDColour.SelectedValue = DT.Rows[0]["taxi_colour"];
                TxtHP.Text = DT.Rows[0]["taxi_epower"].ToString();
                DDFuel.SelectedValue = DT.Rows[0]["taxi_fuel"];
                TxtSeatNo.Text = DT.Rows[0]["taxi_seatno"].ToString();
                DDClass.SelectedValue = DT.Rows[0]["taxi_use"];
                DDBodyType.SelectedValue = DT.Rows[0]["taxi_body"];
                TxtYearMade.Text = DT.Rows[0]["taxi_builtyr"].ToString();
                DTRegDate.Value = (DateTime)DT.Rows[0]["taxi_regdate"];
                DDOwnerStatus.SelectedValue = DT.Rows[0]["taxi_ostatus"];
                TxtRate6.Text = DT.Rows[0]["taxi_lrate6"].ToString();
                TxtRate12.Text = DT.Rows[0]["taxi_lrate12"].ToString();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (_TaxiID == 0) //New
            {
                control.InsertTaxi(TxtRegNo.Text, TxtOwner.Text, TxtAddress.Text, TxtEngineNo.Text, TxtCasisNo.Text, Convert.ToInt32(DDMake.SelectedValue), Convert.ToInt32(DDModel.SelectedValue), TxtHP.Text, Convert.ToInt32(DDFuel.SelectedValue),
                    Convert.ToInt32(DDColour.SelectedValue), Convert.ToInt32(DDClass.SelectedValue), Convert.ToInt32(DDBodyType.SelectedValue), Convert.ToInt32(TxtYearMade.Text), DTRegDate.Value, Convert.ToInt32(DDOwnerStatus.SelectedValue), Convert.ToInt32(TxtSeatNo.Text), Convert.ToDouble(TxtRate6.Text), Convert.ToDouble(TxtRate12.Text),
                    TxtComNo.Text, Classes.CConstant.LoginID);
            }
            else //Update
            {
                control.UpdateTaxi(TxtOwner.Text, TxtAddress.Text, TxtEngineNo.Text, TxtCasisNo.Text, Convert.ToInt32(DDMake.SelectedValue), Convert.ToInt32(DDModel.SelectedValue), TxtHP.Text, Convert.ToInt32(DDFuel.SelectedValue),
                    Convert.ToInt32(DDColour.SelectedValue), Convert.ToInt32(DDClass.SelectedValue), Convert.ToInt32(DDBodyType.SelectedValue), Convert.ToInt32(TxtYearMade.Text), DTRegDate.Value, Convert.ToInt32(DDOwnerStatus.SelectedValue), Convert.ToInt32(TxtSeatNo.Text), Convert.ToDouble(TxtRate6.Text), Convert.ToDouble(TxtRate12.Text),
                    TxtComNo.Text, Classes.CConstant.LoginID, _TaxiID);
            }
            TaxiForm_Load(this, new EventArgs());
            _Parent.RefreshPage();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_TaxiID != 0)
                if (MessageBox.Show(Classes.Messages.MSG_RequestDel, Classes.Messages.TTLDefault, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    control.DeleteTaxi(_TaxiID);
                    _TaxiID = 0;
                    TaxiForm_Load(this, new EventArgs());
                    _Parent.RefreshPage();
                }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TaxiForm_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtRegNo.Text))
                Err.SetError(TxtRegNo, Classes.Messages.MSG_NOValue);
            else
                Err.SetError(TxtRegNo, "");
        }

        private void TxtRate6_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtRate6.Text) && !validator.ValidateDouble(TxtRate6.Text))
                    Err.SetError(TxtRate6, Classes.Messages.MSG_InvalidValue);
            else
                Err.SetError(TxtRate6, "");
        }

        private void TxtRate12_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtRate12.Text) && !validator.ValidateDouble(TxtRate12.Text))
                Err.SetError(TxtRate12, Classes.Messages.MSG_InvalidValue);
            else
                Err.SetError(TxtRate12, "");
        }

        private void TxtYearMade_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtYearMade.Text) && !validator.ValidateInteger(TxtYearMade.Text))
                Err.SetError(TxtYearMade, Classes.Messages.MSG_InvalidValue);
            else
                Err.SetError(TxtYearMade, "");
        }

        private void TxtSeatNo_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtSeatNo.Text) && !validator.ValidateInteger(TxtSeatNo.Text))
                Err.SetError(TxtSeatNo, Classes.Messages.MSG_InvalidValue);
            else
                Err.SetError(TxtSeatNo, "");
        }

        private void DDMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaxiManager.taxi_managementDataSet.made_modelDataTable DT = new TaxiManager.taxi_managementDataSet.made_modelDataTable();
            made_modelTableAdapter.FillByCMID(DT, Convert.ToInt32(DDMake.SelectedValue));

            mademodelBindingSource.DataSource = DT;
                
                
        }

        private void BtnRoadTax_Click(object sender, EventArgs e)
        {
            Reminders.RoadTaxView Form = new Reminders.RoadTaxView(_TaxiID);
            Form.ShowDialog();
        }

        private void BtnInsurance_Click(object sender, EventArgs e)
        {
            Reminders.InsuranceView Form = new Reminders.InsuranceView();
            Form.ShowDialog();
        }

        private void BtnPuspakom_Click(object sender, EventArgs e)
        {
            Reminders.PupakomView Form = new Reminders.PupakomView();
            Form.ShowDialog();
        }

        private void BtnTaxiLicense_Click(object sender, EventArgs e)
        {
            Reminders.TaxiLicenseView Form = new Reminders.TaxiLicenseView();
            Form.ShowDialog();
        }
    }
}
