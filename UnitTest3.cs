using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using itLab1;

namespace UnitTest3
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethodSearch1()
        {
            dbManager testManager = new dbManager();
            testManager.OpenDB("D:\\IT\\test.tdb");
            string search ="5";
            Table resTable = testManager.SearchInTable(0, search);
            bool expected = true;

            bool res = false; ;
            foreach (Row r in resTable.tRowsList)
            {
                string buf = "";
                foreach (string s in r.rValuesList)
                {
                    buf += s;
                }

                if (buf.Contains(search))
                {
                    res = true;
                    break;
                }
            }

            Assert.AreEqual(expected, res);
        }
    }
}
