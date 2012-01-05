namespace TaxiManager.View.Companies
{
    partial class CompanyView
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
            this.Err = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnSelect = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.GVCompany = new System.Windows.Forms.DataGridView();
            this.comid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.com_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.com_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.com_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.com_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.com_fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNew
            // 
            this.BtnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNew.Location = new System.Drawing.Point(781, 425);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 11;
            this.BtnNew.Text = "Add New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // Err
            // 
            this.Err.ContainerControl = this;
            // 
            // BtnSelect
            // 
            this.BtnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSelect.Location = new System.Drawing.Point(700, 425);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(75, 23);
            this.BtnSelect.TabIndex = 10;
            this.BtnSelect.Text = "Select";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(12, 24);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(309, 20);
            this.TxtSearch.TabIndex = 8;
            // 
            // GVCompany
            // 
            this.GVCompany.AllowUserToAddRows = false;
            this.GVCompany.AllowUserToOrderColumns = true;
            this.GVCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GVCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVCompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comid,
            this.com_no,
            this.com_name,
            this.com_address,
            this.com_tel,
            this.com_fax});
            this.GVCompany.Location = new System.Drawing.Point(12, 62);
            this.GVCompany.MultiSelect = false;
            this.GVCompany.Name = "GVCompany";
            this.GVCompany.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVCompany.Size = new System.Drawing.Size(844, 348);
            this.GVCompany.TabIndex = 12;
            this.GVCompany.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVCompany_CellDoubleClick);
            // 
            // comid
            // 
            this.comid.DataPropertyName = "comid";
            this.comid.HeaderText = "comid";
            this.comid.Name = "comid";
            this.comid.ReadOnly = true;
            this.comid.Visible = false;
            // 
            // com_no
            // 
            this.com_no.DataPropertyName = "com_no";
            this.com_no.HeaderText = "Company No.";
            this.com_no.Name = "com_no";
            this.com_no.ReadOnly = true;
            this.com_no.Width = 200;
            // 
            // com_name
            // 
            this.com_name.DataPropertyName = "com_name";
            this.com_name.HeaderText = "Company Name";
            this.com_name.Name = "com_name";
            this.com_name.ReadOnly = true;
            this.com_name.Width = 200;
            // 
            // com_address
            // 
            this.com_address.DataPropertyName = "com_address";
            this.com_address.HeaderText = "Address";
            this.com_address.Name = "com_address";
            this.com_address.ReadOnly = true;
            this.com_address.Width = 200;
            // 
            // com_tel
            // 
            this.com_tel.DataPropertyName = "com_tel";
            this.com_tel.HeaderText = "Telephone";
            this.com_tel.Name = "com_tel";
            this.com_tel.ReadOnly = true;
            // 
            // com_fax
            // 
            this.com_fax.DataPropertyName = "com_fax";
            this.com_fax.HeaderText = "Fax";
            this.com_fax.Name = "com_fax";
            this.com_fax.ReadOnly = true;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(327, 22);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 9;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // CompanyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 460);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.GVCompany);
            this.Controls.Add(this.BtnSearch);
            this.Name = "CompanyView";
            this.Text = "Companies";
            this.Load += new System.EventHandler(this.CompanyView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVCompany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.ErrorProvider Err;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridView GVCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn comid;
        private System.Windows.Forms.DataGridViewTextBoxColumn com_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn com_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn com_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn com_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn com_fax;
        private System.Windows.Forms.Button BtnSearch;
    }
}