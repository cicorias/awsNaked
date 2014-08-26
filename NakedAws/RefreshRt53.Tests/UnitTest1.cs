using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RefreshRt53.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mut = new RefreshRt53.UpdateRt53();

            UpdateRt53.CheckAndSet("cloudexpert.io", "192.0.0.1", "cloudexpertio.wordpress.com", "Z39DT71SBE1W1D");


        }
    }
}
