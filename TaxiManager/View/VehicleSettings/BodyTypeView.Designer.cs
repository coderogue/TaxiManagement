namespace TaxiManager.View.VehicleSettings
{
    partial class BodyTypeView
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
            this.GVBodyType = new System.Windows.Forms.DataGridView();
            this.Err = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnSearch = new System.Windows.Forms.Button();
            this.btid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GVBodyType)).BeginInit();
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
            // GVBodyType
            // 
            this.GVBodyType.AllowUserToAddRows = false;
            this.GVBodyType.AllowUserToOrderColumns = true;
            this.GVBodyType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GVBodyType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVBodyType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btid,
            this.bt_desc});
            this.GVBodyType.Location = new System.Drawing.Point(12, 62);
            this.GVBodyType.MultiSelect = false;
            this.GVBodyType.Name = "GVBodyType";
            this.GVBodyType.Size = new System.Drawing.Size(390, 196);
            this.GVBodyType.TabIndex = 7;
            this.GVBodyType.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVBodyType_CellEndEdit);
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
            // btid
            // 
            this.btid.DataPropertyName = "btid";
            this.btid.HeaderText = "btid";
            this.btid.Name = "btid";
            this.btid.ReadOnly = true;
            this.btid.Visible = false;
            // 
            // bt_desc
            // 
            this.bt_desc.DataPropertyName = "bt_desc";
            this.bt_desc.HeaderText = "Body Type";
            this.bt_desc.Name = "bt_desc";
            this.bt_desc.Width = 200;
            // 
            // BodyTypeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 308);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.GVBodyType);
            this.Controls.Add(this.BtnSearch);
            this.Name = "BodyTypeView";
            this.Text = "Body Types";
            this.Load += new System.EventHandler(this.BodyTypeView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVBodyType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridView GVBodyType;
        private System.Windows.Forms.DataGridViewTextBoxColumn btid;
        private System.Windows.Forms.DataGridViewTextBoxColumn bt_desc;
        private System.Windows.Forms.ErrorProvider Err;
        private System.Windows.Forms.Button BtnSearch;
    }
}