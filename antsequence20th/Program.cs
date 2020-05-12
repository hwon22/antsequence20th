using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antsequence20th
{
    class Program
    {
        static void Main(String[] args)
        {
            int select = 20;
            int count = 1;
            int a = 0;
            int b = 0;

            int[] array1 = new int[500];
            int[] array2 = new int[500];

            array1[0] = 1;

            for (int i = 0; i < select; i++)
            {
                while (array1[a] != 0)
                { 
                    if (array1[a] == array1[a + 1])
                    {
                        count++;
                    }
                    else
                    {
                        array2[b] = array1[a];       
                        array2[b + 1] = count;      
                        count = 1;                  
                        b = b + 2;                  
                    }
                    a++;
                }
                
                Array.Copy(array2, array1, array2.Length);
                a = 0;
                b = 0;
                Console.Write(i + 1 + "번째: ");
                foreach (var arr in array1)
                {
                    if (arr == 0) break;
                    Console.Write(arr);
                }
                Console.WriteLine();
            }
        }
    }
}
