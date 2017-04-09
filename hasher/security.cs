using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hasher
{
    public interface security
    {
        string encrypt(string original, string salt);

        string decrypt(string original, string salt);
    }
}
