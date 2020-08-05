using System;

namespace Practica1E5
{
    class Program
    {
        static void Main(string[] args)
        {
            double H, pH, M, pM, te;
            Console.WriteLine("********** PORCENTAJE POR SEXO **********\n");

            Console.Write("Cantidad de Hombres: ");
            H = Convert.ToDouble(Console.ReadLine());

            Console.Write("Cantidad de Mujeres: ");
            M = Convert.ToDouble(Console.ReadLine());

            te = H + M;

            pH = (H / te) * 100;
            pM = (M / te) * 100;

            Console.WriteLine("\n"+pH + "% son Hombres y " + pM + "% son Mujeres.");
            Console.ReadKey();
        }
    }
}
