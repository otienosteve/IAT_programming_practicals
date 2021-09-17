using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr= new int[2,2];
            arr[0,0] = 1;
            arr[0,1] = 6;
            arr[1,0] = 7;
            arr[1,1] = 9;
         
            int[] arr4 = { 1, 4, 7, 8, 9, 34 };
            int max =
           arr4[ 0];
            Console.WriteLine("Below is the first Array");
            for (int i = 0; i <= 1; i++)
            {
                for (int j = 0; j <= 1; j++)
                {
                    Console.WriteLine(arr[j, i]);

                }
            }
            Console.WriteLine("Below is the second array in second array");
            
            int[] arr2 = {2, 5, 7, 8, 9, 7, 5,431, 780,104,809, 56, 23, 56 };
            for (int i = 0; i <= arr4.Length-1; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            for (int y = 0; y <= arr4.Length - 1; y++ )
            {
                if (arr4[y] >max)
                {
                    max = arr4[y];
                }

            }
              Console.WriteLine("the largest element in the Array is {0}" , max);
            Console.WriteLine("The Third Multidimensional array");
            int[, ,] arr3 = new int[2, 2, 2] { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };
            
 
            for (int k = 0; k <= 1; k++)
            { for(int l=0;l<=1;l++){
                for (int m = 0; m <= 1; m++)
                {
                    Console.WriteLine(arr3[k, l, m]);
                }
            }

            }

                Console.ReadKey();
        }
    }
}
