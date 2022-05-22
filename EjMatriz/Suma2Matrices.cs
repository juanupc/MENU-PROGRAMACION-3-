using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjMatriz
{
    public class Suma2Matrices
    {
        public void Sum2matrices()
        {
            int[,] Matriz1 = new int[2, 2];
            int[,] Matriz2 = new int[2, 2];

            int[,] MatrizR = new int[2, 2];

            Console.SetCursorPosition(45, 2); Console.WriteLine("Ingreso de  datos Matriz 1");
            int F = 4;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.SetCursorPosition(45,F ); Console.WriteLine(" Por favor ingrese dato:  ");
                    Console.SetCursorPosition(69, F); Matriz1[i, j] = int.Parse(Console.ReadLine());
                    F = F + 2;
                }
            }
            Console.Clear();
            Console.SetCursorPosition(45, 2); Console.WriteLine("Ingreso de datos Matriz 2");
            int K = 4;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.SetCursorPosition(45, K); Console.WriteLine(" Por favor ingrese dato:  ");
                    Console.SetCursorPosition(69, K); Matriz2[i, j] = int.Parse(Console.ReadLine());
                    K = K + 2;
                }
            }
            //SUMA DE MATRIZ 1 Y 2
            Console.Clear();
            Console.SetCursorPosition(45, 2); Console.WriteLine("Suma  de matrices...");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    MatrizR[i, j] = Matriz1[i, j] + Matriz2[i, j];
                }
            }

            //RESULTADO...
            Console.SetCursorPosition(45, 6); Console.WriteLine("El resultado de la suma de matrices es...");
            int  G = 45, p = 45, X=8,N=8 ;
            for (int i = 0; i < 2; i++)
            {

                Console.Write("\n       ");
                for (int j = 0; j < 2; j++)
                {

                    
                    Console.SetCursorPosition(p, X); Console.Write(MatrizR[i, j] + "  ");
                    p = p + 3;
                    
                }

                p = G;
                X = N+2;
            }

            Console.ReadKey();
        }
    }
}
