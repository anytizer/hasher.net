using System.Security.Cryptography;

namespace hasher
{
    public class random
    {
        public byte[] GetRandomBytes()
        {
            int saltLength = GetSaltLength();
            byte[] ba = new byte[saltLength];

            RNGCryptoServiceProvider.Create().GetBytes(ba);

            return ba;
        }

        public int GetSaltLength()
        {
            return 8;
        }
    }
}
