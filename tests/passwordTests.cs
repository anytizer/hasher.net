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
            string salt = originalSalt;
            string expected = this.originalRawPassword;

            password p = new password();
            string hash = p.hash(originalRawPassword, salt);
            string unhash = p.unhash(hash, salt);

            Assert.AreEqual(originalRawPassword, unhash);
        }

        [TestMethod()]
        [TestCategory("Password")]
        public void unhashTest()
        {
            string salt = originalSalt;
            string expected = this.originalRawPassword;

            password p = new password();
            string hash = p.hash(originalRawPassword, salt);
            string unhash = p.unhash(hash, salt);

            Assert.AreEqual(originalRawPassword, unhash);
        }

    }
}
