using Microsoft.VisualStudio.TestTools.UnitTesting;
using hasher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests
{
    [TestClass()]
    public class passwordTests
    {
        private string originalRawPassword = "some";
        private string originalSalt = "thing";

        [TestMethod()]
        [TestCategory("Password")]
        public void hashTest()
        {
            string originalRawPassword = "some";
            string salt = originalSalt;

            // refreshed all the times
            string expected = "/nxSysLuE6GTGbjPpoFSMY6bLpyUEuwH30dI8DQ68fStNckXuvCxF+trFO4r7zqpT6wzXcla55gMy7n6GY3QGA==";

            password p = new password();
            string hash = p.hash(originalRawPassword, salt);

            Assert.AreEqual(expected, hash);
        }

        [TestMethod()]
        [TestCategory("Password")]
        public void unhashTest()
        {
            string expected = originalRawPassword;
            string hashed = "/nxSysLuE6GTGbjPpoFSMY6bLpyUEuwH30dI8DQ68fStNckXuvCxF+trFO4r7zqpT6wzXcla55gMy7n6GY3QGA==";
            string salt = originalSalt;

            password p = new password();
            string unhashed = p.unhash(hashed, salt);

            Assert.AreEqual(expected, unhashed);
        }

    }
}
