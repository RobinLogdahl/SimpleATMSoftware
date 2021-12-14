using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleATMSoftware
{
    class CreditcardCreator : Creditcards
    {
        public CreditcardCreator()
        {
            var database = database.
            while (true)
            {
                Random random = new Random();
                

                //int randomNumber = newCreditcardNumber.Next(100000000, 999999999);
                int randomCreditcardNumber = random.Next(1, 3);
                if (ExistingCreditcards.Contains(randomCreditcardNumber))
                {
                    Console.WriteLine("Creditcardnumber already in use, creating a new number...");
                    continue;
                }

                else
                {
                    ExistingCreditcards.Add(randomCreditcardNumber);
                    Console.WriteLine($"Creditcard with number {randomCreditcardNumber} created.");
                    break;
                }
            }

        }

    }
}
