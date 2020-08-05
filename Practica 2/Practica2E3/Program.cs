using System;

namespace Practica2E3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******* EVALUACION DE NUMEROS ********\n");

            int x, n, valor, pares, impares, negativo, positivo;

            x = 1;
            pares = 0;
            impares = 0;
            positivo = 0;
            negativo = 0;

            Console.Write("Cantidad de valores a ingresar: ");
            n = Convert.ToInt32(Console.ReadLine());

            while (x<=n)
            {
                Console.Write("Valor " + x + ": ");
                valor = Convert.ToInt32(Console.ReadLine());

                if (valor<0)
                {
                    negativo++;
                }
                else
                {
                    positivo++;
                }

                if (valor%2==0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }

                x++;
            }

            Console.Write("\nCantidad de Pares: " + pares);
            Console.Write("\nCantidad de Impares: " + impares);
            Console.Write("\nCantidad de Negativos: " + negativo);
            Console.Write("\nCantidad de Positivos: " + positivo);
            Console.ReadKey();
        }
    }
}
