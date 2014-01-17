using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass();
            ChildClass chc = new ChildClass();
            BaseClass bcchc = new ChildClass();

            bc.Method1();
            bc.Method2();
            chc.Method1();
            chc.Method2();
            bcchc.Method1();
            bcchc.Method2();

        }
    }
}
