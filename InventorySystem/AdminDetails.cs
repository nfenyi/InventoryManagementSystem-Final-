using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class AdminDetails
    {
        private static string Aname;

        public void setAname(string aname)
        {
            Aname = aname;
        }
        public string getAname()
        {
            return Aname;
        }
    }
}
