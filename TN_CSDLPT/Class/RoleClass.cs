using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TN_CSDLPT.Class
{
    internal class RoleClass
    {
        public string MAQUYEN
        {
            get;
            set;
        }

        public string TENQUYEN
        {
            get;
            set;
        }

        public RoleClass(string id, string n)
        {
            MAQUYEN  = n;
            TENQUYEN = id;
        }
    }
}
