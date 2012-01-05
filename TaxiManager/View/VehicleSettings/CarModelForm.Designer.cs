namespace TaxiManager.View.VehicleSettings
{
    partial class CarModelForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbMake = new System.Windows.Forms.ComboBox();
            this.carmadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taxi_managementDataSet = new TaxiManager.taxi_managementDataSet();
            this.TxtModel = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.car_madeTableAdapter = new TaxiManager.taxi_managementDataSetTableAdapters.car_madeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.carmadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxi_managementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Make";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Car Model";
            // 
            // CmbMake
            // 
            this.CmbMake.DataSource = this.carmadeBindingSource;
            this.CmbMake.DisplayMember = "cm_name";
            this.CmbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMake.FormattingEnabled = true;
            this.CmbMake.Location = new System.Drawing.Point(71, 26);
            this.CmbMake.Name = "CmbMake";
            this.CmbMake.Size = new System.Drawing.Size(263, 21);
            this.CmbMake.TabIndex = 2;
            this.CmbMake.ValueMember = "cmid";
            // 
            // carmadeBindingSource
            // 
            this.carmadeBindingSource.DataMember = "car_made";
            this.carmadeBindingSource.DataSource = this.taxi_managementDataSet;
            // 
            // taxi_managementDataSet
            // 
            this.taxi_managementDataSet.DataSetName = "taxi_managementDataSet";
            this.taxi_managementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TxtModel
            // 
            this.TxtModel.Location = new System.Drawing.Point(71, 53);
            this.TxtModel.Name = "TxtModel";
            this.TxtModel.Size = new System.Drawing.Size(263, 20);
            this.TxtModel.TabIndex = 3;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(178, 83);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(259, 83);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // car_madeTableAdapter
            // 
            this.car_madeTableAdapter.ClearBeforeFill = true;
            // 
            // CarModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 118);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtModel);
            this.Controls.Add(this.CmbMake);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CarModelForm";
            this.Text = "CarModelForm";
            this.Load += new System.EventHandler(this.CarModelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carmadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxi_managementDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbMake;
        private System.Windows.Forms.TextBox TxtModel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private taxi_managementDataSet taxi_managementDataSet;
        private System.Windows.Forms.BindingSource carmadeBindingSource;
        private taxi_managementDataSetTableAdapters.car_madeTableAdapter car_madeTableAdapter;
    }
}