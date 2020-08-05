using System;

namespace Codificacion6III
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] tabla = new string[2, 3];

            string n1, n2, n3, n4, n5, n6;

            Console.Write("1er Nombre: ");
            n1 = Console.ReadLine();
            tabla[0, 0] = n1;
            Console.Write("2do Nombre: ");
            n2 = Console.ReadLine();
            tabla[0, 1] = n2;
            Console.Write("3er Nombre: ");
            n3 = Console.ReadLine();
            tabla[0, 2] = n3;

            Console.Write("4to Nombre: ");
            n4 = Console.ReadLine();
            tabla[1, 0] = n4;
            Console.Write("5to Nombre: ");
            n5 = Console.ReadLine();
            tabla[1, 1] = n5;
            Console.Write("6to Nombre: ");
            n6 = Console.ReadLine();
            tabla[1, 2] = n6;

            for (int f=0;f<2;f++)
            {
                Console.WriteLine("");
                for (int i=0; i<3;i++)
                {
                    Console.Write(tabla[f,i]+"       ");
                }
            }
            Console.ReadKey();
        }
    }
}
