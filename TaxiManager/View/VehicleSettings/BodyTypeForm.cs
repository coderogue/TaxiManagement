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
    public partial class BodyTypeForm : Form
    {
        private Controller.BodyTypeController control = new Controller.BodyTypeController();

        public BodyTypeForm()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBodyType.Text))
            {
                control.InsertBodyType(TxtBodyType.Text, Classes.CConstant.LoginID);
                this.Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
