using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaxiManager.View
{
    public partial class USSideBanner : UserControl
    {
        private Controller.USSideBannerController control = new Controller.USSideBannerController();

        public USSideBanner()
        {
            InitializeComponent();
        }

        private void USSideBanner_Load(object sender, EventArgs e)
        {
            LstReminder.DataSource = control.GetRoadTax();
        }

        private void CalReminder_DateSelected(object sender, DateRangeEventArgs e)
        {
            
        }

        private void ImgRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
