using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {

            Class1 obj = new Class1();
            obj.here();

            Class2 obj2 = new Class2();
            obj2.printName();
            Console.ReadKey();

        }
    }
}
