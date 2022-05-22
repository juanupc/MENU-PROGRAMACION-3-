using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjMatriz
{
    public class Ordenarmatriz
    {
        public void Matriz5()
        {
            
            int F = 0;
            int C = 0;
            int I = 0;
            int K = 0;
            int N = 0;
            int AUX = 0;
            string cadena;
            // INGRESO
            // PARA COMODIDAD GENERAMOS VALORES PARA LA MATRIZ
            Console.Write("TAMAÑO DE LA MATRIZ: ");
            cadena = Console.ReadLine();
            Random rnd = new Random();
            N = int.Parse(cadena);
            int[,] MAT = new int[N + 1, N + 1];
            for (F = 1; F <= N; F++)
            {
                for (C = 1; C <= N; C++)
                {
                    MAT[F, C] = rnd.Next(0, 100);
                    Console.SetCursorPosition(C * 4, F + 1);
                    Console.Write(MAT[F, C]);
                }
            }
            // PROCESO
            for (F = 1; F <= N; F++)
            {
                for (C = 1; C <= N; C++)
                {
                    for (I = 1; I <= N; I++)
                    {
                        for (K = 1; K <= N; K++)
                        {
                            if ((MAT[F, C] < MAT[I, K]))
                            {
                                AUX = MAT[F, C];
                                MAT[F, C] = MAT[I, K];
                                MAT[I, K] = AUX;
                            }
                        }
                    }
                }
            }
            // SALIDA
            for (F = 1; F <= N; F++)
            {
                for (C = 1; C <= N; C++)
                {
                    Console.SetCursorPosition(C * 4, F + 10);
                    Console.Write(MAT[F, C]);
                }
            }
            Console.WriteLine();
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
    }
    
}
