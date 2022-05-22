using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class Menu
    {
        public void Cmenu()
        {


            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            int option;

            try
            {
                do 
                {
                    Console.Clear();
                    Console.SetCursorPosition(45, 2); Console.WriteLine("*******     MENU PRINCIPAL    *******");
                    Console.SetCursorPosition(45, 6); Console.WriteLine("** 1.    EJERCICIOS BASICOS        ** ");
                    Console.SetCursorPosition(45, 8); Console.WriteLine("** 2.    EJERCICIOS VECTORES       ** ");
                    Console.SetCursorPosition(45, 10); Console.WriteLine("** 3.    EJERCICIOS MATRICES       ** ");
                    Console.SetCursorPosition(45, 12); Console.WriteLine("** 4.    SALIR                     ** ");
                    Console.SetCursorPosition(45, 14); Console.Write("         DIGITE UNA OPCION:  ");
                    Console.SetCursorPosition(45, 16); Console.Write("*******                       *******  ");
                    Console.SetCursorPosition(45, 25); Console.Write("CRISTIAN FABIAN BAQUERO BASTIDAS");
                    Console.SetCursorPosition(45, 26); Console.Write("JUAN ANDRES SALCEDO BERMUDEZ");

                    Console.SetCursorPosition(73, 14); option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            new MenuEjbasicos().ejbasicos();
                            break;
                        case 2:
                            new Menuvector().MenuP();
                            break;
                        case 3: 
                            new MenuMatriz().ejmatriz();
                            break;
                        case 4: break;
                            
                        default:
                            Console.Clear();
                            Console.WriteLine("Gracias por utilizar el programa uWu  ");
                            Console.ReadKey();
                            break;

                    }
                } while (option != 5);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);

            }
            Console.ReadLine();
        }
    }
}
