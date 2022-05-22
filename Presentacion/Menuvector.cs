using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nejercicios;
namespace Presentacion
{
    internal class Menuvector
    {
        public void MenuP()
        {
            int op = 0;
            
            do
            {
                Console.Clear();
                Console.SetCursorPosition(45, 2); Console.Write("********** EJERCICIOS VECTORES  ****************");
                Console.SetCursorPosition(45, 4); Console.Write("**  1. MAYOR Y MENOR DE UN VECTOR             **");
                Console.SetCursorPosition(45, 6); Console.Write("**  2. MEDIA DE UN VECTOR                     **");
                Console.SetCursorPosition(45, 8); Console.Write("**  3. SUMA DE VECTORES                       **");
                Console.SetCursorPosition(45, 10); Console.Write("**  4. SUMA PAR E IMAR DE UN VECTOR           **");
                Console.SetCursorPosition(45, 12); Console.Write("**  5. HALLAR PROMEDIO DE ALTURA DE 5 PESONAS **");
                Console.SetCursorPosition(45, 14); Console.Write("**  6. COSTO DE UN PLATO                      **");
                Console.SetCursorPosition(45, 16); Console.Write("**  7. CUADRATOS DE UN NUMERO                 **");
                Console.SetCursorPosition(45, 18); Console.Write("**  8. VOLVER A MENU PRINCIPAL                **");
                Console.SetCursorPosition(55, 20); Console.Write("DIGITE UNA OPCION  : ");
                Console.SetCursorPosition(45, 22); Console.Write("**********************************************");
                Console.SetCursorPosition(45, 25); Console.Write("CRISTIAN FABIAN BAQUERO BASTIDAS");
                Console.SetCursorPosition(45, 26); Console.Write("JUAN ANDRES SALCEDO BERMUDEZ");
                Console.SetCursorPosition(75, 20); op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                         new MayorMenorv().mayormenorvect();
                        break;
                    case 2:
                        Console.Clear();
                        new MediaV().Numaleatoreosvet();
                        Console.ReadKey();

                        break;
                    case 3:
                        Console.Clear();
                        new SumVectores().sumavector();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        new SParImp().ParimparVect();

                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                      new AlturaPers().PromAltura();
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        new Costoplato().Plato();
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        new Cuadratos().cuadrados();
                        Console.ReadKey();
                        break;

                    

                }



            } while (op != 8);
        }
    }
}
