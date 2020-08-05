using System;

namespace Codificacion5II
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string n = "";
            do
            {
                Console.WriteLine("****** MENU DE OPCIONES ******\n");
                Console.WriteLine(" 1) Tabla del 1");
                Console.WriteLine(" 2) Tabla del 2");
                Console.WriteLine(" 3) Tabla del 3");
                Console.WriteLine(" 4) Tabla del 4");
                Console.WriteLine(" 5) Tabla del 5");
                Console.WriteLine(" 6) Tabla del 6");
                Console.WriteLine(" 7) Tabla del 7");
                Console.WriteLine(" 8) Tabla del 8");
                Console.WriteLine(" 9) Tabla del 9");
                Console.WriteLine("10) Tabla del 10");
                Console.WriteLine("11) Tabla del 11");
                Console.WriteLine("12) Tabla del 12");
                Console.WriteLine("13) Salir");
                Console.WriteLine("\n******************************\n");

                
                Console.Write("Digite la opcion Deseada: ");
                n = Console.ReadLine();
                Console.Clear();

                switch (n)
                {
                    case "1":
                        Console.WriteLine("********* TABLA DEL 1 **********\n");
                        
                        for (int i = 1; i < 13; i++)
                        {
                            int a = 1 * i;

                            Console.WriteLine("1 x " + i + " = " + a);
                        }
                        Console.WriteLine("\n");
                        break;

                    case "2":
                        Console.WriteLine("********* TABLA DEL 2 **********\n");

                        for (int i = 1; i < 13; i++)
                        {
                            int a = 2 * i;

                            Console.WriteLine("2 x " + i + " = " + a);
                        }
                        Console.WriteLine("\n");
                        break;

                    case "3":
                        Console.WriteLine("********* TABLA DEL 3 **********\n");

                        for (int i = 1; i < 13; i++)
                        {
                            int a = 3 * i;

                            Console.WriteLine("3 x " + i + " = " + a);
                        }
                        Console.WriteLine("\n");
                        break;

                    case "4":
                        Console.WriteLine("********* TABLA DEL 4 **********\n");

                        for (int i = 1; i < 13; i++)
                        {
                            int a = 4 * i;

                            Console.WriteLine("4 x " + i + " = " + a);
                        }
                        Console.WriteLine("\n");
                        break;

                    case "5":
                        Console.WriteLine("********* TABLA DEL 5 **********\n");

                        for (int i = 1; i < 13; i++)
                        {
                            int a = 5 * i;

                            Console.WriteLine("5 x " + i + " = " + a);
                        }
                        Console.WriteLine("\n");
                        break;

                    case "6":
                        Console.WriteLine("********* TABLA DEL 6 **********\n");

                        for (int i = 1; i < 13; i++)
                        {
                            int a = 6 * i;

                            Console.WriteLine("6 x " + i + " = " + a);
                        }
                        Console.WriteLine("\n");
                        break;

                    case "7":
                        Console.WriteLine("********* TABLA DEL 7 **********\n");

                        for (int i = 1; i < 13; i++)
                        {
                            int a = 7 * i;

                            Console.WriteLine("7 x " + i + " = " + a);
                        }
                        Console.WriteLine("\n");
                        break;

                    case "8":
                        Console.WriteLine("********* TABLA DEL 8 **********\n");

                        for (int i = 1; i < 13; i++)
                        {
                            int a = 8 * i;

                            Console.WriteLine("8 x " + i + " = " + a);
                        }
                        Console.WriteLine("\n");
                        break;

                    case "9":
                        Console.WriteLine("********* TABLA DEL 9 **********\n");

                        for (int i = 1; i < 13; i++)
                        {
                            int a = 9 * i;

                            Console.WriteLine("9 x " + i + " = " + a);
                        }
                        Console.WriteLine("\n");
                        break;

                    case "10":
                        Console.WriteLine("********* TABLA DEL 10 **********\n");

                        for (int i = 1; i < 13; i++)
                        {
                            int a = 10 * i;

                            Console.WriteLine("10 x " + i + " = " + a);
                        }
                        Console.WriteLine("\n");
                        break;

                    case "11":
                        Console.WriteLine("********* TABLA DEL 11 **********\n");

                        for (int i = 1; i < 13; i++)
                        {
                            int a = 11 * i;

                            Console.WriteLine("11 x " + i + " = " + a);
                        }
                        Console.WriteLine("\n");
                        break;

                    case "12":
                        Console.WriteLine("********* TABLA DEL 12 **********\n");

                        for (int i = 1; i < 13; i++)
                        {
                            int a = 12 * i;

                            Console.WriteLine("12 x " + i + " = " + a);
                        }
                        Console.WriteLine("\n");
                        break;

                    default:
                        Console.WriteLine("Hasta Luego...");
                        n = "13";
                        break;

                }
            } while (n != "13");
        }
    }
}
