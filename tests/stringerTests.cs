using hasher;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tests
{
    [TestClass()]
    public class stringerTests
    {
        private string _data = "A quick brown fox jumps over the lazy dog.";
        private string _salt = "pa$svv0rd";
        private string _pepper = "other";

        [TestMethod()]
        [TestCategory("String")]
        public void EncryptTextTest()
        {
            string data = this._data;
            string salt = this._salt;

            stringer s = new stringer();
            string e = s.encrypt(data, salt);
            string decrypted = s.decrypt(e, salt);

            /**
             * It is awlays different, so, cannot check for this.
             */
            //Assert.AreEqual("pGdzQhW2o7btTq+MV+zMUA==", e);
            Assert.AreEqual(data, decrypted);
        }

        [TestMethod()]
        [TestCategory("String")]
        public void DecryptTextTest()
        {
            string salt = this._pepper;

            stringer s = new stringer();
            string e = s.encrypt(this._data, salt);
            string d = s.decrypt(e, salt);

            Assert.AreEqual(this._data, d);
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