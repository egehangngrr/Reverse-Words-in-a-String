using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reverse_Words_in_a_String;

namespace ReverseWordsInAString_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Form1 frmForm1 = new Form1();
            string output = frmForm1.reverseWords("Test1 test2 test3");
            Assert.AreEqual("test3 test2 Test1", output);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Form1 frmForm1 = new Form1();
            string output = frmForm1.reverseWords("aaa bbb ccc");
            Assert.AreEqual("ccc bbb aaa", output);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Form1 frmForm1 = new Form1();
            string output = frmForm1.reverseWords("xxx yyy zzz");
            Assert.AreEqual("zzz yyy xxx", output);
        }
    }
}
