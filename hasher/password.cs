using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hasher
{
    public class password
    {
        public string hash(string raw, string salt)
        {
            stringer s = new stringer();
            string pepper = "kn0wn5a1t";

            string hashed;
            hashed = s.encrypt(raw + salt, pepper);
            hashed = s.encrypt(salt + hashed, salt);

            return hashed;
        }

        public string unhash(string hashed, string salt)
        {
            stringer s = new stringer();
            string pepper = "kn0wn5a1t";

            string unhashed;
            unhashed = s.decrypt(hashed, pepper);
            //unhashed = s.DecryptString(unhashed, salt);

            return unhashed;
        }
    }
}
