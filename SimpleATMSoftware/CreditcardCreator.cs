using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleATMSoftware
{
    class CreditcardCreator
    {
        database data;
        public CreditcardCreator()
        {
            data= database.GetDatabase();
        }
        public void CreateCard()
        {
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                int randomCreditcardNumber = random.Next(1, 10);
                if (data.ExistingCreditcards.Contains(randomCreditcardNumber))
                {
                    Console.WriteLine("Creditcardnumber already in use, creating a new number...");
                    continue;
                }

                else
                {
                    data.ExistingCreditcards.Add(randomCreditcardNumber);
                    Console.WriteLine($"Creditcard with number {randomCreditcardNumber} created.");
                    break;
                }
            }
            Console.ReadLine();
        }



        //int randomNumber = newCreditcardNumber.Next(100000000, 999999999);


    }

}

