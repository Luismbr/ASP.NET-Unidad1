using System;

namespace Codificacion3IV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n********** DIAS DE LA SEMANA **********");

            int N;

            Console.Write("\nIngrese el numero el del dia: ");
            N = Convert.ToInt32(Console.ReadLine());

            switch (N)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nLunes");
                    break;

                case 2:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nMartes");
                    break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nMiercoles");
                    break;

                case 4:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nJueves");
                    break;

                case 5:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nViernes");
                    break;

                case 6:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nSabado");
                    break;

                case 7:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nDomingo");
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nNumero fuera de rango.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
