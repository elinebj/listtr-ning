using System;
using System.Linq;

namespace listträning
{
    class Program
    {
        static void Main(string[] args)
        {

            //ctr+k, ctrl+d = snygga till
            //ett sätt

            int[] arrayOfNumbers = new int[5];
            arrayOfNumbers[0] = 13;
            arrayOfNumbers[1] = 22;
            arrayOfNumbers[2] = 3;
            arrayOfNumbers[3] = 93;
            arrayOfNumbers[4] = 1;

           /* Console.WriteLine("Check if you pick a lucky number");
            string nr = Console.ReadLine(); 
            int myNr = Convert.ToInt32(nr);

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (myNr==arrayOfNumbers[i])
                {
                    Console.WriteLine("winner winner chicken dinner");

                }
                else
                {
                    Console.WriteLine("no win for you");
                }
           */

                int[] firstOne = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                int[] secondOne = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
                Console.WriteLine(string.Join(',', firstOne.Reverse()));
                

                

            }

        }
    }
}
