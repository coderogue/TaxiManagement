namespace TaxiManager.View.VehicleSettings
{
    partial class ClassTypeView
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
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.GVModel = new System.Windows.Forms.DataGridView();
            this.ctid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ct_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVModel)).BeginInit();
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
            // GVModel
            // 
            this.GVModel.AllowUserToAddRows = false;
            this.GVModel.AllowUserToOrderColumns = true;
            this.GVModel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GVModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVModel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ctid,
            this.ct_desc});
            this.GVModel.Location = new System.Drawing.Point(12, 62);
            this.GVModel.MultiSelect = false;
            this.GVModel.Name = "GVModel";
            this.GVModel.Size = new System.Drawing.Size(390, 196);
            this.GVModel.TabIndex = 12;
            this.GVModel.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVModel_CellEndEdit);
            // 
            // ctid
            // 
            this.ctid.DataPropertyName = "ctid";
            this.ctid.HeaderText = "ctid";
            this.ctid.Name = "ctid";
            this.ctid.ReadOnly = true;
            this.ctid.Visible = false;
            // 
            // ct_desc
            // 
            this.ct_desc.DataPropertyName = "ct_desc";
            this.ct_desc.HeaderText = "Class Type";
            this.ct_desc.Name = "ct_desc";
            this.ct_desc.Width = 200;
            // 
            // ClassTypeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 308);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.GVModel);
            this.Name = "ClassTypeView";
            this.Text = "Class Types";
            this.Load += new System.EventHandler(this.ClassTypeView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVModel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.ErrorProvider Err;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridView GVModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ct_desc;
    }
}