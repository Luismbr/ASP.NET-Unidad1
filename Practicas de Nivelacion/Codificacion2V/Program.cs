using System;

namespace Codificacion2V
{
    class Program
    {
        static void Main(string[] args)
        {
            double CM, PL;

            Console.WriteLine("\t\t\t******** Convertidor de Centimetros a Pulgadas ***********\n");

            Console.Write("Centimtros: ");
            CM = Convert.ToDouble(Console.Read());

            PL = CM / 2.54;

            Console.WriteLine("Pulgadas : " + PL);

            Console.ReadKey();
        }
    }
}
