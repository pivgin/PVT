using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp_Les4_CW_FibFact
{
    class Program
    {

        static void Main(string[] args)
        {

            //Hello(5);

            Func<uint, uint> calc = null;

            uint number = uint.Parse(Console.ReadLine());

            string operation = Console.ReadLine();

            if (operation == "fib")
            {

                calc = Fib;

            }

            if (operation == "fact")
            {

                calc = Fact;

            }

            Console.WriteLine(calc(number));
            Console.ReadKey();

        }

        static uint Fact(uint number)
        {

            if (number == 0)
            {

                return 1;

            }

            return Fact(number) * Fact(number - 1);

        }

        static uint Fib(uint number)
        {

            switch (number)
            {

                case 0:

                case 1:

                    return number;

                default:

                    return Fib(number - 1) + Fib(number - 2);

            }
        }
    }
}