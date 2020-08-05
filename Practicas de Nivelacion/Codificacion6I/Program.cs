using System;
using System.Numerics;

namespace Codificacion6I
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Vector = new int[5];

            int n;

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
            for (int i=0; i<5;i++)
            {
                Console.WriteLine(Vector[i]);
            }

            Console.ReadKey();
        }
    }
}
