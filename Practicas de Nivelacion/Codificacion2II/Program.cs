using System;

namespace Codificacion2II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("==============================>> Informacion Personal <<==============================\n");
            Console.WriteLine("     Nombre:............Luis miguel");
            Console.WriteLine("     Apellido:..........Ballenilla Ramirez\n");
            Console.WriteLine("======================================================================================");

           double notaEnero = 0, notaFebrero = 0, notaMarzo = 0, notaAbril = 0, Promedio = 0;

            Console.WriteLine("\t \t \t \t   Calculo de Notas");
            Console.WriteLine("======================================================================================\n");
            Console.WriteLine("Nota Mes de Enero:");
            notaEnero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nNota Mes de Febrero");
            notaFebrero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nNota Mes de Maezo");
            notaMarzo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nNota Mes de Abril");
            notaAbril = Convert.ToDouble(Console.ReadLine());
            Promedio = (notaEnero + notaFebrero + notaMarzo + notaAbril) / 4;
            Console.WriteLine("\nPromedio Acumulado = {0}", Promedio);
            Console.ReadKey();
        }
    }
}
