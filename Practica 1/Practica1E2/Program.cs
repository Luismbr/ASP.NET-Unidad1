using System;

namespace Practica1E2
{
    class Program
    {
        static void Main(string[] args)
        {
            double P, V, T, M;
            Console.WriteLine("******** CALCULO DE MASA DE AIRE *********\n");
            
            Console.Write("Presion: ");
            P=Convert.ToDouble(Console.ReadLine());

            Console.Write("Volumen: ");
            V = Convert.ToDouble(Console.ReadLine());

            Console.Write("Temperatura: ");
            T = Convert.ToDouble(Console.ReadLine());


            M = ((P*V)/(0.37*(T+460)));

            Console.WriteLine("\nEl Valor de la Masa es "+M);

            Console.ReadKey();
        }
    }
}
