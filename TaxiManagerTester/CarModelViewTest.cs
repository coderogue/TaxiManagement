using TaxiManager.View.VehicleSettings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace TaxiManagerTester
{
    
    
    /// <summary>
    ///This is a test class for CarModelViewTest and is intended
    ///to contain all CarModelViewTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CarModelViewTest
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
        ///A test for CarModelView Constructor
        ///</summary>
        [TestMethod()]
        public void CarModelViewConstructorTest()
        {
            CarModelView target = new CarModelView();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for BtnDelete_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void BtnDelete_ClickTest()
        {
            CarModelView_Accessor target = new CarModelView_Accessor(); // TODO: Initialize to an appropriate value
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
            CarModelView_Accessor target = new CarModelView_Accessor(); // TODO: Initialize to an appropriate value
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
            CarModelView_Accessor target = new CarModelView_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.BtnSearch_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for CarModelView_Load
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void CarModelView_LoadTest()
        {
            CarModelView_Accessor target = new CarModelView_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.CarModelView_Load(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void DisposeTest()
        {
            CarModelView_Accessor target = new CarModelView_Accessor(); // TODO: Initialize to an appropriate value
            bool disposing = false; // TODO: Initialize to an appropriate value
            target.Dispose(disposing);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GVModel_CellEndEdit
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void GVModel_CellEndEditTest()
        {
            CarModelView_Accessor target = new CarModelView_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            DataGridViewCellEventArgs e = null; // TODO: Initialize to an appropriate value
            target.GVModel_CellEndEdit(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void InitializeComponentTest()
        {
            CarModelView_Accessor target = new CarModelView_Accessor(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
