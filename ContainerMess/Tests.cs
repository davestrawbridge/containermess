using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContainerMess {
    [TestClass]
    public class Tests {
        [TestMethod]
        public void TestMethod1() {

            var client = new Client();

            // this does NOT work due to constraints

            var locationId = "location";

            var container = new MyContainer { Location = locationId };
            var content = new ContentA();

            container.Add(content);

            client.DoSomething<MyContainer, ContentA>(container, content);

            Assert.AreEqual(locationId, content.Location);
        }
    }
}
