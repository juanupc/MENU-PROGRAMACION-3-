using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjerciceP;
namespace Presentacion
{
    internal class MenuEjbasicos
    {
        public void ejbasicos()
        {
            int op = 0;

            do
            {
                Console.Clear();
                Console.SetCursorPosition(45, 2); Console.Write("********** EJERCICIOS BASICOS *********");
                Console.SetCursorPosition(45, 4); Console.Write("**  1. CALCULAR EDAD                 **");
                Console.SetCursorPosition(45, 6); Console.Write("**  2. SERIE FIBONACCI               **");
                Console.SetCursorPosition(45, 8); Console.Write("**  3. MAYOR Y MENOR DE 3 NUMEROS    **");
                Console.SetCursorPosition(45, 10); Console.Write("**  4. OPERACIONES BASICAS           **");
                Console.SetCursorPosition(45, 12); Console.Write("**  5. FACTORIAL                     **");
                Console.SetCursorPosition(45, 14); Console.Write("**  6. PAR O IMPAR                   **");
                Console.SetCursorPosition(45, 16); Console.Write("**  7. NOTAS                         **");
                Console.SetCursorPosition(45, 18); Console.Write("**  8. VOLVER A MENU PRINCIPAL       **");
                Console.SetCursorPosition(52, 20); Console.Write("DIGITE UNA OPCION  : ");
                Console.SetCursorPosition(45, 22); Console.Write("****************************************");
                Console.SetCursorPosition(45, 25); Console.Write("CRISTIAN FABIAN BAQUERO BASTIDAS");
                Console.SetCursorPosition(45, 26); Console.Write("JUAN ANDRES SALCEDO BERMUDEZ");
                Console.SetCursorPosition(72, 20); op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        new CalEdad().Calcular();
                        break;
                    case 2:
                        Console.Clear();
                        new Fibonacci().fibo();
                        Console.ReadKey();
                        
                        break;
                    case 3:
                        Console.Clear();
                        new Maymen3num().May3num();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        new Opbasicas().OperacionesB();

                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        new Factorialn().Fact();
                        Console.ReadKey();
                        break;

                    case 6:
                        Console.Clear();
                        new ParImpar().numeros();
                        Console.ReadKey();
                        break;

                    case 7:
                        Console.Clear();
                        new Notas().promedio();
                        Console.ReadKey();
                        break;

                   

                }



            } while (op != 8);
        }
    }
}
