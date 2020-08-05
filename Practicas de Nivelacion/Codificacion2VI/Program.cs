using System;

namespace Condificacion2VI
{
    class Program
    {
        static void Main(string[] args)
        {
            double C, M, T, n, I;
            Console.WriteLine("************* CALCULO DE CUOTAS ****************");
            Console.Write("\nMonto: ");
            M = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nInteres: ");
            n = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nTiempo: ");
            T = Convert.ToDouble(Console.ReadLine());

            I = n * 0.01;
            
            C = (((M * I) / T) + (M / T));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nCuota mensual a pagar: ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("RD$"+C);

            Console.ReadKey();
        }
    }
}
