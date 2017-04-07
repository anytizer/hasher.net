using hasher;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace tests
{
    [TestClass()]
    public class randomTests
    {
        [TestMethod()]
        [TestCategory("Core")]
        public void GetRandomBytesTest()
        {
            random r = new random();
            byte[] bs = r.GetRandomBytes();

            Assert.AreEqual(8, bs.Count());
        }
    }
}