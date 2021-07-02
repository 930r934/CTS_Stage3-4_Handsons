using System;
using NUnit.Framework;
using AccountsManagerLib;
namespace UnitTestForAccountsManager
{
    [TestFixture]
    public class UnitTest1
    {
        private AccountsManager A;
        
        public UnitTest1()
        {
            A = new AccountsManager();
        }

        [Test]
        public void TestCorrect_Username_Password()
        {
            var gen_output = A.ValidateUser("user_11", "secret@user11");
            Assert.AreEqual("Welcome user_11!!!", gen_output);
        }

        [Test]
        public void TestWrong_Username_Password()
        {
            var gen_output = A.ValidateUser("user111", "1234567890");
            Assert.AreEqual("Invalid user id/password", gen_output);
        }

        [Test]
        public void TestNull_Username_Password()
        {
            Assert.Throws<FormatException>(() => A.ValidateUser("",""));
        }
    }
}
