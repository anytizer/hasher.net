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
    public class fileTests
    {
        [TestMethod()]
        [TestCategory("File")]
        public void EncryptFileTest()
        {
            file f = new file();
            f.EncryptFile("d:\\file.zip", "d:\\file-encrypted.zip", "password");
        }

        [TestMethod()]
        [TestCategory("File")]
        public void DecryptFileTest()
        {
            file f = new file();
            f.DecryptFile("d:\\file-encrypted.zip", "d:\\file-decrypted.zip", "password");
        }
    }
}