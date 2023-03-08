using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
     class Testing
    {
         static void Main(string[] args)
        {
            Deck deck1 = new Deck();
            deck1.shuffle();
            Console.WriteLine("Enter Amount To Deal");
                int amount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < amount; i++)
            {
                Console.Write("{0,-19}", deck1.deal_card());
                if((i + 1) % 4 == 0)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
