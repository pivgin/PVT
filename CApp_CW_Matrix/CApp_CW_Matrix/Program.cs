using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp_CW_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int tmp;
            int [,] m1 = new int[2,2]
            {
                { 1, 2 },
                { 2, 1 }
            };
            int [,] m2 = new int[2,2]
            {
                { 2, 2 },
                { 3, 2 }
            };
            int [,] mr = new int[2,2];
            
                for (int i = 0; i < 2; i++) 
                {
                     for (int j = 0; j < 2; j++) 
                     {
                        tmp = 0;
                        for (int k = 0; k < 2; k++) 
                        {
                            tmp += m1 [i, k] * m2 [k, j]; 
                        }
                        Console.WriteLine(mr [i, j] = tmp);
                     }
                }
                Console.ReadKey();
        }
    }
}

// int[,] m2 = new int[2, 2];

// m2[0, 0] = 1;

// m2[0, 1] = 2;

// m2[1, 0] = 2;

// m2[1, 1] = 2;
