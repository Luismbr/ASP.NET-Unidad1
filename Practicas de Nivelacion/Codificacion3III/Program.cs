using System;

namespace Codificacion3III
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n********** Confirmacion de edad **********");

            double Edad;

            Console.Write("\nQue edad Tiene? ");
            Edad = Convert.ToDouble(Console.ReadLine());

            if (Edad == 0 && Edad == 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nBebé");
            }

            else if (Edad >= 2 && Edad <= 12)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nNiño");
            }

            else if (Edad >= 13 && Edad <= 17)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nAdolescente");
            }

            else if (Edad >= 18 && Edad <= 30)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nJoven");
            }

            else if (Edad >= 31 && Edad <= 64)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nAdulto");
            }

            else if (Edad >= 65 && Edad <= 120)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nAnciano");
            }

            else if (Edad < 0 && Edad >125)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nError");
            }

            Console.ReadKey();
        }
    }
}
