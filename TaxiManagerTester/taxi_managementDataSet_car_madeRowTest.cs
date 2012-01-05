using TaxiManager;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace TaxiManagerTester
{
    
    
    /// <summary>
    ///This is a test class for taxi_managementDataSet_car_madeRowTest and is intended
    ///to contain all taxi_managementDataSet_car_madeRowTest Unit Tests
    ///</summary>
    [TestClass()]
    public class taxi_managementDataSet_car_madeRowTest
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
        ///A test for car_madeRow Constructor
        ///</summary>
        [TestMethod()]
        public void taxi_managementDataSet_car_madeRowConstructorTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            taxi_managementDataSet.car_madeRow target = new taxi_managementDataSet.car_madeRow(rb);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for c_by
        ///</summary>
        [TestMethod()]
        public void c_byTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            taxi_managementDataSet.car_madeRow target = new taxi_managementDataSet.car_madeRow(rb); // TODO: Initialize to an appropriate value
            uint expected = 0; // TODO: Initialize to an appropriate value
            uint actual;
            target.c_by = expected;
            actual = target.c_by;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for c_date
        ///</summary>
        [TestMethod()]
        public void c_dateTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            taxi_managementDataSet.car_madeRow target = new taxi_managementDataSet.car_madeRow(rb); // TODO: Initialize to an appropriate value
            DateTime expected = new DateTime(); // TODO: Initialize to an appropriate value
            DateTime actual;
            target.c_date = expected;
            actual = target.c_date;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for cm_name
        ///</summary>
        [TestMethod()]
        public void cm_nameTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            taxi_managementDataSet.car_madeRow target = new taxi_managementDataSet.car_madeRow(rb); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.cm_name = expected;
            actual = target.cm_name;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for cmid
        ///</summary>
        [TestMethod()]
        public void cmidTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            taxi_managementDataSet.car_madeRow target = new taxi_managementDataSet.car_madeRow(rb); // TODO: Initialize to an appropriate value
            uint expected = 0; // TODO: Initialize to an appropriate value
            uint actual;
            target.cmid = expected;
            actual = target.cmid;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for rec_status
        ///</summary>
        [TestMethod()]
        public void rec_statusTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            taxi_managementDataSet.car_madeRow target = new taxi_managementDataSet.car_madeRow(rb); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.rec_status = expected;
            actual = target.rec_status;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for u_by
        ///</summary>
        [TestMethod()]
        public void u_byTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            taxi_managementDataSet.car_madeRow target = new taxi_managementDataSet.car_madeRow(rb); // TODO: Initialize to an appropriate value
            uint expected = 0; // TODO: Initialize to an appropriate value
            uint actual;
            target.u_by = expected;
            actual = target.u_by;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for u_date
        ///</summary>
        [TestMethod()]
        public void u_dateTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            taxi_managementDataSet.car_madeRow target = new taxi_managementDataSet.car_madeRow(rb); // TODO: Initialize to an appropriate value
            DateTime expected = new DateTime(); // TODO: Initialize to an appropriate value
            DateTime actual;
            target.u_date = expected;
            actual = target.u_date;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
