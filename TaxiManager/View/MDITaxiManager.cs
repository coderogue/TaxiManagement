using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaxiManager.View
{
    public partial class MDITaxiManager : Form
    {
        private int childFormNumber = 0;

        public MDITaxiManager()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void MDITaxiManager_Load(object sender, EventArgs e)
        {

        }

        private void makeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.VehicleSettings.CarBuildView ChildForm = new TaxiManager.View.VehicleSettings.CarBuildView();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void modelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.VehicleSettings.CarModelView ChildForm = new TaxiManager.View.VehicleSettings.CarModelView();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void bodyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.VehicleSettings.BodyTypeView ChildForm = new VehicleSettings.BodyTypeView();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.VehicleSettings.ColourView ChildForm = new VehicleSettings.ColourView();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fuelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.VehicleSettings.FuelView ChildForm = new VehicleSettings.FuelView();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.Companies.CompanyView ChildForm = new Companies.CompanyView();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehicleSettings.VehicleCategoryView ChildForm = new VehicleSettings.VehicleCategoryView();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void vehicleRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Taxi.TaxiView ChildForm = new Taxi.TaxiView();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void classToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehicleSettings.ClassTypeView ChildForm = new VehicleSettings.ClassTypeView();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void ownerStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehicleSettings.OwnerStatusView ChildForm = new VehicleSettings.OwnerStatusView();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }
    }
}
