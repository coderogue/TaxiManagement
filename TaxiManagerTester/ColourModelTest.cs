using TaxiManager.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace TaxiManagerTester
{
    
    
    /// <summary>
    ///This is a test class for ColourModelTest and is intended
    ///to contain all ColourModelTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ColourModelTest
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
        ///A test for ColourModel Constructor
        ///</summary>
        [TestMethod()]
        public void ColourModelConstructorTest()
        {
            ColourModel target = new ColourModel();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for DeleteColour
        ///</summary>
        [TestMethod()]
        public void DeleteColourTest()
        {
            ColourModel target = new ColourModel(); // TODO: Initialize to an appropriate value
            int colourid = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.DeleteColour(colourid);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetColours
        ///</summary>
        [TestMethod()]
        public void GetColoursTest()
        {
            ColourModel target = new ColourModel(); // TODO: Initialize to an appropriate value
            string Clauses = string.Empty; // TODO: Initialize to an appropriate value
            DataTable expected = null; // TODO: Initialize to an appropriate value
            DataTable actual;
            actual = target.GetColours(Clauses);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for InsertColour
        ///</summary>
        [TestMethod()]
        public void InsertColourTest()
        {
            ColourModel target = new ColourModel(); // TODO: Initialize to an appropriate value
            string colour_desc = string.Empty; // TODO: Initialize to an appropriate value
            int c_by = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.InsertColour(colour_desc, c_by);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UpdateColour
        ///</summary>
        [TestMethod()]
        public void UpdateColourTest()
        {
            ColourModel target = new ColourModel(); // TODO: Initialize to an appropriate value
            string colour_desc = string.Empty; // TODO: Initialize to an appropriate value
            int u_by = 0; // TODO: Initialize to an appropriate value
            int colourid = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.UpdateColour(colour_desc, u_by, colourid);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
