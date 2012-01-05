using TaxiManager.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace TaxiManagerTester
{
    
    
    /// <summary>
    ///This is a test class for FuelModelTest and is intended
    ///to contain all FuelModelTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FuelModelTest
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
        ///A test for FuelModel Constructor
        ///</summary>
        [TestMethod()]
        public void FuelModelConstructorTest()
        {
            FuelModel target = new FuelModel();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for DeleteFuelType
        ///</summary>
        [TestMethod()]
        public void DeleteFuelTypeTest()
        {
            FuelModel target = new FuelModel(); // TODO: Initialize to an appropriate value
            int ftid = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.DeleteFuelType(ftid);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetFuelTable
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void GetFuelTableTest()
        {
            FuelModel_Accessor target = new FuelModel_Accessor(); // TODO: Initialize to an appropriate value
            string Clauses = string.Empty; // TODO: Initialize to an appropriate value
            DataTable expected = null; // TODO: Initialize to an appropriate value
            DataTable actual;
            actual = target.GetFuelTable(Clauses);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for InsertFuelType
        ///</summary>
        [TestMethod()]
        public void InsertFuelTypeTest()
        {
            FuelModel target = new FuelModel(); // TODO: Initialize to an appropriate value
            string ft_desc = string.Empty; // TODO: Initialize to an appropriate value
            int c_by = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.InsertFuelType(ft_desc, c_by);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UpdateFuelType
        ///</summary>
        [TestMethod()]
        public void UpdateFuelTypeTest()
        {
            FuelModel target = new FuelModel(); // TODO: Initialize to an appropriate value
            string ft_desc = string.Empty; // TODO: Initialize to an appropriate value
            int u_by = 0; // TODO: Initialize to an appropriate value
            int ftid = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.UpdateFuelType(ft_desc, u_by, ftid);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
