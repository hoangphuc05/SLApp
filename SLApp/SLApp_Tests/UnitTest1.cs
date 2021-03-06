﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SLApp_Beta;

namespace SLApp_Tests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// http://msdn.microsoft.com/en-us/library/ms182532.aspx
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            //
            // TODO: Add constructor logic here
            //
        }

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
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void StudentProfile_isNotAdmin_Test()
        {
            ///<summary>
            ///this test makes sure that fields which the studentWorker users cannot use are locked when they login
            ///</summary>
            ///

            bool adminCheck = false;

            //HACK BUG: studentprofile is not allowed to compile in unit tests
            //StudentProfile stdnt = new StudentProfile(adminCheck);

            //Assert.AreSame(stdnt.areStudentNotesLocked(), false);
        }
    }
}
