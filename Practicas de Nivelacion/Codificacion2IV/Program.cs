﻿using System;

namespace Codificacion2IV
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
            Console.WriteLine("======================================================================================");

            double SB, SN, DD, HT, TH;

            Console.WriteLine("\nDigite la tarifa por hora del Empleado: ");
            HT = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nDigite las horas trabajadas del Empleado: ");
            TH = Convert.ToDouble(Console.ReadLine());

            SB = TH * HT;
            DD = SB * 0.1;
            SN = SB - DD;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nSueldo Bruto: " + SB+"\t\tDescuento: "+DD+"\t\tSueldo Neto: "+SN);
            Console.ReadKey();
        }
    }
}
