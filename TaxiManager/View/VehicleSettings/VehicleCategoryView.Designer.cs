namespace TaxiManager.View.VehicleSettings
{
    partial class VehicleCategoryView
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
            this.Err = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnNew = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.GVCategories = new System.Windows.Forms.DataGridView();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.vcatid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcat_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Location = new System.Drawing.Point(328, 264);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 11;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Err
            // 
            this.Err.ContainerControl = this;
            // 
            // BtnNew
            // 
            this.BtnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNew.Location = new System.Drawing.Point(247, 264);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 10;
            this.BtnNew.Text = "Add New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(12, 24);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(309, 20);
            this.TxtSearch.TabIndex = 8;
            // 
            // GVCategories
            // 
            this.GVCategories.AllowUserToAddRows = false;
            this.GVCategories.AllowUserToOrderColumns = true;
            this.GVCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GVCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vcatid,
            this.vcat_desc});
            this.GVCategories.Location = new System.Drawing.Point(12, 62);
            this.GVCategories.MultiSelect = false;
            this.GVCategories.Name = "GVCategories";
            this.GVCategories.Size = new System.Drawing.Size(390, 196);
            this.GVCategories.TabIndex = 12;
            this.GVCategories.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVCategories_CellEndEdit);
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
            // vcatid
            // 
            this.vcatid.DataPropertyName = "vcatid";
            this.vcatid.HeaderText = "vcatid";
            this.vcatid.Name = "vcatid";
            this.vcatid.ReadOnly = true;
            this.vcatid.Visible = false;
            // 
            // vcat_desc
            // 
            this.vcat_desc.DataPropertyName = "vcat_desc";
            this.vcat_desc.HeaderText = "Category";
            this.vcat_desc.Name = "vcat_desc";
            this.vcat_desc.Width = 200;
            // 
            // VehicleCategoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 308);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.GVCategories);
            this.Controls.Add(this.BtnSearch);
            this.Name = "VehicleCategoryView";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.VehicleCategoryView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.ErrorProvider Err;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridView GVCategories;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcatid;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcat_desc;
    }
}