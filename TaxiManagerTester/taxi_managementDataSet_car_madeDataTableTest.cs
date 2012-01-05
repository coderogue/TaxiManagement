using TaxiManager;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.Serialization;
using System.Data;
using System.Xml.Schema;

namespace TaxiManagerTester
{
    
    
    /// <summary>
    ///This is a test class for taxi_managementDataSet_car_madeDataTableTest and is intended
    ///to contain all taxi_managementDataSet_car_madeDataTableTest Unit Tests
    ///</summary>
    [TestClass()]
    public class taxi_managementDataSet_car_madeDataTableTest
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
        ///A test for car_madeDataTable Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void taxi_managementDataSet_car_madeDataTableConstructorTest()
        {
            SerializationInfo info = null; // TODO: Initialize to an appropriate value
            StreamingContext context = new StreamingContext(); // TODO: Initialize to an appropriate value
            taxi_managementDataSet_Accessor.car_madeDataTable target = new taxi_managementDataSet_Accessor.car_madeDataTable(info, context);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for car_madeDataTable Constructor
        ///</summary>
        [TestMethod()]
        public void taxi_managementDataSet_car_madeDataTableConstructorTest1()
        {
            DataTable table = null; // TODO: Initialize to an appropriate value
            taxi_managementDataSet.car_madeDataTable target = new taxi_managementDataSet.car_madeDataTable(table);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for car_madeDataTable Constructor
        ///</summary>
        [TestMethod()]
        public void taxi_managementDataSet_car_madeDataTableConstructorTest2()
        {
            taxi_managementDataSet.car_madeDataTable target = new taxi_managementDataSet.car_madeDataTable();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Addcar_madeRow
        ///</summary>
        [TestMethod()]
        public void Addcar_madeRowTest()
        {
            taxi_managementDataSet.car_madeDataTable target = new taxi_managementDataSet.car_madeDataTable(); // TODO: Initialize to an appropriate value
            uint cmid = 0; // TODO: Initialize to an appropriate value
            string cm_name = string.Empty; // TODO: Initialize to an appropriate value
            uint c_by = 0; // TODO: Initialize to an appropriate value
            DateTime c_date = new DateTime(); // TODO: Initialize to an appropriate value
            uint u_by = 0; // TODO: Initialize to an appropriate value
            DateTime u_date = new DateTime(); // TODO: Initialize to an appropriate value
            bool rec_status = false; // TODO: Initialize to an appropriate value
            taxi_managementDataSet.car_madeRow expected = null; // TODO: Initialize to an appropriate value
            taxi_managementDataSet.car_madeRow actual;
            actual = target.Addcar_madeRow(cmid, cm_name, c_by, c_date, u_by, u_date, rec_status);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Addcar_madeRow
        ///</summary>
        [TestMethod()]
        public void Addcar_madeRowTest1()
        {
            taxi_managementDataSet.car_madeDataTable target = new taxi_managementDataSet.car_madeDataTable(); // TODO: Initialize to an appropriate value
            taxi_managementDataSet.car_madeRow row = null; // TODO: Initialize to an appropriate value
            target.Addcar_madeRow(row);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Clone
        ///</summary>
        [TestMethod()]
        public void CloneTest()
        {
            taxi_managementDataSet.car_madeDataTable target = new taxi_managementDataSet.car_madeDataTable(); // TODO: Initialize to an appropriate value
            DataTable expected = null; // TODO: Initialize to an appropriate value
            DataTable actual;
            actual = target.Clone();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CreateInstance
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void CreateInstanceTest()
        {
            taxi_managementDataSet_Accessor.car_madeDataTable target = new taxi_managementDataSet_Accessor.car_madeDataTable(); // TODO: Initialize to an appropriate value
            DataTable expected = null; // TODO: Initialize to an appropriate value
            DataTable actual;
            actual = target.CreateInstance();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FindBycmid
        ///</summary>
        [TestMethod()]
        public void FindBycmidTest()
        {
            taxi_managementDataSet.car_madeDataTable target = new taxi_managementDataSet.car_madeDataTable(); // TODO: Initialize to an appropriate value
            uint cmid = 0; // TODO: Initialize to an appropriate value
            taxi_managementDataSet.car_madeRow expected = null; // TODO: Initialize to an appropriate value
            taxi_managementDataSet.car_madeRow actual;
            actual = target.FindBycmid(cmid);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetRowType
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void GetRowTypeTest()
        {
            taxi_managementDataSet_Accessor.car_madeDataTable target = new taxi_managementDataSet_Accessor.car_madeDataTable(); // TODO: Initialize to an appropriate value
            Type expected = null; // TODO: Initialize to an appropriate value
            Type actual;
            actual = target.GetRowType();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetTypedTableSchema
        ///</summary>
        [TestMethod()]
        public void GetTypedTableSchemaTest()
        {
            XmlSchemaSet xs = null; // TODO: Initialize to an appropriate value
            XmlSchemaComplexType expected = null; // TODO: Initialize to an appropriate value
            XmlSchemaComplexType actual;
            actual = taxi_managementDataSet.car_madeDataTable.GetTypedTableSchema(xs);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for InitClass
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void InitClassTest()
        {
            taxi_managementDataSet_Accessor.car_madeDataTable target = new taxi_managementDataSet_Accessor.car_madeDataTable(); // TODO: Initialize to an appropriate value
            target.InitClass();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitVars
        ///</summary>
        [TestMethod()]
        public void InitVarsTest()
        {
            taxi_managementDataSet.car_madeDataTable target = new taxi_managementDataSet.car_madeDataTable(); // TODO: Initialize to an appropriate value
            target.InitVars();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for NewRowFromBuilder
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void NewRowFromBuilderTest()
        {
            taxi_managementDataSet_Accessor.car_madeDataTable target = new taxi_managementDataSet_Accessor.car_madeDataTable(); // TODO: Initialize to an appropriate value
            DataRowBuilder builder = null; // TODO: Initialize to an appropriate value
            DataRow expected = null; // TODO: Initialize to an appropriate value
            DataRow actual;
            actual = target.NewRowFromBuilder(builder);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Newcar_madeRow
        ///</summary>
        [TestMethod()]
        public void Newcar_madeRowTest()
        {
            taxi_managementDataSet.car_madeDataTable target = new taxi_managementDataSet.car_madeDataTable(); // TODO: Initialize to an appropriate value
            taxi_managementDataSet.car_madeRow expected = null; // TODO: Initialize to an appropriate value
            taxi_managementDataSet.car_madeRow actual;
            actual = target.Newcar_madeRow();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for OnRowChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void OnRowChangedTest()
        {
            taxi_managementDataSet_Accessor.car_madeDataTable target = new taxi_managementDataSet_Accessor.car_madeDataTable(); // TODO: Initialize to an appropriate value
            DataRowChangeEventArgs e = null; // TODO: Initialize to an appropriate value
            target.OnRowChanged(e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OnRowChanging
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void OnRowChangingTest()
        {
            taxi_managementDataSet_Accessor.car_madeDataTable target = new taxi_managementDataSet_Accessor.car_madeDataTable(); // TODO: Initialize to an appropriate value
            DataRowChangeEventArgs e = null; // TODO: Initialize to an appropriate value
            target.OnRowChanging(e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OnRowDeleted
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void OnRowDeletedTest()
        {
            taxi_managementDataSet_Accessor.car_madeDataTable target = new taxi_managementDataSet_Accessor.car_madeDataTable(); // TODO: Initialize to an appropriate value
            DataRowChangeEventArgs e = null; // TODO: Initialize to an appropriate value
            target.OnRowDeleted(e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OnRowDeleting
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void OnRowDeletingTest()
        {
            taxi_managementDataSet_Accessor.car_madeDataTable target = new taxi_managementDataSet_Accessor.car_madeDataTable(); // TODO: Initialize to an appropriate value
            DataRowChangeEventArgs e = null; // TODO: Initialize to an appropriate value
            target.OnRowDeleting(e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Removecar_madeRow
        ///</summary>
        [TestMethod()]
        public void Removecar_madeRowTest()
        {
            taxi_managementDataSet.car_madeDataTable target = new taxi_managementDataSet.car_madeDataTable(); // TODO: Initialize to an appropriate value
            taxi_managementDataSet.car_madeRow row = null; // TODO: Initialize to an appropriate value
            target.Removecar_madeRow(row);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Count
        ///</summary>
        [TestMethod()]
        public void CountTest()
        {
            taxi_managementDataSet.car_madeDataTable target = new taxi_managementDataSet.car_madeDataTable(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Count;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        [TestMethod()]
        public void ItemTest()
        {
            taxi_managementDataSet.car_madeDataTable target = new taxi_managementDataSet.car_madeDataTable(); // TODO: Initialize to an appropriate value
            int index = 0; // TODO: Initialize to an appropriate value
            taxi_managementDataSet.car_madeRow actual;
            actual = target[index];
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for c_byColumn
        ///</summary>
        [TestMethod()]
        public void c_byColumnTest()
        {
            taxi_managementDataSet.car_madeDataTable target = new taxi_managementDataSet.car_madeDataTable(); // TODO: Initialize to an appropriate value
            DataColumn actual;
            actual = target.c_byColumn;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for c_dateColumn
        ///</summary>
        [TestMethod()]
        public void c_dateColumnTest()
        {
            taxi_managementDataSet.car_madeDataTable target = new taxi_managementDataSet.car_madeDataTable(); // TODO: Initialize to an appropriate value
            DataColumn actual;
            actual = target.c_dateColumn;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for cm_nameColumn
        ///</summary>
        [TestMethod()]
        public void cm_nameColumnTest()
        {
            taxi_managementDataSet.car_madeDataTable target = new taxi_managementDataSet.car_madeDataTable(); // TODO: Initialize to an appropriate value
            DataColumn actual;
            actual = target.cm_nameColumn;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for cmidColumn
        ///</summary>
        [TestMethod()]
        public void cmidColumnTest()
        {
            taxi_managementDataSet.car_madeDataTable target = new taxi_managementDataSet.car_madeDataTable(); // TODO: Initialize to an appropriate value
            DataColumn actual;
            actual = target.cmidColumn;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for rec_statusColumn
        ///</summary>
        [TestMethod()]
        public void rec_statusColumnTest()
        {
            taxi_managementDataSet.car_madeDataTable target = new taxi_managementDataSet.car_madeDataTable(); // TODO: Initialize to an appropriate value
            DataColumn actual;
            actual = target.rec_statusColumn;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for u_byColumn
        ///</summary>
        [TestMethod()]
        public void u_byColumnTest()
        {
            taxi_managementDataSet.car_madeDataTable target = new taxi_managementDataSet.car_madeDataTable(); // TODO: Initialize to an appropriate value
            DataColumn actual;
            actual = target.u_byColumn;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for u_dateColumn
        ///</summary>
        [TestMethod()]
        public void u_dateColumnTest()
        {
            taxi_managementDataSet.car_madeDataTable target = new taxi_managementDataSet.car_madeDataTable(); // TODO: Initialize to an appropriate value
            DataColumn actual;
            actual = target.u_dateColumn;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
