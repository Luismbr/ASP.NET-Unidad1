using System;

namespace Practica2E2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sueldo;
            int tiempo;

            Console.WriteLine("********* EVALUACION DE SUELDO *********\n");

            Console.Write("Sueldo del empleado: ");
            sueldo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Anos laborando: ");
            tiempo = Convert.ToInt32(Console.ReadLine());


            if (sueldo < 500 && tiempo >= 10)
            {
                sueldo = sueldo * 1.2;
                Console.WriteLine("\nSu sueldo sera de " + sueldo+ " por un aumento de un 20%.");
            }
            
            if (sueldo <500 && tiempo<10)
            {
                sueldo = sueldo * 1.05;
                Console.WriteLine("\nSu sueldo sera de " + sueldo+" por un aumento de un 5%.");
            }

            if (sueldo >= 500)
            {
                Console.WriteLine("\nSu sueldo se mantiene en " + sueldo);
            }

            Console.ReadKey();
        }
    }
}
