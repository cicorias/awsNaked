using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RefreshRt53.Tests
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }


        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data.user","data#csv", 
            DataAccessMethod.Sequential), DeploymentItem("data.user"), TestMethod]
        public void TestMethod1()
        {
            var mut = new RefreshRt53.UpdateRt53();

            var hostName = (string)TestContext.DataRow["source"];

            UpdateRt53.CheckAndSet(//);


        }
    }
}
