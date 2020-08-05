using System;

namespace Practica1E3
{
    class Program
    {
        static void Main(string[] args)
        {
            double SA, SN;

            Console.WriteLine("********** CALCULO NUEVO SALARIO ***********\n");

            Console.Write("Salario Actual: ");
            SA = Convert.ToInt32(Console.ReadLine());

            SN = (SA * 0.40) + SA;

            Console.WriteLine("\n\nEl nuevo salario sera de " + SN);

            Console.ReadKey();
        }
    }
}
