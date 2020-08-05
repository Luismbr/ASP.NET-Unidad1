using System;

namespace Practica1E4
{
    class Program
    {
        static void Main(string[] args)
        {
            double P, D, R;

            Console.WriteLine("******** CONVERTIR DE PESOS A DOLARES *********\n");
            
            Console.Write("Valor a Cambiar: ");
            P = Convert.ToDouble(Console.ReadLine());
            Console.Write("Valor actual dolar: ");
            D = Convert.ToDouble(Console.ReadLine());

            R = P / D;

            Console.WriteLine("\nRD$"+P+" es equivalente a US$"+Math.Round(R,2));
            Console.ReadKey();
        }
    }
}
