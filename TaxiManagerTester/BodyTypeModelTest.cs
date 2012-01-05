using TaxiManager.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace TaxiManagerTester
{
    
    
    /// <summary>
    ///This is a test class for BodyTypeModelTest and is intended
    ///to contain all BodyTypeModelTest Unit Tests
    ///</summary>
    [TestClass()]
    public class BodyTypeModelTest
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
        ///A test for BodyTypeModel Constructor
        ///</summary>
        [TestMethod()]
        public void BodyTypeModelConstructorTest()
        {
            BodyTypeModel target = new BodyTypeModel();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for DeleteBodyType
        ///</summary>
        [TestMethod()]
        public void DeleteBodyTypeTest()
        {
            BodyTypeModel target = new BodyTypeModel(); // TODO: Initialize to an appropriate value
            int btid = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.DeleteBodyType(btid);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetBodyTypes
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void GetBodyTypesTest()
        {
            BodyTypeModel_Accessor target = new BodyTypeModel_Accessor(); // TODO: Initialize to an appropriate value
            string Clauses = string.Empty; // TODO: Initialize to an appropriate value
            DataTable expected = null; // TODO: Initialize to an appropriate value
            DataTable actual;
            actual = target.GetBodyTypes(Clauses);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for InsertBodyType
        ///</summary>
        [TestMethod()]
        public void InsertBodyTypeTest()
        {
            BodyTypeModel target = new BodyTypeModel(); // TODO: Initialize to an appropriate value
            string bt_desc = string.Empty; // TODO: Initialize to an appropriate value
            int c_by = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.InsertBodyType(bt_desc, c_by);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UpdateBodyType
        ///</summary>
        [TestMethod()]
        public void UpdateBodyTypeTest()
        {
            BodyTypeModel target = new BodyTypeModel(); // TODO: Initialize to an appropriate value
            string bt_desc = string.Empty; // TODO: Initialize to an appropriate value
            int u_by = 0; // TODO: Initialize to an appropriate value
            int btid = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.UpdateBodyType(bt_desc, u_by, btid);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
