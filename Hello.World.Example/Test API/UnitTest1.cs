using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_API
{
    [TestClass]
    public class APITests
    {
        [TestMethod]
        public void TestMethodHelloWorld()
        {   
            string target = "Hello World";
            string _output = ConsoleApp.API.GetHelloWorld().ToString();
            // assert  
            Assert.AreEqual(target, _output);
        }
    }
}
