using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace hasher
{
    public class file // : security
    {
        public void EncryptFile(string inputFile, string encryptedOutputFile, string password)
        {
            core c = new core();

            //string inputFile = "C:\\SampleFile.DLL";
            //string password = "abcd1234";

            byte[] bytesToBeEncrypted = File.ReadAllBytes(inputFile);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            // Hash the password with SHA256
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesEncrypted = c.encrypt(bytesToBeEncrypted, passwordBytes);

            //string encryptedOutputFile = "C:\\SampleFileEncrypted.DLL";
            File.WriteAllBytes(encryptedOutputFile, bytesEncrypted);
        }

        public void DecryptFile(string inputEncryptedFile, string outputDecryptedFile, string password)
        {
            core c = new core();

            //string inputEncryptedFile = "C:\\SampleFileEncrypted.DLL";
            //string password = "abcd1234";

            byte[] bytesToBeDecrypted = File.ReadAllBytes(inputEncryptedFile);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesDecrypted = c.decrypt(bytesToBeDecrypted, passwordBytes);

            //string outputDecryptedFile = "C:\\SampleFile.DLL";
            File.WriteAllBytes(outputDecryptedFile, bytesDecrypted);
        }
    }
}