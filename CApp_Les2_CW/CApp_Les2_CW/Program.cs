using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp_Les2_CW
{
    class Program
    {
        public static string s1,s2;
        public static string Operation;

        public static float num1, num2, result;

        static void Main(string[] args)
        {
            Console.WriteLine("Input 1st number");
            s1 = Console.ReadLine();
            num1 = int.Parse(s1);

            Console.WriteLine("Input 2nd number");
            s2 = Console.ReadLine();
            num2 = int.Parse(s2);

            Console.WriteLine("Input operation");
            Operation = Console.ReadLine();

            switch (Operation)
            {
                
                case "+":
                    result = num1 + num2;
                    break;
                
                case "-":
                    result = num1 - num2;
                    break;
                
                case "*":
                    result = num1 * num2;
                    break;
                
                case "/":
                    result = num1 / num2;
                    break;

                default:
                    Console.WriteLine("No such operation availible");
                    break;
            }

            Console.WriteLine("Result: "+ result);
        }
    }
}