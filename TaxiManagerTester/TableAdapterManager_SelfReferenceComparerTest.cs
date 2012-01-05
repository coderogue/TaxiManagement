using TaxiManager.taxi_managementDataSetTableAdapters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace TaxiManagerTester
{
    
    
    /// <summary>
    ///This is a test class for TableAdapterManager_SelfReferenceComparerTest and is intended
    ///to contain all TableAdapterManager_SelfReferenceComparerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TableAdapterManager_SelfReferenceComparerTest
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
        ///A test for SelfReferenceComparer Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void TableAdapterManager_SelfReferenceComparerConstructorTest()
        {
            DataRelation relation = null; // TODO: Initialize to an appropriate value
            bool childFirst = false; // TODO: Initialize to an appropriate value
            TableAdapterManager_Accessor.SelfReferenceComparer target = new TableAdapterManager_Accessor.SelfReferenceComparer(relation, childFirst);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Compare
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void CompareTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            TableAdapterManager_Accessor.SelfReferenceComparer target = new TableAdapterManager_Accessor.SelfReferenceComparer(param0); // TODO: Initialize to an appropriate value
            DataRow row1 = null; // TODO: Initialize to an appropriate value
            DataRow row2 = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Compare(row1, row2);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetRoot
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void GetRootTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            TableAdapterManager_Accessor.SelfReferenceComparer target = new TableAdapterManager_Accessor.SelfReferenceComparer(param0); // TODO: Initialize to an appropriate value
            DataRow row = null; // TODO: Initialize to an appropriate value
            int distance = 0; // TODO: Initialize to an appropriate value
            int distanceExpected = 0; // TODO: Initialize to an appropriate value
            DataRow expected = null; // TODO: Initialize to an appropriate value
            DataRow actual;
            actual = target.GetRoot(row, out distance);
            Assert.AreEqual(distanceExpected, distance);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
