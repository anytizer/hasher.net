using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace hasher
{
    /**
     * Must be binary safe
     */
    public class file // : security
    {
        public void EncryptFile(string inputFile, string encryptedOutputFile, string password)
        {
            core c = new core();

            byte[] bytesToBeEncrypted = File.ReadAllBytes(inputFile);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            // Hash the password with SHA256
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesEncrypted = c.encrypt(bytesToBeEncrypted, passwordBytes);

            File.WriteAllBytes(encryptedOutputFile, bytesEncrypted);
        }

        public void DecryptFile(string inputEncryptedFile, string outputDecryptedFile, string password)
        {
            core c = new core();

            byte[] bytesToBeDecrypted = File.ReadAllBytes(inputEncryptedFile);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesDecrypted = c.decrypt(bytesToBeDecrypted, passwordBytes);

            File.WriteAllBytes(outputDecryptedFile, bytesDecrypted);
        }
    }
}