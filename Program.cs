using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekursia
{
    class Program
    {
        static void Main(string[] args)
        {
                PrintNumber1to10(int.Parse(Console.ReadLine());
        }

        private static void PrintNumber1to10(int number)
        {

            switch (number)
            {
                case 1:
                    Console.WriteLine("one");
                    number = int.Parse(Console.ReadLine());
                    PrintNumber1to10(number);
                    break;
                case 2:
                    Console.WriteLine("two");
                    number = int.Parse(Console.ReadLine());
                    PrintNumber1to10(number);
                    break;
                case 3:
                    Console.WriteLine("tree");
                    number = int.Parse(Console.ReadLine());
                    PrintNumber1to10(number);
                    break;
                case 4:
                    Console.WriteLine("four");
                    number = int.Parse(Console.ReadLine());
                    PrintNumber1to10(number);
                    break;
                case 5:
                    Console.WriteLine("five");
                    number = int.Parse(Console.ReadLine());
                    PrintNumber1to10(number);
                    break;
                case 6:
                    Console.WriteLine("six");
                    number = int.Parse(Console.ReadLine());
                    PrintNumber1to10(number);
                    break;
                case 7:
                    Console.WriteLine("seven");
                    number = int.Parse(Console.ReadLine());
                    PrintNumber1to10(number);
                    break;
                case 8:
                    Console.WriteLine("eight");
                    number = int.Parse(Console.ReadLine());
                    PrintNumber1to10(number);
                    break;
                case 9:
                    Console.WriteLine("nine");
                    number = int.Parse(Console.ReadLine());
                    PrintNumber1to10(number);
                    break;
                case 10:
                    Console.WriteLine("ten");
                    number = int.Parse(Console.ReadLine());
                    PrintNumber1to10(number);
                    break;
                default:
                    Console.WriteLine(number);
                    break;

            }
        }

    }
}
