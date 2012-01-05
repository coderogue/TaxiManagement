namespace TaxiManager.View
{
    partial class USSideBanner
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USSideBanner));
            this.CalReminder = new System.Windows.Forms.MonthCalendar();
            this.LstReminder = new System.Windows.Forms.ListBox();
            this.LblReminder = new System.Windows.Forms.Label();
            this.ImgRefresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // CalReminder
            // 
            this.CalReminder.Location = new System.Drawing.Point(9, 9);
            this.CalReminder.Name = "CalReminder";
            this.CalReminder.TabIndex = 0;
            this.CalReminder.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.CalReminder_DateSelected);
            // 
            // LstReminder
            // 
            this.LstReminder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LstReminder.FormattingEnabled = true;
            this.LstReminder.Location = new System.Drawing.Point(9, 201);
            this.LstReminder.Name = "LstReminder";
            this.LstReminder.Size = new System.Drawing.Size(227, 251);
            this.LstReminder.TabIndex = 1;
            // 
            // LblReminder
            // 
            this.LblReminder.AutoSize = true;
            this.LblReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReminder.Location = new System.Drawing.Point(6, 180);
            this.LblReminder.Name = "LblReminder";
            this.LblReminder.Size = new System.Drawing.Size(86, 20);
            this.LblReminder.TabIndex = 2;
            this.LblReminder.Text = "Reminder";
            // 
            // ImgRefresh
            // 
            this.ImgRefresh.Image = ((System.Drawing.Image)(resources.GetObject("ImgRefresh.Image")));
            this.ImgRefresh.Location = new System.Drawing.Point(216, 180);
            this.ImgRefresh.Name = "ImgRefresh";
            this.ImgRefresh.Size = new System.Drawing.Size(20, 20);
            this.ImgRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImgRefresh.TabIndex = 3;
            this.ImgRefresh.TabStop = false;
            this.ImgRefresh.Click += new System.EventHandler(this.ImgRefresh_Click);
            // 
            // USSideBanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ImgRefresh);
            this.Controls.Add(this.LblReminder);
            this.Controls.Add(this.LstReminder);
            this.Controls.Add(this.CalReminder);
            this.Name = "USSideBanner";
            this.Size = new System.Drawing.Size(245, 465);
            this.Load += new System.EventHandler(this.USSideBanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar CalReminder;
        private System.Windows.Forms.ListBox LstReminder;
        private System.Windows.Forms.Label LblReminder;
        private System.Windows.Forms.PictureBox ImgRefresh;
    }
}
