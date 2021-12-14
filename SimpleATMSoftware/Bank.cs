using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleATMSoftware
{
    internal class Bank
    {
        private CreditcardCreator creator;
        private database data;
        public Bank()
        {
            creator = new CreditcardCreator();
            data = database.GetDatabase();
        }
        public void MakeYourChoice()
        {

        }

    }
}
