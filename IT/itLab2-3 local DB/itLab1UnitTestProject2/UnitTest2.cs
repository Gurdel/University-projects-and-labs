using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using itLab1;

namespace itLab1UnitTestProject2
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethodOpenDB1()
        {
            string testFilePath = "C:\\Users\\maksy\\Desktop\\КНУ 2020\\Кузенко. Інформаційні технології\\test.tdb";
            bool expected = true;

            dbManager testManager = new dbManager();

            Assert.AreEqual(expected, testManager.OpenDB(testFilePath));
        }

        [TestMethod]
        public void TestMethodOpenDB2()
        {
            string testFilePath = "C:\\Users\\maksy\\Desktop\\КНУ 2020\\Кузенко.Інформаційні технології\\Шевченко МІ-4 Пропуск 23.09.docx";
            bool expected = false;

            dbManager testManager = new dbManager();

            Assert.AreEqual(expected, testManager.OpenDB(testFilePath));
        }
    }
}
