using System;

namespace Codificacion3II
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1, N2, N3, N4, P;

            Console.WriteLine("\n************* CALCULO DE PROMEDIO NOTAS ***************");
            
            Console.Write("\n\tNota 1: ");
            N1=Convert.ToDouble(Console.ReadLine());
            
            Console.Write("\tNota 2: ");
            N2 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("\tNota 3: ");
            N3 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("\tNota 4: ");
            N4 = Convert.ToDouble(Console.ReadLine());

            P = (N1 + N2 + N3 + N4) / 4;
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nPromedio Acumulado: " + P);

            if (P>=0 && P<65)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("----- Reprobado -----");
            }
            else if (P>=65 && P<75)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("----- Aprobado -----");
            }
            else if (P >= 75 && P < 85)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("----- Muy Bueno -----");
            }
            else if (P >= 85 && P < 90)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("----- Sobresaliente -----");
            }
            else if (P >= 90 && P <= 100)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("----- Excelente -----");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Valor fuera de rango, favor verificar.");
            }

            Console.ReadKey();
        }
    }
}
