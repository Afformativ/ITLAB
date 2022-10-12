using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using itLab1;
namespace UnitTest2
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethodOpenDB1()
        {
            string testFilePath = "D:\\IT\\test.tdb";
            bool expected = true;

            dbManager testManager = new dbManager();

            Assert.AreEqual(expected, testManager.OpenDB(testFilePath));
        }

        [TestMethod]
        public void TestMethodOpenDB2()
        {
            string testFilePath = "D:\\IT\\video.mp4";
            bool expected = false;

            dbManager testManager = new dbManager();

            Assert.AreEqual(expected, testManager.OpenDB(testFilePath));
        }
    }
}
