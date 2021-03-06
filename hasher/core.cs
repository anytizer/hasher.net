﻿using System.IO;
using System.Security.Cryptography;

namespace hasher
{
    public class core //: security
    {
        public byte[] encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            MemoryStream ms = new MemoryStream();
            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;

            var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);

            AES.Mode = CipherMode.CBC;
            AES.Padding = PaddingMode.ISO10126;

            CryptoStream cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);

            // @todo Length of the data to encrypt is invalid.
            cs.Close();
            encryptedBytes = ms.ToArray();

            return encryptedBytes;
        }

        public byte[] decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            MemoryStream ms = new MemoryStream();
            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;

            var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);

            AES.Mode = CipherMode.CBC;
            AES.Padding = PaddingMode.ISO10126;

            CryptoStream cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);

            // @todo Padding is invalid and cannot be removed
            cs.Close();

            decryptedBytes = ms.ToArray();
            return decryptedBytes;
        }
    }
}