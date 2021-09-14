using System;


namespace DESIGNATE
{
    class Area
    { int num;
        int num2;
        int num3;

        public decimal circle(decimal rad)
        {
            return 3.142m*rad*rad;
        }



        static void Main(string[] args)
        {
            Area circ = new Area();
            Console.WriteLine(circ.circle(7.0m));

            int[, ,] arr4 = new int[2, 3, 5] { { { 1, 2, 4, 5, 6 }, { 7,808, 9, 3, 2 }, { 45, 67, 89, 12, 90 } }, { { 78, 12, 3, 67, 43 }, { 13, 78, 34, 89, 44 }, { 56,78,65,90,65} } };
            bool hold = true;
            int hold2=arr4[0,0,0];
            for (int i = 0; i <= 1;i++ )
            {
                for (int k = 0; k <= 2; k++)
                {
                    for (int l = 0; l <= 4; l++)
                    {
                        if (arr4[i, k, l] > hold2)
                        {
                            hold2=arr4[i,k,l];
                        }
                      

                    }

                }

            }
            Console.WriteLine(hold2);
            if (hold == false)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("You  missed the password");
            }
            product prod1= new product();
         int  add=  prod1.numbers(156, 12);

        
         Console.WriteLine(add);
         Console.ReadKey();
        }

    }
   



	}





    class product
    {



        int n = 10;
        int j = 12;
        int num;
        public int numbers(int n, int n2)
        {
        return n*n2;  
        }
    }
}
