using System;

namespace Practica2E4
{
    class Program
    {
        static void Main(string[] args)
        {
            int cuenta, saldo, suma;

            suma = 0;

            Console.WriteLine("******** CUENTAS BANCARIAS *********\n");
            
            Console.Write("Numero de Cuenta: ");
            cuenta = Convert.ToInt32(Console.ReadLine());



            while(cuenta>0)
            {
                Console.Write("Saldo Actual: ");
                saldo = Convert.ToInt32(Console.ReadLine());

                if (saldo > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Acreedor");

                    suma = suma + saldo;
                }
                else if (saldo < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Deudor");
                }
                else if (saldo == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Nulo");
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("*********************************");
                Console.Write("\nNumero de Cuenta: ");
                cuenta = Convert.ToInt32(Console.ReadLine());

            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\nSuma Acreedores: " + suma);
            Console.ReadKey();
        }
    }
}
