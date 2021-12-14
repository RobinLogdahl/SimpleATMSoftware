using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleATMSoftware
{
    class Creditcards
    {
      
        public int cardnumber { get; set; }
        private int pin;
        public Creditcards(int number)
        {
            cardnumber = number;
        }
       public bool checkpin(int code)
        {
            return (code == pin ? true : false);
        }
    }
}
