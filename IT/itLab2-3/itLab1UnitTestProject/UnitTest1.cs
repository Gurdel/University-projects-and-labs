using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using itLab1;

namespace itLab1UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodInvl1()
        {
            string testValue = "-98 265";
            bool expected = true;

            bdTypeIntegerInvl testClass = new bdTypeIntegerInvl();

            Assert.AreEqual(expected, testClass.Validation(testValue));
        }

        [TestMethod]
        public void TestMethodInvl2()
        {
            string testValue = "64 9";
            bool expected = false;

            bdTypeIntegerInvl testClass = new bdTypeIntegerInvl();

            Assert.AreEqual(expected, testClass.Validation(testValue));
        }

        [TestMethod]
        public void TestMethodInvl3()
        {
            string testValue = "8.5 99";
            bool expected = false;

            bdTypeIntegerInvl testClass = new bdTypeIntegerInvl();

            Assert.AreEqual(expected, testClass.Validation(testValue));
        }
    }
}
