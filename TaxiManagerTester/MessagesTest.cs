using TaxiManager.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;
using System.Resources;

namespace TaxiManagerTester
{
    
    
    /// <summary>
    ///This is a test class for MessagesTest and is intended
    ///to contain all MessagesTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MessagesTest
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
        ///A test for Messages Constructor
        ///</summary>
        [TestMethod()]
        public void MessagesConstructorTest()
        {
            Messages target = new Messages();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Culture
        ///</summary>
        [TestMethod()]
        public void CultureTest()
        {
            CultureInfo expected = null; // TODO: Initialize to an appropriate value
            CultureInfo actual;
            Messages.Culture = expected;
            actual = Messages.Culture;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MSG_Del
        ///</summary>
        [TestMethod()]
        public void MSG_DelTest()
        {
            string actual;
            actual = Messages.MSG_Del;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MSG_Err
        ///</summary>
        [TestMethod()]
        public void MSG_ErrTest()
        {
            string actual;
            actual = Messages.MSG_Err;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MSG_LoginFail
        ///</summary>
        [TestMethod()]
        public void MSG_LoginFailTest()
        {
            string actual;
            actual = Messages.MSG_LoginFail;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MSG_RequestDel
        ///</summary>
        [TestMethod()]
        public void MSG_RequestDelTest()
        {
            string actual;
            actual = Messages.MSG_RequestDel;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MSG_Sav
        ///</summary>
        [TestMethod()]
        public void MSG_SavTest()
        {
            string actual;
            actual = Messages.MSG_Sav;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ResourceManager
        ///</summary>
        [TestMethod()]
        public void ResourceManagerTest()
        {
            ResourceManager actual;
            actual = Messages.ResourceManager;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TTLDefault
        ///</summary>
        [TestMethod()]
        public void TTLDefaultTest()
        {
            string actual;
            actual = Messages.TTLDefault;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
