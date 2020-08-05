using System;

namespace Codificacion4III
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n*********** Cubo de los numeros del 3 al 20 ***********\n");

            for (int i = 3; i < 21; i++)
            {
                int N=i*i*i;

                Console.WriteLine(i+"\tal cubo= "+N);


            }

            Console.ReadKey();
        }
    }
}
