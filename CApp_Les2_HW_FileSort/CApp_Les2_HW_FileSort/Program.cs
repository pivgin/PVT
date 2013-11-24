using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CApp_Les2_HW_FileSort
{
    class Program
    {
        class AutoSort
        {
            private Sort()
            {

            }
        }

        class CustomSort
        {
            private Sort()
            {

            }

        }

        static void Main(string[] args)
        {
            File.OpenRead("data\\originalf.txt");
            string [] origstr = File.ReadAllLines("originalf.txt");
            int[] strnumbers = new int[origstr.Length];

            

            File.OpenWrite("data\\resultf.txt");
            StreamWriter streamwr = new StreamWriter("data\\resultf.txt");
            streamwr.WriteLine("Custom Sort");
            streamwr.WriteLine(strnumbers);
            streamwr.WriteLine();
            streamwr.Close();

            //StreamReader streamrd = new StreamReader();
            File.Delete("data\\resultf.txt");
        }
    }
}
