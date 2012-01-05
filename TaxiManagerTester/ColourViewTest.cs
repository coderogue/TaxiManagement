using TaxiManager.View.VehicleSettings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace TaxiManagerTester
{
    
    
    /// <summary>
    ///This is a test class for ColourViewTest and is intended
    ///to contain all ColourViewTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ColourViewTest
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
        ///A test for ColourView Constructor
        ///</summary>
        [TestMethod()]
        public void ColourViewConstructorTest()
        {
            ColourView target = new ColourView();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for BtnDelete_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void BtnDelete_ClickTest()
        {
            ColourView_Accessor target = new ColourView_Accessor(); // TODO: Initialize to an appropriate value
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
            ColourView_Accessor target = new ColourView_Accessor(); // TODO: Initialize to an appropriate value
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
            ColourView_Accessor target = new ColourView_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.BtnSearch_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ColourView_Load
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void ColourView_LoadTest()
        {
            ColourView_Accessor target = new ColourView_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.ColourView_Load(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void DisposeTest()
        {
            ColourView_Accessor target = new ColourView_Accessor(); // TODO: Initialize to an appropriate value
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
            ColourView_Accessor target = new ColourView_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            DataGridViewCellEventArgs e = null; // TODO: Initialize to an appropriate value
            target.GVMake_CellEndEdit(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void InitializeComponentTest()
        {
            ColourView_Accessor target = new ColourView_Accessor(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
