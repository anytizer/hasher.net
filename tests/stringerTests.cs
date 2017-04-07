using hasher;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tests
{
    [TestClass()]
    public class stringerTests
    {
        [TestMethod()]
        [TestCategory("String")]
        public void EncryptTextTest()
        {
            stringer s = new stringer();
            string e = s.encrypt("hi", "pass1");

            Assert.AreEqual("LVaqrstKTIfZ4dPkaGNe+Q==", e);
        }

        [TestMethod()]
        [TestCategory("String")]
        public void DecryptTextTest()
        {
            stringer s = new stringer();
            string e = s.decrypt("LVaqrstKTIfZ4dPkaGNe+Q==", "pass1");

            Assert.AreEqual("hi", e);
        }

        [TestMethod()]
        [TestCategory("String")]
        public void SaltedTest()
        {
            string source = "item";
            string salt = "something";

            stringer s = new stringer();
            string e = s.decrypt(s.encrypt(source, salt), salt);

            Assert.AreEqual(source, e);
        }

        [TestMethod()]
        [TestCategory("String")]
        public void SaltedBytesTest()
        {
            string source = "item";
            random r = new random();
            byte[] bs = r.GetRandomBytes();
            string salt = System.Text.Encoding.UTF8.GetString(bs);

            stringer s = new stringer();
            string e = s.decrypt(s.encrypt(source, salt), salt);

            Assert.AreEqual(source, e);
        }
    }
}