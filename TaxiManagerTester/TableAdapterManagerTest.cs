using TaxiManager.taxi_managementDataSetTableAdapters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Collections.Generic;
using TaxiManager;

namespace TaxiManagerTester
{
    
    
    /// <summary>
    ///This is a test class for TableAdapterManagerTest and is intended
    ///to contain all TableAdapterManagerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TableAdapterManagerTest
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
        ///A test for TableAdapterManager Constructor
        ///</summary>
        [TestMethod()]
        public void TableAdapterManagerConstructorTest()
        {
            TableAdapterManager target = new TableAdapterManager();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GetRealUpdatedRows
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void GetRealUpdatedRowsTest()
        {
            TableAdapterManager_Accessor target = new TableAdapterManager_Accessor(); // TODO: Initialize to an appropriate value
            DataRow[] updatedRows = null; // TODO: Initialize to an appropriate value
            List<DataRow> allAddedRows = null; // TODO: Initialize to an appropriate value
            DataRow[] expected = null; // TODO: Initialize to an appropriate value
            DataRow[] actual;
            actual = target.GetRealUpdatedRows(updatedRows, allAddedRows);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MatchTableAdapterConnection
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void MatchTableAdapterConnectionTest()
        {
            TableAdapterManager_Accessor target = new TableAdapterManager_Accessor(); // TODO: Initialize to an appropriate value
            IDbConnection inputConnection = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.MatchTableAdapterConnection(inputConnection);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SortSelfReferenceRows
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void SortSelfReferenceRowsTest()
        {
            TableAdapterManager_Accessor target = new TableAdapterManager_Accessor(); // TODO: Initialize to an appropriate value
            DataRow[] rows = null; // TODO: Initialize to an appropriate value
            DataRelation relation = null; // TODO: Initialize to an appropriate value
            bool childFirst = false; // TODO: Initialize to an appropriate value
            target.SortSelfReferenceRows(rows, relation, childFirst);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for UpdateAll
        ///</summary>
        [TestMethod()]
        public void UpdateAllTest()
        {
            TableAdapterManager target = new TableAdapterManager(); // TODO: Initialize to an appropriate value
            taxi_managementDataSet dataSet = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.UpdateAll(dataSet);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UpdateDeletedRows
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void UpdateDeletedRowsTest()
        {
            TableAdapterManager_Accessor target = new TableAdapterManager_Accessor(); // TODO: Initialize to an appropriate value
            taxi_managementDataSet dataSet = null; // TODO: Initialize to an appropriate value
            List<DataRow> allChangedRows = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.UpdateDeletedRows(dataSet, allChangedRows);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UpdateInsertedRows
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void UpdateInsertedRowsTest()
        {
            TableAdapterManager_Accessor target = new TableAdapterManager_Accessor(); // TODO: Initialize to an appropriate value
            taxi_managementDataSet dataSet = null; // TODO: Initialize to an appropriate value
            List<DataRow> allAddedRows = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.UpdateInsertedRows(dataSet, allAddedRows);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UpdateUpdatedRows
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void UpdateUpdatedRowsTest()
        {
            TableAdapterManager_Accessor target = new TableAdapterManager_Accessor(); // TODO: Initialize to an appropriate value
            taxi_managementDataSet dataSet = null; // TODO: Initialize to an appropriate value
            List<DataRow> allChangedRows = null; // TODO: Initialize to an appropriate value
            List<DataRow> allAddedRows = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for BackupDataSetBeforeUpdate
        ///</summary>
        [TestMethod()]
        public void BackupDataSetBeforeUpdateTest()
        {
            TableAdapterManager target = new TableAdapterManager(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.BackupDataSetBeforeUpdate = expected;
            actual = target.BackupDataSetBeforeUpdate;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Connection
        ///</summary>
        [TestMethod()]
        public void ConnectionTest()
        {
            TableAdapterManager target = new TableAdapterManager(); // TODO: Initialize to an appropriate value
            IDbConnection expected = null; // TODO: Initialize to an appropriate value
            IDbConnection actual;
            target.Connection = expected;
            actual = target.Connection;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TableAdapterInstanceCount
        ///</summary>
        [TestMethod()]
        public void TableAdapterInstanceCountTest()
        {
            TableAdapterManager target = new TableAdapterManager(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.TableAdapterInstanceCount;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UpdateOrder
        ///</summary>
        [TestMethod()]
        public void UpdateOrderTest()
        {
            TableAdapterManager target = new TableAdapterManager(); // TODO: Initialize to an appropriate value
            TableAdapterManager.UpdateOrderOption expected = new TableAdapterManager.UpdateOrderOption(); // TODO: Initialize to an appropriate value
            TableAdapterManager.UpdateOrderOption actual;
            target.UpdateOrder = expected;
            actual = target.UpdateOrder;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for car_madeTableAdapter
        ///</summary>
        [TestMethod()]
        public void car_madeTableAdapterTest()
        {
            TableAdapterManager target = new TableAdapterManager(); // TODO: Initialize to an appropriate value
            car_madeTableAdapter expected = null; // TODO: Initialize to an appropriate value
            car_madeTableAdapter actual;
            target.car_madeTableAdapter = expected;
            actual = target.car_madeTableAdapter;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
