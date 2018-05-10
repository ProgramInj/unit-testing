using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using МодТест;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int val = 100;
            string expected = "100";

            MyInt lol = new MyInt();
            string answer = lol.ToStr(val);


            Assert.AreEqual(expected, answer);
        }
    }
}
