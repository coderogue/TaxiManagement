using TaxiManager.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace TaxiManagerTest2
{
    
    
    /// <summary>
    ///This is a test class for RoadTaxModelTest and is intended
    ///to contain all RoadTaxModelTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RoadTaxModelTest
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
        ///A test for RoadTaxList
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void RoadTaxListTest()
        {
            RoadTaxModel_Accessor target = new RoadTaxModel_Accessor(); // TODO: Initialize to an appropriate value
            int taxiid = 0; // TODO: Initialize to an appropriate value
            string Clauses = string.Empty; // TODO: Initialize to an appropriate value
            DataTable expected = null; // TODO: Initialize to an appropriate value
            DataTable actual;
            actual = target.RoadTaxList(taxiid, Clauses);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
