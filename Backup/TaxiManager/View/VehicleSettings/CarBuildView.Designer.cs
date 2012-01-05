namespace TaxiManager.View.VehicleSettings
{
    partial class CarBuildView
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
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.GVMake = new System.Windows.Forms.DataGridView();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.cmid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GVMake)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(12, 33);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(309, 20);
            this.TxtSearch.TabIndex = 0;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(327, 31);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // GVMake
            // 
            this.GVMake.AllowUserToAddRows = false;
            this.GVMake.AllowUserToOrderColumns = true;
            this.GVMake.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GVMake.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVMake.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmid,
            this.cm_name});
            this.GVMake.Location = new System.Drawing.Point(12, 71);
            this.GVMake.MultiSelect = false;
            this.GVMake.Name = "GVMake";
            this.GVMake.Size = new System.Drawing.Size(390, 196);
            this.GVMake.TabIndex = 2;
            this.GVMake.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.GVMake_UserDeletingRow);
            this.GVMake.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVMake_RowEnter);
            this.GVMake.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVMake_CellEndEdit);
            // 
            // BtnNew
            // 
            this.BtnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNew.Location = new System.Drawing.Point(247, 273);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 1;
            this.BtnNew.Text = "Add New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Location = new System.Drawing.Point(328, 273);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 1;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // cmid
            // 
            this.cmid.DataPropertyName = "cmid";
            this.cmid.HeaderText = "cmid";
            this.cmid.Name = "cmid";
            this.cmid.ReadOnly = true;
            this.cmid.Visible = false;
            // 
            // cm_name
            // 
            this.cm_name.DataPropertyName = "cm_name";
            this.cm_name.HeaderText = "Car Make";
            this.cm_name.Name = "cm_name";
            this.cm_name.Width = 200;
            // 
            // CarBuildView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 308);
            this.Controls.Add(this.GVMake);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtSearch);
            this.Name = "CarBuildView";
            this.Text = "CarBuildView";
            this.Load += new System.EventHandler(this.CarBuildView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVMake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DataGridView GVMake;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_name;
    }
}