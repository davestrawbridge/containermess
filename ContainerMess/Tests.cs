using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContainerMess {
    [TestClass]
    public class Tests {
        [TestMethod]
        public void TestMethod1() {

            var client = new Client();

            // this does NOT work due to constraints

            var container = new MyContainer();
            var content = new ContentA();

            client.DoSomething<MyContainer, ContentA>(container, content);
        }
    }
}
