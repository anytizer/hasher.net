using hasher;
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
            core c = new core();

            string source = "a quick brown fox jumps over the lazy dog.";
            string password = "something";

            byte[] passwordBytes = UTF8Encoding.UTF8.GetBytes(password);
            byte[] sourceBytes = UTF8Encoding.UTF8.GetBytes(source);

            byte[] encryptedBytes = c.encrypt(sourceBytes, passwordBytes);
            //string encryptedString = UTF8Encoding.UTF8.GetString(encryptedBytes);

            byte[] decryptedBytes = c.decrypt(encryptedBytes, passwordBytes);
            string decryptedString = UTF8Encoding.UTF8.GetString(decryptedBytes);

            Assert.AreEqual(source, decryptedString);
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
            byte[] passwordBytes = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(password));
            //passwordBytes.ToString();
        }
    }
}