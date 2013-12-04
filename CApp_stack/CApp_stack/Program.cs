using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicStack stack = new DynamicStack();

            stack.Push(1);
            stack.Push("Max");
            stack.Push(100.7);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

        }
    }
}
