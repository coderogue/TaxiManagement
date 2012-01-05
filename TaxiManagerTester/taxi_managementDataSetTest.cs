using TaxiManager;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.Serialization;
using System.Data;
using System.Xml.Schema;
using System.Xml;
using System.ComponentModel;

namespace TaxiManagerTester
{
    
    
    /// <summary>
    ///This is a test class for taxi_managementDataSetTest and is intended
    ///to contain all taxi_managementDataSetTest Unit Tests
    ///</summary>
    [TestClass()]
    public class taxi_managementDataSetTest
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
        ///A test for taxi_managementDataSet Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void taxi_managementDataSetConstructorTest()
        {
            SerializationInfo info = null; // TODO: Initialize to an appropriate value
            StreamingContext context = new StreamingContext(); // TODO: Initialize to an appropriate value
            taxi_managementDataSet_Accessor target = new taxi_managementDataSet_Accessor(info, context);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for taxi_managementDataSet Constructor
        ///</summary>
        [TestMethod()]
        public void taxi_managementDataSetConstructorTest1()
        {
            taxi_managementDataSet target = new taxi_managementDataSet();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Clone
        ///</summary>
        [TestMethod()]
        public void CloneTest()
        {
            taxi_managementDataSet target = new taxi_managementDataSet(); // TODO: Initialize to an appropriate value
            DataSet expected = null; // TODO: Initialize to an appropriate value
            DataSet actual;
            actual = target.Clone();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetSchemaSerializable
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void GetSchemaSerializableTest()
        {
            taxi_managementDataSet_Accessor target = new taxi_managementDataSet_Accessor(); // TODO: Initialize to an appropriate value
            XmlSchema expected = null; // TODO: Initialize to an appropriate value
            XmlSchema actual;
            actual = target.GetSchemaSerializable();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetTypedDataSetSchema
        ///</summary>
        [TestMethod()]
        public void GetTypedDataSetSchemaTest()
        {
            XmlSchemaSet xs = null; // TODO: Initialize to an appropriate value
            XmlSchemaComplexType expected = null; // TODO: Initialize to an appropriate value
            XmlSchemaComplexType actual;
            actual = taxi_managementDataSet.GetTypedDataSetSchema(xs);
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
            taxi_managementDataSet_Accessor target = new taxi_managementDataSet_Accessor(); // TODO: Initialize to an appropriate value
            target.InitClass();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitVars
        ///</summary>
        [TestMethod()]
        public void InitVarsTest()
        {
            taxi_managementDataSet target = new taxi_managementDataSet(); // TODO: Initialize to an appropriate value
            target.InitVars();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitVars
        ///</summary>
        [TestMethod()]
        public void InitVarsTest1()
        {
            taxi_managementDataSet target = new taxi_managementDataSet(); // TODO: Initialize to an appropriate value
            bool initTable = false; // TODO: Initialize to an appropriate value
            target.InitVars(initTable);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitializeDerivedDataSet
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void InitializeDerivedDataSetTest()
        {
            taxi_managementDataSet_Accessor target = new taxi_managementDataSet_Accessor(); // TODO: Initialize to an appropriate value
            target.InitializeDerivedDataSet();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ReadXmlSerializable
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void ReadXmlSerializableTest()
        {
            taxi_managementDataSet_Accessor target = new taxi_managementDataSet_Accessor(); // TODO: Initialize to an appropriate value
            XmlReader reader = null; // TODO: Initialize to an appropriate value
            target.ReadXmlSerializable(reader);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SchemaChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void SchemaChangedTest()
        {
            taxi_managementDataSet_Accessor target = new taxi_managementDataSet_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            CollectionChangeEventArgs e = null; // TODO: Initialize to an appropriate value
            target.SchemaChanged(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ShouldSerializeRelations
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void ShouldSerializeRelationsTest()
        {
            taxi_managementDataSet_Accessor target = new taxi_managementDataSet_Accessor(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.ShouldSerializeRelations();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ShouldSerializeTables
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void ShouldSerializeTablesTest()
        {
            taxi_managementDataSet_Accessor target = new taxi_managementDataSet_Accessor(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.ShouldSerializeTables();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ShouldSerializecar_made
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TaxiManager.exe")]
        public void ShouldSerializecar_madeTest()
        {
            taxi_managementDataSet_Accessor target = new taxi_managementDataSet_Accessor(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.ShouldSerializecar_made();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Relations
        ///</summary>
        [TestMethod()]
        public void RelationsTest()
        {
            taxi_managementDataSet target = new taxi_managementDataSet(); // TODO: Initialize to an appropriate value
            DataRelationCollection actual;
            actual = target.Relations;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SchemaSerializationMode
        ///</summary>
        [TestMethod()]
        public void SchemaSerializationModeTest()
        {
            taxi_managementDataSet target = new taxi_managementDataSet(); // TODO: Initialize to an appropriate value
            SchemaSerializationMode expected = new SchemaSerializationMode(); // TODO: Initialize to an appropriate value
            SchemaSerializationMode actual;
            target.SchemaSerializationMode = expected;
            actual = target.SchemaSerializationMode;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Tables
        ///</summary>
        [TestMethod()]
        public void TablesTest()
        {
            taxi_managementDataSet target = new taxi_managementDataSet(); // TODO: Initialize to an appropriate value
            DataTableCollection actual;
            actual = target.Tables;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for car_made
        ///</summary>
        [TestMethod()]
        public void car_madeTest()
        {
            taxi_managementDataSet target = new taxi_managementDataSet(); // TODO: Initialize to an appropriate value
            taxi_managementDataSet.car_madeDataTable actual;
            actual = target.car_made;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
