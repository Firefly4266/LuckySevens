using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckySevens
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable to hold your count
            int total = 0;

            //Random number generator for the dice
            Random randNum = new Random();

            //2 dice (die)
            int dice1, dice2;
            
            //100 rolls...
            for (int i = 1; i <= 100; i++)
            {
                //assign a random number to a die.
                dice1 = randNum.Next(1, 7);
                dice2 = randNum.Next(1, 7);

                //check to see if they make a seven.
                if (dice1 + dice2 == 7)
                {
                    total++;
                }
            }
            Console.WriteLine("Out of 100 rolls, you rolled {0} sevens.",total);
        }
    }
}
