using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjMatriz
{
    public class MayorMenorMat
    {
        public void Matriz3()
        {
            int F = 0;
            int C = 0;
            int N = 0;
            int MAY = 0;
            int MEN = 0;
            string linea;
            // INGRESO
            // PARA COMODIDAD GENERAMOS VALORES PARA LA MATRIZ
            Console.Write("TAMAÑO DE LA MATRIZ:");
            Random rnd = new Random();
            linea = Console.ReadLine();
            N = int.Parse(linea);
            int[,] MAT = new int[N + 1, N + 1];
            for (F = 1; F <= N; F++)
            {
                for (C = 1; C <= N; C++)
                {
                    MAT[F, C] = rnd.Next(0, 99);
                    Console.SetCursorPosition(C * 4, F + 1);
                    Console.Write(MAT[F, C]);
                }
            }


            MAY = MAT[1, 1];
            MEN = MAT[1, 1];
            for (F = 1; F <= N; F++)
            {
                for (C = 1; C <= N; C++)
                {
                    if ((MAT[F, C] > MAY))
                        MAY = MAT[F, C];
                    if ((MAT[F, C] < MEN))
                        MEN = MAT[F, C];
                }
            }

            Console.WriteLine();
            Console.WriteLine("NÚMERO MAYOR ES: " + MAY);
            Console.WriteLine("NÚMERO MENOR ES: " + MEN);
            Console.Write("Pulse una Tecla:");

            Console.ReadKey();
        }
    }
}
