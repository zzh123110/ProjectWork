using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyTest
{
    [TestClass]
    public class tstAddress
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of our class clsAddress
            clsAddress AnAddress = new clsAddress();
            //check to see that the class is not null
            Assert.IsNotNull(AnAddress);
        }
    }
}
