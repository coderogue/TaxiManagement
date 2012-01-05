namespace TaxiManager.View.VehicleSettings
{
    partial class OwnerStatusView
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
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.GVOwnerStatus = new System.Windows.Forms.DataGridView();
            this.osid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.os_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Err = new System.Windows.Forms.ErrorProvider(this.components);
            this.TxtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GVOwnerStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Location = new System.Drawing.Point(328, 264);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 16;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(327, 22);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 14;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNew.Location = new System.Drawing.Point(247, 264);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 15;
            this.BtnNew.Text = "Add New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // GVOwnerStatus
            // 
            this.GVOwnerStatus.AllowUserToAddRows = false;
            this.GVOwnerStatus.AllowUserToOrderColumns = true;
            this.GVOwnerStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GVOwnerStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVOwnerStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.osid,
            this.os_desc});
            this.GVOwnerStatus.Location = new System.Drawing.Point(12, 62);
            this.GVOwnerStatus.MultiSelect = false;
            this.GVOwnerStatus.Name = "GVOwnerStatus";
            this.GVOwnerStatus.Size = new System.Drawing.Size(390, 196);
            this.GVOwnerStatus.TabIndex = 17;
            this.GVOwnerStatus.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVOwnerStatus_CellEndEdit);
            // 
            // osid
            // 
            this.osid.DataPropertyName = "osid";
            this.osid.HeaderText = "osid";
            this.osid.Name = "osid";
            this.osid.ReadOnly = true;
            this.osid.Visible = false;
            // 
            // os_desc
            // 
            this.os_desc.DataPropertyName = "os_desc";
            this.os_desc.HeaderText = "Owner Status";
            this.os_desc.Name = "os_desc";
            this.os_desc.Width = 200;
            // 
            // Err
            // 
            this.Err.ContainerControl = this;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(12, 24);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(309, 20);
            this.TxtSearch.TabIndex = 13;
            // 
            // OwnerStatusView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 308);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.GVOwnerStatus);
            this.Controls.Add(this.TxtSearch);
            this.Name = "OwnerStatusView";
            this.Text = "Owner Status";
            this.Load += new System.EventHandler(this.OwnerStatusView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVOwnerStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.DataGridView GVOwnerStatus;
        private System.Windows.Forms.ErrorProvider Err;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn osid;
        private System.Windows.Forms.DataGridViewTextBoxColumn os_desc;
    }
}