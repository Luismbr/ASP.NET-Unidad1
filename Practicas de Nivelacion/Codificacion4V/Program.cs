using System;

namespace Codificacion4V
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n*********** Tablas de Multiplicar ***********");

            int i=1, j=1;

            while (i <=12)
            {
                
                Console.WriteLine("\n**** Tabla del " + i+" ****");
                while(j<=12)
                {
                    int N = 0;
                    N = i * j;
                    Console.WriteLine(i + " x " + j+" = "+N);
                    j++;
                }

                i++;
                j = 1;

            }

            Console.ReadKey();
        }
    }
}
