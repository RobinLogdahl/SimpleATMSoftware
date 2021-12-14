using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleATMSoftware
{
    public class database{ 
        private static database _instance=new database();
        public List<int> ExistingCreditcards = new List<int>();

    }
}
