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


        [TestMethod]
        public void TestIf_Login_Success()
        {
            //UserModel usermodel = new UserModel;
            // String userName = "", password = "";

            //Assert.IsTrue(usermodel.login(userName,password) is User);

            //I thought iterating and picking up user from usermodel would be good, but will it have security issue?
            //But if so, should we iterate through whole list? Any scalability concerns that way? 
        }

        [TestMethod]
        public void TestLogin_If_UserName_DontMatch()
        {
            //UserModel usermodel = new UserModel;
            // String userName = "", password = "";
            //Assert.IsTrue(usermodel.login(userName,password) is User);
        }
        [TestMethod]
        public void TestLogin_If_Password_DontMatch()
        {
            //UserModel usermodel = new UserModel;
            // String userName = "", password = "";
            //Assert.IsTrue(usermodel.login(userName,password) is User);
        }

    }
}
