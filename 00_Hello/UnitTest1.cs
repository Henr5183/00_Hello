using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _00_Hello
{
    internal class Intro
    {
        public string Hello()
        {
            return "Hello";
        }
    }
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestHello()
        {
            Assert.AreEqual("hello", Functions.Hello());
        }
        [TestMethod]
        public void TestHelloFred()
        {
            Assert.AreEqual("hello, Fred", Functions.Hello("Fred"));
        }
    }
}
