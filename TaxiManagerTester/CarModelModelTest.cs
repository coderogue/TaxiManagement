using TaxiManager.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace TaxiManagerTester
{
    
    
    /// <summary>
    ///This is a test class for CarModelModelTest and is intended
    ///to contain all CarModelModelTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CarModelModelTest
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
        ///A test for CarModelModel Constructor
        ///</summary>
        [TestMethod()]
        public void CarModelModelConstructorTest()
        {
            CarModelModel target = new CarModelModel();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for DeleteRow
        ///</summary>
        [TestMethod()]
        public void DeleteRowTest()
        {
            CarModelModel target = new CarModelModel(); // TODO: Initialize to an appropriate value
            int mmid = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.DeleteRow(mmid);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetCarModels
        ///</summary>
        [TestMethod()]
        public void GetCarModelsTest()
        {
            CarModelModel target = new CarModelModel(); // TODO: Initialize to an appropriate value
            string Clauses = string.Empty; // TODO: Initialize to an appropriate value
            DataTable expected = null; // TODO: Initialize to an appropriate value
            DataTable actual;
            actual = target.GetCarModels(Clauses);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for InsertRow
        ///</summary>
        [TestMethod()]
        public void InsertRowTest()
        {
            CarModelModel target = new CarModelModel(); // TODO: Initialize to an appropriate value
            int mm_cmid = 0; // TODO: Initialize to an appropriate value
            string mm_name = string.Empty; // TODO: Initialize to an appropriate value
            int c_by = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.InsertRow(mm_cmid, mm_name, c_by);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UpdateRow
        ///</summary>
        [TestMethod()]
        public void UpdateRowTest()
        {
            CarModelModel target = new CarModelModel(); // TODO: Initialize to an appropriate value
            int mm_cmid = 0; // TODO: Initialize to an appropriate value
            string mm_name = string.Empty; // TODO: Initialize to an appropriate value
            int u_by = 0; // TODO: Initialize to an appropriate value
            int mmid = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.UpdateRow(mm_cmid, mm_name, u_by, mmid);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
