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
    public partial class CarModelForm : Form
    {
        public CarModelForm()
        {
            InitializeComponent();
        }

        private Controller.CarModelController control = new Controller.CarModelController();

        private void CarModelForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxi_managementDataSet.car_made' table. You can move, or remove it, as needed.
            this.car_madeTableAdapter.Fill(this.taxi_managementDataSet.car_made);

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CmbMake.SelectedIndex != -1 && !string.IsNullOrEmpty(TxtModel.Text))
            {
                control.InsertRow(Convert.ToInt32(CmbMake.SelectedValue), TxtModel.Text, Classes.CConstant.LoginID);
                this.Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
