using TaxiManager.View.VehicleSettings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TaxiManagerTester
{
    
    
    /// <summary>
    ///This is a test class for CarModelFormTest and is intended
    ///to contain all CarModelFormTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CarModelFormTest
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
        ///A test for CarModelForm Constructor
        ///</summary>
        [TestMethod()]
        public void CarModelFormConstructorTest()
        {
            CarModelForm target = new CarModelForm();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for BtnCancel_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void BtnCancel_ClickTest()
        {
            CarModelForm_Accessor target = new CarModelForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.BtnCancel_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for BtnSave_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void BtnSave_ClickTest()
        {
            CarModelForm_Accessor target = new CarModelForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.BtnSave_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for CarModelForm_Load
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void CarModelForm_LoadTest()
        {
            CarModelForm_Accessor target = new CarModelForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.CarModelForm_Load(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void DisposeTest()
        {
            CarModelForm_Accessor target = new CarModelForm_Accessor(); // TODO: Initialize to an appropriate value
            bool disposing = false; // TODO: Initialize to an appropriate value
            target.Dispose(disposing);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void InitializeComponentTest()
        {
            CarModelForm_Accessor target = new CarModelForm_Accessor(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
