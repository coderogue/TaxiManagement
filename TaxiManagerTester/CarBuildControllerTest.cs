using TaxiManager.Controller;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace TaxiManagerTester
{
    
    
    /// <summary>
    ///This is a test class for CarBuildControllerTest and is intended
    ///to contain all CarBuildControllerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CarBuildControllerTest
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
        ///A test for CarBuildController Constructor
        ///</summary>
        [TestMethod()]
        public void CarBuildControllerConstructorTest()
        {
            CarBuildController target = new CarBuildController();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CountMakeType
        ///</summary>
        [TestMethod()]
        public void CountMakeTypeTest()
        {
            CarBuildController target = new CarBuildController(); // TODO: Initialize to an appropriate value
            string WildCard = string.Empty; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.CountMakeType(WildCard);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DeleteRow
        ///</summary>
        [TestMethod()]
        public void DeleteRowTest()
        {
            CarBuildController target = new CarBuildController(); // TODO: Initialize to an appropriate value
            int RowIndex = 0; // TODO: Initialize to an appropriate value
            target.DeleteRow(RowIndex);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetMakeType
        ///</summary>
        [TestMethod()]
        public void GetMakeTypeTest()
        {
            CarBuildController target = new CarBuildController(); // TODO: Initialize to an appropriate value
            DataTable expected = null; // TODO: Initialize to an appropriate value
            DataTable actual;
            actual = target.GetMakeType();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetMakeType
        ///</summary>
        [TestMethod()]
        public void GetMakeTypeTest1()
        {
            CarBuildController target = new CarBuildController(); // TODO: Initialize to an appropriate value
            string WildCard = string.Empty; // TODO: Initialize to an appropriate value
            DataTable expected = null; // TODO: Initialize to an appropriate value
            DataTable actual;
            actual = target.GetMakeType(WildCard);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetMakeType
        ///</summary>
        [TestMethod()]
        public void GetMakeTypeTest2()
        {
            CarBuildController target = new CarBuildController(); // TODO: Initialize to an appropriate value
            int RowIndex = 0; // TODO: Initialize to an appropriate value
            DataTable expected = null; // TODO: Initialize to an appropriate value
            DataTable actual;
            actual = target.GetMakeType(RowIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for InsertRow
        ///</summary>
        [TestMethod()]
        public void InsertRowTest()
        {
            CarBuildController target = new CarBuildController(); // TODO: Initialize to an appropriate value
            string MakeName = string.Empty; // TODO: Initialize to an appropriate value
            int CreatedBy = 0; // TODO: Initialize to an appropriate value
            target.InsertRow(MakeName, CreatedBy);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for UpdateRow
        ///</summary>
        [TestMethod()]
        public void UpdateRowTest()
        {
            CarBuildController target = new CarBuildController(); // TODO: Initialize to an appropriate value
            string MakeName = string.Empty; // TODO: Initialize to an appropriate value
            int UpdateBy = 0; // TODO: Initialize to an appropriate value
            int RowIndex = 0; // TODO: Initialize to an appropriate value
            target.UpdateRow(MakeName, UpdateBy, RowIndex);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
