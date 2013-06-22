﻿using DemoClassLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProjectUT
{
    
    
    /// <summary>
    ///This is a test class for MyMathClassTest and is intended
    ///to contain all MyMathClassTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MyMathClassTest
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
        ///A test for MyMathClass Constructor
        ///</summary>
        [TestMethod()]
        public void MyMathClassConstructorTest()
        {
            MyMathClass target = new MyMathClass();
            //Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for multi func
        ///</summary>
        [TestMethod()]
        public void multiTest()
        {
            MyMathClass target = new MyMathClass(); // TODO: Initialize to an appropriate value
            int i = 3; // TODO: Initialize to an appropriate value
            int j = 5; // TODO: Initialize to an appropriate value
            double expected = 15; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.multi(i, j);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");

        }

        /// <summary>
        ///A test for sub
        ///</summary>
        [TestMethod()]
        public void subTest()
        {
            MyMathClass target = new MyMathClass(); // TODO: Initialize to an appropriate value
            int i = 0; // TODO: Initialize to an appropriate value
            int j = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.sub(i, j);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for sum
        ///</summary>
        [TestMethod()]
        public void sumTest()
        {
            MyMathClass target = new MyMathClass(); // TODO: Initialize to an appropriate value
            int i = 2; // TODO: Initialize to an appropriate value
            int j = 2; // TODO: Initialize to an appropriate value
            int expected = 4; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.sum(i, j);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
