using System;

namespace Codificacion2I
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
            Console.WriteLine("======================================================================================\n");

            Console.WriteLine("System:\tHola!");
            Console.WriteLine("System:\tCual es tu nombre?\n");

            Console.ForegroundColor = ConsoleColor.Red;
            String Nombre = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nSystem:\tGusto en conocerte {0}", Nombre);
            Console.ReadKey();

        }
    }
}