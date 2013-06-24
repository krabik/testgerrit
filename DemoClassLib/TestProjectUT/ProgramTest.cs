
using System;
using Gallio.Framework;
using MbUnit.Framework;
using System.Collections.Generic;


namespace TestProjectUT
{

    /// <summary>
    ///This is a test class for ProgramTest and is intended
    ///to contain all ProgramTest Unit Tests
    ///</summary>
    [TestFixture]
    public class ProgramTest
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
        ///A test for Main
        ///</summary>
        [Test()]
        public int MainTest()
        {

            // Test if input arguments were supplied: 
            /* if (args.Length == 0)
            {
                System.Console.WriteLine("Please enter a numeric argument.");
                System.Console.WriteLine("Usage: Factorial <num>");
                return 1;
            } */

            //List<int> myList = new List<int> { 0, 1, 2, 3, 4, 5, 6 };
            //List<int> myList2 = new List<int> { 0, 1, 2, 3, 5, 4, 6 };

            //Assert.AreElementsEqual(myList, myList2);
            //Assert.AreElementsEqualIgnoringOrder(myList, myList2);

            return 0;
        }

        /// <summary>
        ///A test for Program Constructor
        ///</summary>
        [Test()]
        public void ProgramConstructorTest()
        {
            //Program target = new Program();
            //Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
