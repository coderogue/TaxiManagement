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
    public partial class OwnerStatusForm : Form
    {
        private Controller.OwnerStatusController control = new Controller.OwnerStatusController();

        public OwnerStatusView _Parent { get; set; }

        public OwnerStatusForm()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtOwnerStatus.Text))
            {
                control.InsertOwnerStatus(TxtOwnerStatus.Text, Classes.CConstant.LoginID);
                _Parent.RefreshView(); 
                this.Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
