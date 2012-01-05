namespace TaxiManager.View.Taxi
{
    partial class TaxiView
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
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.GVTaxi = new System.Windows.Forms.DataGridView();
            this.taxiid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxi_regno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxi_owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxi_oaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mm_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colour_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxi_epower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ft_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Err = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GVTaxi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNew
            // 
            this.BtnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNew.Location = new System.Drawing.Point(781, 420);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 16;
            this.BtnNew.Text = "Add New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnSelect
            // 
            this.BtnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSelect.Location = new System.Drawing.Point(700, 420);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(75, 23);
            this.BtnSelect.TabIndex = 15;
            this.BtnSelect.Text = "Select";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(12, 19);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(309, 20);
            this.TxtSearch.TabIndex = 13;
            // 
            // GVTaxi
            // 
            this.GVTaxi.AllowUserToAddRows = false;
            this.GVTaxi.AllowUserToOrderColumns = true;
            this.GVTaxi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GVTaxi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVTaxi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taxiid,
            this.taxi_regno,
            this.taxi_owner,
            this.taxi_oaddress,
            this.cm_name,
            this.mm_name,
            this.colour_desc,
            this.bt_desc,
            this.taxi_epower,
            this.ft_desc});
            this.GVTaxi.Location = new System.Drawing.Point(12, 57);
            this.GVTaxi.MultiSelect = false;
            this.GVTaxi.Name = "GVTaxi";
            this.GVTaxi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVTaxi.Size = new System.Drawing.Size(844, 348);
            this.GVTaxi.TabIndex = 17;
            this.GVTaxi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVTaxi_CellDoubleClick);
            // 
            // taxiid
            // 
            this.taxiid.DataPropertyName = "taxiid";
            this.taxiid.HeaderText = "taxiid";
            this.taxiid.Name = "taxiid";
            this.taxiid.ReadOnly = true;
            this.taxiid.Visible = false;
            // 
            // taxi_regno
            // 
            this.taxi_regno.DataPropertyName = "taxi_regno";
            this.taxi_regno.HeaderText = "Registration No.";
            this.taxi_regno.Name = "taxi_regno";
            this.taxi_regno.ReadOnly = true;
            // 
            // taxi_owner
            // 
            this.taxi_owner.DataPropertyName = "taxi_owner";
            this.taxi_owner.HeaderText = "Owner";
            this.taxi_owner.Name = "taxi_owner";
            this.taxi_owner.ReadOnly = true;
            this.taxi_owner.Width = 200;
            // 
            // taxi_oaddress
            // 
            this.taxi_oaddress.DataPropertyName = "taxi_oaddress";
            this.taxi_oaddress.HeaderText = "Address";
            this.taxi_oaddress.Name = "taxi_oaddress";
            this.taxi_oaddress.ReadOnly = true;
            this.taxi_oaddress.Width = 200;
            // 
            // cm_name
            // 
            this.cm_name.DataPropertyName = "cm_name";
            this.cm_name.HeaderText = "Car Made";
            this.cm_name.Name = "cm_name";
            this.cm_name.ReadOnly = true;
            // 
            // mm_name
            // 
            this.mm_name.DataPropertyName = "mm_name";
            this.mm_name.HeaderText = "Model";
            this.mm_name.Name = "mm_name";
            this.mm_name.ReadOnly = true;
            // 
            // colour_desc
            // 
            this.colour_desc.DataPropertyName = "colour_desc";
            this.colour_desc.HeaderText = "Colour";
            this.colour_desc.Name = "colour_desc";
            this.colour_desc.ReadOnly = true;
            // 
            // bt_desc
            // 
            this.bt_desc.DataPropertyName = "bt_desc";
            this.bt_desc.HeaderText = "Body Type";
            this.bt_desc.Name = "bt_desc";
            this.bt_desc.ReadOnly = true;
            // 
            // taxi_epower
            // 
            this.taxi_epower.DataPropertyName = "taxi_epower";
            this.taxi_epower.HeaderText = "Power";
            this.taxi_epower.Name = "taxi_epower";
            this.taxi_epower.ReadOnly = true;
            // 
            // ft_desc
            // 
            this.ft_desc.DataPropertyName = "ft_desc";
            this.ft_desc.HeaderText = "Fuel";
            this.ft_desc.Name = "ft_desc";
            this.ft_desc.ReadOnly = true;
            // 
            // Err
            // 
            this.Err.ContainerControl = this;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(327, 17);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 14;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TaxiView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 460);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.GVTaxi);
            this.Controls.Add(this.BtnSearch);
            this.Name = "TaxiView";
            this.Text = "Taxi List";
            this.Load += new System.EventHandler(this.TaxiView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVTaxi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridView GVTaxi;
        private System.Windows.Forms.ErrorProvider Err;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxiid;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxi_regno;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxi_owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxi_oaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn mm_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn colour_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn bt_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxi_epower;
        private System.Windows.Forms.DataGridViewTextBoxColumn ft_desc;
    }
}