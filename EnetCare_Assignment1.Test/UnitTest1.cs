using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EnetCare;

namespace EnetCare.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEmployeeExist()
        {
        }

        public void TestPackageSent()
        { 
        }

        public void TestPackageIsRegistered()
        {
            Package pk = new Package();
            Assert.IsFalse(pk.Association);


            pk.Association = true;
            Assert.IsTrue(pk.Association);
        //    Assert.AreEqual(pk.);
        
        }

        public void TestEditProfile()
        {
 
        }



    }
}
