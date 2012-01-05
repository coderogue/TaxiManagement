﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaxiManager.View.VehicleSettings
{
    public partial class ClassTypeForm : Form
    {
        Controller.ClassTypeController control = new Controller.ClassTypeController();

        public ClassTypeForm()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtClassType.Text))
            {
                control.InsertClassType(TxtClassType.Text, Classes.CConstant.LoginID);
                this.Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
