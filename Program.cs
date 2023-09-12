using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NumerosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1, num = 0, div = 2;


            Console.WriteLine("Ingrese un numero");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            while (n < num)
            {
                div = 2;
               
                n++;

                while (n % div != 0)
                {
                   
                    div++;

                }

                if (div == n)
                {
                    Console.WriteLine("{0} es primo", n);

                }

            }

            Console.ReadKey();

        }
    }

}            

           

           
            
            
        
                        //Console.WriteLine("{0} es n", num);
                         //Console.WriteLine("{0} es div", div);
                         //Console.WriteLine("{0} es mod", num % div);
