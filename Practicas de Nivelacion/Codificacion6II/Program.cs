using System;
using System.Linq;

namespace Codificacion6II
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Vector = new int[5];

            int n, total;

            Console.WriteLine("**** VECTOR DE 5 CODIGOS ****\n");
            Console.WriteLine("Favor ingersar valores numericos...");

            Console.Write("1er Valor: ");
            n = Convert.ToInt32(Console.ReadLine());
            Vector[0] = n;

            Console.Write("2do Valor: ");
            n = Convert.ToInt32(Console.ReadLine());
            Vector[1] = n;

            Console.Write("3er Valor: ");
            n = Convert.ToInt32(Console.ReadLine());
            Vector[2] = n;

            Console.Write("4to Valor: ");
            n = Convert.ToInt32(Console.ReadLine());
            Vector[3] = n;

            Console.Write("5to Valor: ");
            n = Convert.ToInt32(Console.ReadLine());
            Vector[4] = n;

            Console.WriteLine("\n");

            for (int f=0;f<1;f++)
            {
                Console.WriteLine("");
                for (int c=0;c<5;c++)
                {
                    Console.Write(Vector[c] + " ");
                }
            }

            total = Vector.Sum();

            Console.WriteLine("\n\nLa sumatoria de los elementos del vector es igual a " + total);

            Console.ReadKey();
        }
    }
}
