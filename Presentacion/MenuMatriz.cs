using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjMatriz;
namespace Presentacion
{
    internal class MenuMatriz
    {
        public void ejmatriz()
        {
            int op = 0;

            do
            {
                Console.Clear();
                Console.SetCursorPosition(45, 2); Console.Write("********** EJERCICIOS MATRIZ  ****************");
                Console.SetCursorPosition(45, 4); Console.Write("**  1. SUMA DE DOS MATRICES                 **");
                Console.SetCursorPosition(45, 6); Console.Write("**  2. LLENADO AUTOMATICO DE UNA MATRIZ     **");
                Console.SetCursorPosition(45, 8); Console.Write("**  3. MAYOR Y MENOR DE 3 UNA MATRIZ        **");
                Console.SetCursorPosition(45, 10); Console.Write("**  4. SUMA DE MATRICES DE 5x5              **");
                Console.SetCursorPosition(45, 12); Console.Write("**  5. ORDENAMIENTO DE UNA MATRIZ           **");
                Console.SetCursorPosition(45, 14); Console.Write("**  6. DIAGONAL DE UNA MATRIZ               **");
                Console.SetCursorPosition(45, 16); Console.Write("**  7. TRANSPUESTA                          **");
                Console.SetCursorPosition(45, 18); Console.Write("**  8. VOLVER A MENU PRINCIPAL              **");
                Console.SetCursorPosition(55, 20); Console.Write("DIGITE UNA OPCION  : ");
                Console.SetCursorPosition(45, 22); Console.Write("**********************************************");
                Console.SetCursorPosition(45, 25); Console.Write("CRISTIAN FABIAN BAQUERO BASTIDAS");
                Console.SetCursorPosition(45, 26); Console.Write("JUAN ANDRES SALCEDO BERMUDEZ");

                Console.SetCursorPosition(75, 20); op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        new Suma2Matrices().Sum2matrices();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        new Matriz5x5().Llenado5x5();
                        Console.ReadKey();

                        break;
                    case 3:
                        Console.Clear();
                        new MayorMenorMat().Matriz3();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        new SumaMatriz().Matriz4();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        new Ordenarmatriz().Matriz5();   
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        new DiagMatriz().suma_diagonal_princiapl();
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        new Transpuesta().transpuesta();
                        Console.ReadKey();
                        break;

                }



            } while (op != 8);
        }
    }
}
