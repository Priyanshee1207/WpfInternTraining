using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace POC01_ConsoleCalculator
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("=== Simple Calculator ===");
            Console.WriteLine(" 1. Addition");
            Console.WriteLine(" 2. Subtraction");
            Console.WriteLine(" 3. Multiplication");
            Console.WriteLine(" 4. Division");
            Console.WriteLine(" 5. Exit");
            Console.WriteLine();

            int number;
            {
               // Console.WriteLine("Choose operation (1-5):");
               // Console.WriteLine();

                Console.WriteLine("Enter First Number:");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Second Number:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Choose operation (1-5):");

                number = Convert.ToInt32(Console.ReadLine());

                /* switch(number)
                 {
                     case 1:
                         number = num1 + num2;
                         Console.WriteLine($"Result: {num1} + {num2} = {number}");
                         break;

                     case 2:
                         number = num1 - num2;
                         Console.WriteLine($"Result: {num1} - {num2} = {number}");

                 }*/

                if (number == 1)
                {
                    number = num1 + num2;
                    Console.WriteLine($"Result: {num1} + {num2} = {number}");
                   
                }
                else if (number == 2)
                {
                    number = num1 - num2;
                    Console.WriteLine($"Result: {num1} - {num2} = {number}");
                }
                else if(number == 3)
                {
                    number = num1 * num2;
                    Console.WriteLine($"Result: {num1} * {num2} = {number}");
                }
               else if (number == 4)
                {
                    number = num1 / num2;
                    Console.WriteLine($"Result: {num1} / {num2} = {number}");
                }
                else
                {
                    Console.WriteLine("Select from 1 to 4 places.");
                }
            }

        }

    }
}
