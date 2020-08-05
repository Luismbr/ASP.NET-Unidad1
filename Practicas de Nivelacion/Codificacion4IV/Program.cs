using System;

namespace Codificacion4IV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n*********** Tabla del 4 ***********\n");

            for (int i = 1; i < 13; i++)
            {
                int N = 4*i;

                Console.WriteLine("4 x "+i + " = " + N);
            }

            Console.ReadKey();
        }
    }
}
