using System;

namespace Practica1E1
{
    class Program
    {
        static void Main(string[] args)
        {
            int L, P;
            Console.WriteLine("******* CALCULO DEL PERIMETRO DE UN CUADRADO *******\n");
            Console.Write("Digite el valor de uno de los lados: ");
            L = Convert.ToInt32(Console.ReadLine());

            P = L * 4;

            Console.WriteLine("\nEl valor del Perimetro es "+P);

            Console.ReadKey();
        }
    }
}
