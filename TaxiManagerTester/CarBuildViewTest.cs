using TaxiManager.View.VehicleSettings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace TaxiManagerTester
{
    
    
    /// <summary>
    ///This is a test class for CarBuildViewTest and is intended
    ///to contain all CarBuildViewTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CarBuildViewTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for CarBuildView Constructor
        ///</summary>
        [TestMethod()]
        public void CarBuildViewConstructorTest()
        {
            CarBuildView target = new CarBuildView();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for BtnDelete_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void BtnDelete_ClickTest()
        {
            CarBuildView_Accessor target = new CarBuildView_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.BtnDelete_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for BtnNew_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void BtnNew_ClickTest()
        {
            CarBuildView_Accessor target = new CarBuildView_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.BtnNew_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for BtnSearch_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void BtnSearch_ClickTest()
        {
            CarBuildView_Accessor target = new CarBuildView_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.BtnSearch_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for CarBuildView_Load
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void CarBuildView_LoadTest()
        {
            CarBuildView_Accessor target = new CarBuildView_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.CarBuildView_Load(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void DisposeTest()
        {
            CarBuildView_Accessor target = new CarBuildView_Accessor(); // TODO: Initialize to an appropriate value
            bool disposing = false; // TODO: Initialize to an appropriate value
            target.Dispose(disposing);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GVMake_CellEndEdit
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void GVMake_CellEndEditTest()
        {
            CarBuildView_Accessor target = new CarBuildView_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            DataGridViewCellEventArgs e = null; // TODO: Initialize to an appropriate value
            target.GVMake_CellEndEdit(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GVMake_UserDeletingRow
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void GVMake_UserDeletingRowTest()
        {
            CarBuildView_Accessor target = new CarBuildView_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            DataGridViewRowCancelEventArgs e = null; // TODO: Initialize to an appropriate value
            target.GVMake_UserDeletingRow(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void InitializeComponentTest()
        {
            CarBuildView_Accessor target = new CarBuildView_Accessor(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
