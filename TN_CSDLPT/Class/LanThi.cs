using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TN_CSDLPT.Class
{
    internal class LanThi
    {
        public string SOLAN
        {
            get;
            set;
        }

        public string TENLAN
        {
            get;
            set;
        }

        public LanThi(string id, string n)
        {
            SOLAN = n;
            TENLAN = id;
        }
    }
}
