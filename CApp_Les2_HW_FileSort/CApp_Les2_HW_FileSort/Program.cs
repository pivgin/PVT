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
            public static int[] Sort(int [] intnumberscopy)
            {
                Array.Sort(intnumberscopy);
                return intnumberscopy;
            }

        }

        class CustomSort
        {

            public static int[] Sort(int[] intnumbers)
            {
                //int [] strnumberscopy;
                int[] intnumberscopy = intnumbers;
                int temp;

                for (int i = 0; i < intnumberscopy.Length - 1; i++) 
                {
                    for (int j = 0; j < intnumberscopy.Length - i - 1; j++)
                    {
                        if (intnumberscopy[j] > intnumberscopy[j + 1]) 
                        {
                            temp = intnumberscopy[j];
                            intnumberscopy[j] = intnumberscopy[j+1];
                            intnumberscopy[j + 1] = temp;

                        }
                    }
                }


                    return intnumberscopy;
            }

        }

        static void Main(string[] args)
        {
            //string path = @"C:\Users\Pivgin\Source\Repos\PVT\CApp_Les2_HW_FileSort\CApp_Les2_HW_FileSort\bin\Debug\data";
            //File.OpenRead("data\\originalf.txt");
            
            string [] origstr = File.ReadAllLines("data\\originalf.txt");
            int[] intnumbers = new int[origstr.Length];
            int[] intnumberscopy = new int[origstr.Length];
            string[] strnumbers = new string[origstr.Length];
            int i=0;
            string[] stri = new string[origstr.Length];
            foreach (string s in origstr) 
            {
                intnumbers[i] = int.Parse(s);
                intnumberscopy[i] = int.Parse(s);
                i++;
            }
            //int[] intnumberscopy = intnumbers;
            CustomSort.Sort(intnumbers);
           
            i = 0;
            foreach (int s1 in intnumbers) 
            {
                strnumbers[i] = s1.ToString();
                Console.WriteLine(strnumbers[i]);
                File.WriteAllLines("data\\resultf1.txt", strnumbers);
                i++;
            }
            Console.WriteLine("\n" + "----------");
            AutoSort.Sort(intnumberscopy);
            i = 0;
            foreach (int s1 in intnumberscopy)
            {
                strnumbers[i] = s1.ToString();
                Console.WriteLine(strnumbers[i]);
                File.WriteAllLines("data\\resultf2auto.txt", strnumbers);
                i++;
            }
            Console.ReadKey();
           // File.Delete("data\\resultf1.txt");
        }
    }
}
