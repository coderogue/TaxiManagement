using TaxiManager.taxi_managementDataSetTableAdapters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaxiManager;
using System.Data;
using MySql.Data.MySqlClient;

namespace TaxiManagerTester
{
    
    
    /// <summary>
    ///This is a test class for car_madeTableAdapterTest and is intended
    ///to contain all car_madeTableAdapterTest Unit Tests
    ///</summary>
    [TestClass()]
    public class car_madeTableAdapterTest
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
        ///A test for car_madeTableAdapter Constructor
        ///</summary>
        [TestMethod()]
        public void car_madeTableAdapterConstructorTest()
        {
            car_madeTableAdapter target = new car_madeTableAdapter();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        [TestMethod()]
        public void DeleteTest()
        {
            car_madeTableAdapter target = new car_madeTableAdapter(); // TODO: Initialize to an appropriate value
            uint Original_cmid = 0; // TODO: Initialize to an appropriate value
            string Original_cm_name = string.Empty; // TODO: Initialize to an appropriate value
            uint Original_c_by = 0; // TODO: Initialize to an appropriate value
            DateTime Original_c_date = new DateTime(); // TODO: Initialize to an appropriate value
            uint Original_u_by = 0; // TODO: Initialize to an appropriate value
            DateTime Original_u_date = new DateTime(); // TODO: Initialize to an appropriate value
            byte Original_rec_status = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Delete(Original_cmid, Original_cm_name, Original_c_by, Original_c_date, Original_u_by, Original_u_date, Original_rec_status);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Fill
        ///</summary>
        [TestMethod()]
        public void FillTest()
        {
            car_madeTableAdapter target = new car_madeTableAdapter(); // TODO: Initialize to an appropriate value
            taxi_managementDataSet.car_madeDataTable dataTable = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Fill(dataTable);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetData
        ///</summary>
        [TestMethod()]
        public void GetDataTest()
        {
            car_madeTableAdapter target = new car_madeTableAdapter(); // TODO: Initialize to an appropriate value
            taxi_managementDataSet.car_madeDataTable expected = null; // TODO: Initialize to an appropriate value
            taxi_managementDataSet.car_madeDataTable actual;
            actual = target.GetData();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for InitAdapter
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void InitAdapterTest()
        {
            car_madeTableAdapter_Accessor target = new car_madeTableAdapter_Accessor(); // TODO: Initialize to an appropriate value
            target.InitAdapter();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitCommandCollection
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void InitCommandCollectionTest()
        {
            car_madeTableAdapter_Accessor target = new car_madeTableAdapter_Accessor(); // TODO: Initialize to an appropriate value
            target.InitCommandCollection();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitConnection
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void InitConnectionTest()
        {
            car_madeTableAdapter_Accessor target = new car_madeTableAdapter_Accessor(); // TODO: Initialize to an appropriate value
            target.InitConnection();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Insert
        ///</summary>
        [TestMethod()]
        public void InsertTest()
        {
            car_madeTableAdapter target = new car_madeTableAdapter(); // TODO: Initialize to an appropriate value
            string cm_name = string.Empty; // TODO: Initialize to an appropriate value
            uint c_by = 0; // TODO: Initialize to an appropriate value
            DateTime c_date = new DateTime(); // TODO: Initialize to an appropriate value
            uint u_by = 0; // TODO: Initialize to an appropriate value
            DateTime u_date = new DateTime(); // TODO: Initialize to an appropriate value
            byte rec_status = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Insert(cm_name, c_by, c_date, u_by, u_date, rec_status);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Update
        ///</summary>
        [TestMethod()]
        public void UpdateTest()
        {
            car_madeTableAdapter target = new car_madeTableAdapter(); // TODO: Initialize to an appropriate value
            string cm_name = string.Empty; // TODO: Initialize to an appropriate value
            uint c_by = 0; // TODO: Initialize to an appropriate value
            DateTime c_date = new DateTime(); // TODO: Initialize to an appropriate value
            uint u_by = 0; // TODO: Initialize to an appropriate value
            DateTime u_date = new DateTime(); // TODO: Initialize to an appropriate value
            byte rec_status = 0; // TODO: Initialize to an appropriate value
            uint Original_cmid = 0; // TODO: Initialize to an appropriate value
            string Original_cm_name = string.Empty; // TODO: Initialize to an appropriate value
            uint Original_c_by = 0; // TODO: Initialize to an appropriate value
            DateTime Original_c_date = new DateTime(); // TODO: Initialize to an appropriate value
            uint Original_u_by = 0; // TODO: Initialize to an appropriate value
            DateTime Original_u_date = new DateTime(); // TODO: Initialize to an appropriate value
            byte Original_rec_status = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Update(cm_name, c_by, c_date, u_by, u_date, rec_status, Original_cmid, Original_cm_name, Original_c_by, Original_c_date, Original_u_by, Original_u_date, Original_rec_status);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Update
        ///</summary>
        [TestMethod()]
        public void UpdateTest1()
        {
            car_madeTableAdapter target = new car_madeTableAdapter(); // TODO: Initialize to an appropriate value
            DataRow[] dataRows = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Update(dataRows);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Update
        ///</summary>
        [TestMethod()]
        public void UpdateTest2()
        {
            car_madeTableAdapter target = new car_madeTableAdapter(); // TODO: Initialize to an appropriate value
            taxi_managementDataSet.car_madeDataTable dataTable = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Update(dataTable);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Update
        ///</summary>
        [TestMethod()]
        public void UpdateTest3()
        {
            car_madeTableAdapter target = new car_madeTableAdapter(); // TODO: Initialize to an appropriate value
            taxi_managementDataSet dataSet = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Update(dataSet);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Update
        ///</summary>
        [TestMethod()]
        public void UpdateTest4()
        {
            car_madeTableAdapter target = new car_madeTableAdapter(); // TODO: Initialize to an appropriate value
            DataRow dataRow = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Update(dataRow);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Adapter
        ///</summary>
        [TestMethod()]
        public void AdapterTest()
        {
            car_madeTableAdapter target = new car_madeTableAdapter(); // TODO: Initialize to an appropriate value
            MySqlDataAdapter actual;
            actual = target.Adapter;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ClearBeforeFill
        ///</summary>
        [TestMethod()]
        public void ClearBeforeFillTest()
        {
            car_madeTableAdapter target = new car_madeTableAdapter(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.ClearBeforeFill = expected;
            actual = target.ClearBeforeFill;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CommandCollection
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void CommandCollectionTest()
        {
            car_madeTableAdapter_Accessor target = new car_madeTableAdapter_Accessor(); // TODO: Initialize to an appropriate value
            MySqlCommand[] actual;
            actual = target.CommandCollection;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Connection
        ///</summary>
        [TestMethod()]
        public void ConnectionTest()
        {
            car_madeTableAdapter target = new car_madeTableAdapter(); // TODO: Initialize to an appropriate value
            MySqlConnection expected = null; // TODO: Initialize to an appropriate value
            MySqlConnection actual;
            target.Connection = expected;
            actual = target.Connection;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Transaction
        ///</summary>
        [TestMethod()]
        public void TransactionTest()
        {
            car_madeTableAdapter target = new car_madeTableAdapter(); // TODO: Initialize to an appropriate value
            MySqlTransaction expected = null; // TODO: Initialize to an appropriate value
            MySqlTransaction actual;
            target.Transaction = expected;
            actual = target.Transaction;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
