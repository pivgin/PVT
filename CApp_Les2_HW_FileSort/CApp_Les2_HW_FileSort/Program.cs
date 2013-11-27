using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CApp_Les2_HW_FileSort
{
    class AutoSort
    {
        
        public static int[] Sort(int[] intnumberscopy)
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
                        intnumberscopy[j] = intnumberscopy[j + 1];
                        intnumberscopy[j + 1] = temp;

                    }
                }
            }


            return intnumberscopy;
        }

    }

    class MyException : Exception 
    {
        public int Stringnumber { get; set; }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            //string path = @"C:\Users\Pivgin\Source\Repos\PVT\CApp_Les2_HW_FileSort\CApp_Les2_HW_FileSort\bin\Debug\data";
            //File.OpenRead("data\\originalf.txt");
          string fName = Console.ReadLine();

          try
          {
              if (!File.Exists(fName))    // data/originalf.txt
              {
                  throw new FileNotFoundException();
              }

              string[] origstr = File.ReadAllLines(fName);
              int[] intnumbers = new int[origstr.Length];
              int[] intnumberscopy = new int[origstr.Length];
              string[] strnumbers = new string[origstr.Length];
              int i = 0;
              string[] stri = new string[origstr.Length];
              
              
                  foreach (string s in origstr)
                  { 
                      try
                        {
                            intnumbers[i] = int.Parse(s);
                            intnumberscopy[i] = int.Parse(s);
                            i++;
                          throw new MyException() { Stringnumber = i };
                        }
                      catch (MyException exception)
                      {
                          Console.WriteLine("Not all the numbers in the source file are numbers.");
                          Console.WriteLine("Please check all of them. Thx");
                          Console.WriteLine("Wrong value is in string " + exception.Stringnumber);
                      }
                      
                      //intnumbers[i] = int.Parse(s);
                      //intnumberscopy[i] = int.Parse(s);  
                      //i++;
                    
                  }
              
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

          }
          catch (FileNotFoundException exception)
            {
              Console.WriteLine("Man! " + exception.Message);
            }

          Console.ReadKey();
           // File.Delete("data\\resultf1.txt");
        }
    }
}
