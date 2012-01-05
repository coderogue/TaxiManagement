namespace TaxiManager.View.VehicleSettings
{
    partial class CarModelView
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
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.GVModel = new System.Windows.Forms.DataGridView();
            this.mmid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mm_cmid = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.carmadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taxi_managementDataSet = new TaxiManager.taxi_managementDataSet();
            this.mm_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Err = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnSearch = new System.Windows.Forms.Button();
            this.car_madeTableAdapter = new TaxiManager.taxi_managementDataSetTableAdapters.car_madeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GVModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carmadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxi_managementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Location = new System.Drawing.Point(328, 264);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNew.Location = new System.Drawing.Point(247, 264);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 5;
            this.BtnNew.Text = "Add New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(12, 24);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(309, 20);
            this.TxtSearch.TabIndex = 3;
            // 
            // GVModel
            // 
            this.GVModel.AllowUserToAddRows = false;
            this.GVModel.AllowUserToOrderColumns = true;
            this.GVModel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GVModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVModel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mmid,
            this.mm_cmid,
            this.mm_name});
            this.GVModel.Location = new System.Drawing.Point(12, 62);
            this.GVModel.MultiSelect = false;
            this.GVModel.Name = "GVModel";
            this.GVModel.Size = new System.Drawing.Size(390, 196);
            this.GVModel.TabIndex = 7;
            this.GVModel.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVModel_CellEndEdit);
            // 
            // mmid
            // 
            this.mmid.DataPropertyName = "mmid";
            this.mmid.HeaderText = "cmid";
            this.mmid.Name = "mmid";
            this.mmid.ReadOnly = true;
            this.mmid.Visible = false;
            // 
            // mm_cmid
            // 
            this.mm_cmid.DataPropertyName = "mm_cmid";
            this.mm_cmid.DataSource = this.carmadeBindingSource;
            this.mm_cmid.DisplayMember = "cm_name";
            this.mm_cmid.HeaderText = "Car Make";
            this.mm_cmid.Name = "mm_cmid";
            this.mm_cmid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.mm_cmid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.mm_cmid.ValueMember = "cmid";
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
            // mm_name
            // 
            this.mm_name.DataPropertyName = "mm_name";
            this.mm_name.HeaderText = "Car Model";
            this.mm_name.Name = "mm_name";
            this.mm_name.Width = 200;
            // 
            // Err
            // 
            this.Err.ContainerControl = this;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(327, 22);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // car_madeTableAdapter
            // 
            this.car_madeTableAdapter.ClearBeforeFill = true;
            // 
            // CarModelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 308);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.GVModel);
            this.Controls.Add(this.BtnSearch);
            this.Name = "CarModelView";
            this.Text = "Car Models";
            this.Load += new System.EventHandler(this.CarModelView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carmadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxi_managementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridView GVModel;
        private System.Windows.Forms.ErrorProvider Err;
        private System.Windows.Forms.Button BtnSearch;
        private taxi_managementDataSet taxi_managementDataSet;
        private System.Windows.Forms.BindingSource carmadeBindingSource;
        private taxi_managementDataSetTableAdapters.car_madeTableAdapter car_madeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mmid;
        private System.Windows.Forms.DataGridViewComboBoxColumn mm_cmid;
        private System.Windows.Forms.DataGridViewTextBoxColumn mm_name;

    }
}