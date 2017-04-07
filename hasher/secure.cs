using System;
using System.Runtime.InteropServices;
using System.Security;

namespace hasher
{
    public class secure
    {
        public void get()
        {
            SecureString secureString = new SecureString();
            secureString.AppendChar('h');
            secureString.AppendChar('e');
            secureString.AppendChar('l');
            secureString.AppendChar('l');
            secureString.AppendChar('o');
        }

        public string ss(SecureString secureString)
        {
            byte[] secureStringBytes = null;
            // Convert System.SecureString to Pointer
            IntPtr unmanagedBytes = Marshal.SecureStringToGlobalAllocAnsi(secureString);
            try
            {
                unsafe
                {
                    byte* byteArray = (byte*)unmanagedBytes.ToPointer();
                    // Find the end of the string
                    byte* pEnd = byteArray;
                    while (*pEnd++ != 0) { }
                    // Length is effectively the difference here (note we're 1 past end)
                    int length = (int)((pEnd - byteArray) - 1);
                    secureStringBytes = new byte[length];
                    for (int i = 0; i < length; ++i)
                    {
                        // Work with data in byte array as necessary, via pointers, here
                        secureStringBytes[i] = *(byteArray + i);
                    }
                }
            }
            finally
            {
                // This will completely remove the data from memory
                Marshal.ZeroFreeGlobalAllocAnsi(unmanagedBytes);
            }

            return secureStringBytes.ToString();
        }
    }
}
