using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hasher
{
    /**
     * Basic string manipulation only
     * Corresponds to hashing algorithms in the database
     */
    public class SaltAndPepper
    {
        /**
         * The markers MUST be unique
         */
        private string SaltMarker = "<.>|<.>";
        private string PepperMarker = "<.>|<.>";

        public string AddSalt(string raw, string salt)
        {
            return string.Format("{0}{1}{2}", raw, SaltMarker, salt);
        }

        public string RemoveSalt(string salted)
        {
            int index = salted.IndexOf(this.SaltMarker);
            string raw = salted.Remove(index);

            return raw;

            // fox<.>|<.>brown ==> fox
            // find position
            // remove from the position to end
        }

        public string AddPepper(string raw, string pepper)
        {
            return string.Format("{0}{1}{2}", pepper, PepperMarker, raw);
        }

        public string RemovePepper(string withPepper)
        {
            int index = withPepper.IndexOf(this.PepperMarker);
            string raw = withPepper.Remove(0, index+this.PepperMarker.Length);

            return raw;

            // fox<.>|<.>brown ==> brown
            // find position
            // remove from begining to the position
        }
    }
}
