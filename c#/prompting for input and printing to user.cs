using System;


namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter Your first Name?");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name?");
            string name2= Console.ReadLine();
            Console.WriteLine("Your names is {1} {0}",name,name2);
            Console.ReadKey();
        }
    }
}
