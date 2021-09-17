using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {   public delegate void combine(int num, int num2);
        static void Main(string[] args)
    {
        combine cdm = new combine(numsadd);
        cdm.Invoke(12,13);
        cdm += numsadds;
        cdm.Invoke(25, 10);
        Console.ReadKey();
        }

        static void numsadd(int val1, int val2)
        {
            Console.WriteLine("{0} + {1}= {2}", val1, val2, val1+val2);
        }
        static void numsadds(int val1, int val2)
        {
            Console.WriteLine("{0} - {1}= {2}", val1, val2, val1 - val2);
        }
    }
}
