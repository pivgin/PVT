using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp_queue
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicQueue queue = new DynamicQueue();

            queue.Push(1);
            queue.Push(2);
            queue.Push(3);

            Console.WriteLine(queue.Pop());
            Console.WriteLine(queue.Pop());
            Console.WriteLine(queue.Pop());
        }
    }
}
