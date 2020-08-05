using System;

namespace Codificacion5I
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n****** TABLA DEL CUATRO ******\n");

            int i=1, j=1;
            while(i<=12)
            {
                j = 4 * i;
                Console.WriteLine("4 x " + i + " = "+j);
                i = i + 1;
            }

            Console.ReadKey();
        }
    }
}
