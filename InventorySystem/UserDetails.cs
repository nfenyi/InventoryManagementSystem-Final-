using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    
    class UserDetails
    {
        private static string uName;

        public void setUName(string name)
        {
            uName = name;
        }
        public string getUName()
        {
            return uName;
        }
    }
}
