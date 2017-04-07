using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography;
using System.Text;

namespace tests
{
    [TestClass()]
    public class coreTests
    {
        [TestMethod()]
        [TestCategory("Core")]
        public void AESEncryptTest()
        {
            //core c = new core();
            //string source = "source";
            //string target = c.AES_Encrypt(source);
        }

        [TestMethod()]
        [TestCategory("Core")]
        public void AESDecryptTest()
        {
        }

        [TestMethod()]
        [TestCategory("Core")]
        public void SHA1Test()
        {

        }

        [TestMethod()]
        [TestCategory("Core")]
        public void SHA2Test()
        {
            string password = "test";
            byte[] passwordBytes = SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes(password));
            //passwordBytes.ToString();
        }
    }
}