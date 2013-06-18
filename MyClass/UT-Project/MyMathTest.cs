using MyClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UT_Project
{
    
    
    /// <summary>
    ///This is a test class for MyMathTest and is intended
    ///to contain all MyMathTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MyMathTest
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
        ///A test for MyMath Constructor
        ///</summary>
        [TestMethod()]
        public void MyMathConstructorTest()
        {
            MyMath target = new MyMath();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for MathStatus
        ///</summary>
        [TestMethod()]
        public void MathStatusTest()
        {
            MyMath target = new MyMath(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.MathStatus();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Multi
        ///</summary>
        [TestMethod()]
        public void MultiTest()
        {
            MyMath target = new MyMath(); // TODO: Initialize to an appropriate value
            int x = 2; // TODO: Initialize to an appropriate value
            int y = 3; // TODO: Initialize to an appropriate value
            double expected = 6; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.Multi(x, y);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive(string.Format("Verify the correctness of MultiTest(){0} method.", arg0: "ARG0"));
        }

    
        [TestMethod()]
        public void SubstTest()
        {
            MyMath target =new MyMath();
            int x = 2;
            int y = 2;
            int exp = 0;
            int act;
            act = target.Subst(x, y);
            Assert.AreEqual(exp, act);
            Assert.Inconclusive("Verify the correctness of SubstTest() method.");

        }

        /// <summary>
        ///A test for Sum
        ///</summary>
        [TestMethod()]
        public void SumTest()
        {
            MyMath target = new MyMath(); // TODO: Initialize to an appropriate value
            int x = 3; // TODO: Initialize to an appropriate value
            int y = 4; // TODO: Initialize to an appropriate value
            int expected = 7; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Sum(x, y);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of SumTest() method.");
        }
    }
}
