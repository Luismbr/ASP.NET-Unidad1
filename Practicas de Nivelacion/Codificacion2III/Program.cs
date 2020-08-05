using System;

namespace Codificacion2III
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

            string nomProducto;

            double Precio,
                cantidad,
                  ItBis,
                  subTotal,
                  montoTotal;

            Console.WriteLine("Nombre Producto:");
            nomProducto = Console.ReadLine();
            Console.WriteLine("\nPrecio:");
            Precio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nCantidad:");
            cantidad = Convert.ToDouble( Console.ReadLine());
            subTotal = cantidad * Precio;
            ItBis = subTotal * 0.18;
            montoTotal = subTotal + ItBis;
            Console.WriteLine("\n\n" + nomProducto + "\t\tCatidad: " + cantidad + "\t  Precio:" + Precio + "\t  Subtotal: " + subTotal + "\tTotal: " + montoTotal + "\n" +
                "-----------------------------------------------------------------------------------------\n");
            Console.ReadKey();

        }
    }
}
