using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp_Les2_ClassStruct
{
    public class FirstClass
    {
        public int Number;
    }

    public struct FirstStruct
    {
        public int Number;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            FirstClass cl1 = new FirstClass{Number = 1};
            FirstClass cl2 = cl1;
            cl1.Number = 0;

            FirstStruct st1 = new FirstStruct{Number = 1};
            FirstStruct st2 = st1;
            st1.Number = 0;

            Console.WriteLine("Class");
            Console.WriteLine(cl1.Number);
            Console.WriteLine(cl2.Number);
            Console.WriteLine("--------------");
            Console.WriteLine("Struct");
            Console.WriteLine(st1.Number);
            Console.WriteLine(st2.Number);
        }
    }
}