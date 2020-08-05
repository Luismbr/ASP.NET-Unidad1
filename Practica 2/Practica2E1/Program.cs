using System;

namespace Practica2E1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********* MULTIPLOS DE 3 *********\n");

            int numero=1;

           while(numero<200)
            {
                if (numero%3 ==0)
                {
                    Console.WriteLine(numero);
                }

                numero++;
            }
            Console.ReadKey();
        }
    }
}
