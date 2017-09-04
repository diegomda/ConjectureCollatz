using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConjectureCollatz
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare a string for a pick the number by user

            string a;
            int result;


            Console.WriteLine("Enter a number positive..");
            a = Console.ReadLine();
            //convert string to int whit the parse method
            result = int.Parse(a);

            //while the number is even the cycle will continue and the result module will be made
            while (result % 2 == 0)
            {
                result = result / 2;
                Console.WriteLine("The new number is: " + result);
                Console.ReadKey();
            }
            while (result != 0)
            {
                result = (result * 3) + 1;
                Console.WriteLine("The new number is: " + result);
                Console.ReadKey();
                while (result % 2 == 0)
                {
                    result = result / 2;
                    Console.WriteLine("The new number is: " + result);
                    Console.ReadKey();
                }
            }



        }

    }
}
