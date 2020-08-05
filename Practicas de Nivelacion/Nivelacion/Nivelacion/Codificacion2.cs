using System;
using System.Collections.Generic;
using System.Text;

namespace CondicionII
{
    class Codificacion2
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

            double valor1 = 0, valor2 = 0, resultado = 0;

            Console.WriteLine("\t \t \t \t    Codificacion II");
            Console.WriteLine("======================================================================================\n");
            Console.ReadKey();
            Console.WriteLine("Suma de Dos Numeros\n");
            Console.WriteLine("Ingrese el primer valor:");
            valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nIngrese el segundo valor:");
            valor2 = double.Parse(Console.ReadLine());
            resultado = valor1 + valor2;
            Console.WriteLine("\nEl resultado es {0}", resultado);
            Console.ReadKey();

        }
    }
}
