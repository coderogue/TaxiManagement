namespace TaxiManager.View.Reminders
{
    partial class RoadTaxView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GVRoadTax = new System.Windows.Forms.DataGridView();
            this.LLViewRpt = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ChkPaid = new System.Windows.Forms.CheckBox();
            this.CmbTaxi = new System.Windows.Forms.ComboBox();
            this.taxiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taximanagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taxi_managementDataSet = new TaxiManager.taxi_managementDataSet();
            this.Rbtn6Months = new System.Windows.Forms.RadioButton();
            this.Rbtn12Months = new System.Windows.Forms.RadioButton();
            this.TxtPayment = new System.Windows.Forms.TextBox();
            this.DTPayDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblExpireDate = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.taxiTableAdapter = new TaxiManager.taxi_managementDataSetTableAdapters.taxiTableAdapter();
            this.rtaxid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxi_regno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.license_rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtax_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtax_payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GVRoadTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taximanagementDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxi_managementDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GVRoadTax
            // 
            this.GVRoadTax.AllowUserToAddRows = false;
            this.GVRoadTax.AllowUserToDeleteRows = false;
            this.GVRoadTax.AllowUserToOrderColumns = true;
            this.GVRoadTax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVRoadTax.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rtaxid,
            this.taxi_regno,
            this.license_rate,
            this.rtax_date,
            this.rtax_payment});
            this.GVRoadTax.Location = new System.Drawing.Point(12, 141);
            this.GVRoadTax.Name = "GVRoadTax";
            this.GVRoadTax.ReadOnly = true;
            this.GVRoadTax.Size = new System.Drawing.Size(490, 193);
            this.GVRoadTax.TabIndex = 7;
            // 
            // LLViewRpt
            // 
            this.LLViewRpt.AutoSize = true;
            this.LLViewRpt.Location = new System.Drawing.Point(458, 337);
            this.LLViewRpt.Name = "LLViewRpt";
            this.LLViewRpt.Size = new System.Drawing.Size(44, 13);
            this.LLViewRpt.TabIndex = 8;
            this.LLViewRpt.TabStop = true;
            this.LLViewRpt.Text = "View All";
            this.LLViewRpt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLViewRpt_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Taxi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "License Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Payment (RM)";
            // 
            // ChkPaid
            // 
            this.ChkPaid.AutoSize = true;
            this.ChkPaid.Location = new System.Drawing.Point(12, 85);
            this.ChkPaid.Name = "ChkPaid";
            this.ChkPaid.Size = new System.Drawing.Size(47, 17);
            this.ChkPaid.TabIndex = 5;
            this.ChkPaid.Text = "Paid";
            this.ChkPaid.UseVisualStyleBackColor = true;
            this.ChkPaid.CheckedChanged += new System.EventHandler(this.ChkPaid_CheckedChanged);
            // 
            // CmbTaxi
            // 
            this.CmbTaxi.DataSource = this.taxiBindingSource;
            this.CmbTaxi.DisplayMember = "taxi_regno";
            this.CmbTaxi.FormattingEnabled = true;
            this.CmbTaxi.Location = new System.Drawing.Point(88, 6);
            this.CmbTaxi.Name = "CmbTaxi";
            this.CmbTaxi.Size = new System.Drawing.Size(166, 21);
            this.CmbTaxi.TabIndex = 0;
            this.CmbTaxi.ValueMember = "taxiid";
            this.CmbTaxi.SelectedIndexChanged += new System.EventHandler(this.CmbTaxi_SelectedIndexChanged);
            // 
            // taxiBindingSource
            // 
            this.taxiBindingSource.DataMember = "taxi";
            this.taxiBindingSource.DataSource = this.taximanagementDataSetBindingSource;
            // 
            // taximanagementDataSetBindingSource
            // 
            this.taximanagementDataSetBindingSource.DataSource = this.taxi_managementDataSet;
            this.taximanagementDataSetBindingSource.Position = 0;
            // 
            // taxi_managementDataSet
            // 
            this.taxi_managementDataSet.DataSetName = "taxi_managementDataSet";
            this.taxi_managementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Rbtn6Months
            // 
            this.Rbtn6Months.AutoSize = true;
            this.Rbtn6Months.Checked = true;
            this.Rbtn6Months.Location = new System.Drawing.Point(88, 33);
            this.Rbtn6Months.Name = "Rbtn6Months";
            this.Rbtn6Months.Size = new System.Drawing.Size(69, 17);
            this.Rbtn6Months.TabIndex = 1;
            this.Rbtn6Months.TabStop = true;
            this.Rbtn6Months.Text = "6 Months";
            this.Rbtn6Months.UseVisualStyleBackColor = true;
            // 
            // Rbtn12Months
            // 
            this.Rbtn12Months.AutoSize = true;
            this.Rbtn12Months.Location = new System.Drawing.Point(179, 33);
            this.Rbtn12Months.Name = "Rbtn12Months";
            this.Rbtn12Months.Size = new System.Drawing.Size(75, 17);
            this.Rbtn12Months.TabIndex = 2;
            this.Rbtn12Months.Text = "12 Months";
            this.Rbtn12Months.UseVisualStyleBackColor = true;
            // 
            // TxtPayment
            // 
            this.TxtPayment.Location = new System.Drawing.Point(89, 56);
            this.TxtPayment.Name = "TxtPayment";
            this.TxtPayment.Size = new System.Drawing.Size(88, 20);
            this.TxtPayment.TabIndex = 3;
            // 
            // DTPayDate
            // 
            this.DTPayDate.Enabled = false;
            this.DTPayDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPayDate.Location = new System.Drawing.Point(88, 82);
            this.DTPayDate.Name = "DTPayDate";
            this.DTPayDate.Size = new System.Drawing.Size(89, 20);
            this.DTPayDate.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblExpireDate);
            this.groupBox1.Location = new System.Drawing.Point(293, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 93);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Next Payment";
            // 
            // LblExpireDate
            // 
            this.LblExpireDate.AutoSize = true;
            this.LblExpireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblExpireDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblExpireDate.Location = new System.Drawing.Point(18, 34);
            this.LblExpireDate.Name = "LblExpireDate";
            this.LblExpireDate.Size = new System.Drawing.Size(173, 33);
            this.LblExpireDate.TabIndex = 0;
            this.LblExpireDate.Text = "31-12-2011";
            this.LblExpireDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(98, 108);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(179, 108);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 6;
            this.BtnClear.Text = "Cancel";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(427, 362);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(346, 362);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // taxiTableAdapter
            // 
            this.taxiTableAdapter.ClearBeforeFill = true;
            // 
            // rtaxid
            // 
            this.rtaxid.DataPropertyName = "rtaxid";
            this.rtaxid.HeaderText = "rtaxid";
            this.rtaxid.Name = "rtaxid";
            this.rtaxid.ReadOnly = true;
            this.rtaxid.Visible = false;
            // 
            // taxi_regno
            // 
            this.taxi_regno.DataPropertyName = "taxi_regno";
            this.taxi_regno.HeaderText = "Taxi";
            this.taxi_regno.Name = "taxi_regno";
            this.taxi_regno.ReadOnly = true;
            // 
            // license_rate
            // 
            this.license_rate.DataPropertyName = "license_rate";
            this.license_rate.HeaderText = "License Type";
            this.license_rate.Name = "license_rate";
            this.license_rate.ReadOnly = true;
            // 
            // rtax_date
            // 
            this.rtax_date.DataPropertyName = "rtax_date";
            this.rtax_date.HeaderText = "Payment Date";
            this.rtax_date.Name = "rtax_date";
            this.rtax_date.ReadOnly = true;
            // 
            // rtax_payment
            // 
            this.rtax_payment.DataPropertyName = "rtax_payment";
            this.rtax_payment.HeaderText = "Payment (RM)";
            this.rtax_payment.Name = "rtax_payment";
            this.rtax_payment.ReadOnly = true;
            // 
            // RoadTaxView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 397);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DTPayDate);
            this.Controls.Add(this.TxtPayment);
            this.Controls.Add(this.Rbtn12Months);
            this.Controls.Add(this.Rbtn6Months);
            this.Controls.Add(this.CmbTaxi);
            this.Controls.Add(this.ChkPaid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LLViewRpt);
            this.Controls.Add(this.GVRoadTax);
            this.MaximizeBox = false;
            this.Name = "RoadTaxView";
            this.Text = "Road Tax";
            this.Load += new System.EventHandler(this.RoadTaxView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVRoadTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taximanagementDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxi_managementDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GVRoadTax;
        private System.Windows.Forms.LinkLabel LLViewRpt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ChkPaid;
        private System.Windows.Forms.ComboBox CmbTaxi;
        private System.Windows.Forms.RadioButton Rbtn6Months;
        private System.Windows.Forms.RadioButton Rbtn12Months;
        private System.Windows.Forms.TextBox TxtPayment;
        private System.Windows.Forms.DateTimePicker DTPayDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblExpireDate;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.BindingSource taximanagementDataSetBindingSource;
        private taxi_managementDataSet taxi_managementDataSet;
        private System.Windows.Forms.BindingSource taxiBindingSource;
        private taxi_managementDataSetTableAdapters.taxiTableAdapter taxiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rtaxid;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxi_regno;
        private System.Windows.Forms.DataGridViewTextBoxColumn license_rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn rtax_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn rtax_payment;
    }
}