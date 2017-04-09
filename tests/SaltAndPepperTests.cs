using Microsoft.VisualStudio.TestTools.UnitTesting;
using hasher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hasher.Tests
{
    [TestClass()]
    public class SaltPepperTests
    {
        // private string marker = "<.>|<.>";

        [TestMethod()]
        [TestCategory("Salt and Pepper")]
        public void AddSaltTest()
        {
            string raw = "brown";
            string salt = "fox";

            SaltAndPepper sp = new SaltAndPepper();
            string salted = sp.AddSalt(raw, salt);

            Assert.AreEqual("brown<.>|<.>fox", salted);
        }

        [TestMethod()]
        [TestCategory("Salt and Pepper")]
        public void RemoveSaltTest()
        {
            string withsalt = "fox<.>|<.>brown";

            SaltAndPepper sp = new SaltAndPepper();
            string raw = sp.RemoveSalt(withsalt);

            Assert.AreEqual("fox", raw);
        }

        [TestMethod()]
        [TestCategory("Salt and Pepper")]
        public void AddPepperTest()
        {
            string raw = "brown";
            string pepper = "fox";

            SaltAndPepper sp = new SaltAndPepper();
            string peppered = sp.AddPepper(raw, pepper);

            Assert.AreEqual("fox<.>|<.>brown", peppered);
        }

        [TestMethod()]
        [TestCategory("Salt and Pepper")]
        public void RemovePepperTest()
        {
            string withPepper = "fox<.>|<.>brown";

            SaltAndPepper sp = new SaltAndPepper();
            string raw = sp.RemovePepper(withPepper);

            Assert.AreEqual("brown", raw);
        }
    }
}