using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjMatriz
{
    public class SumaMatriz
    {
        public void Matriz4()
        {
            Random rnd = new Random();
            int F = 0;
            int C = 0;
            int[,] MATA = new int[100, 100];
            int[,] MATB = new int[100, 100];
            int[,] MATC = new int[6, 6];
            // INGRESO
            // PARA COMODIDAD GENERAMOS VALORES PARA LAS MATRICES
            for (F = 1; F <= 5; F++)
            {
                for (C = 1; C <= 5; C++)
                {
                    MATA[F, C] = rnd.Next(0, 10);
                    MATB[F, C] = rnd.Next(0, 10);
                    // SALIDA MATRIZ A
                    Console.SetCursorPosition(C * 4, F);
                    Console.Write(MATA[F, C]);
                    // SALIDA MATRIZ B
                    Console.SetCursorPosition(C * 4, F + 6);
                    Console.Write(MATB[F, C]);
                }
            }
            // PROCESO
            for (F = 1; F <= 5; F++)
            {
                for (C = 1; C <= 5; C++)
                {
                    MATC[F, C] = MATA[F, C] + MATB[F, C];
                }
            }
            // SALIDA
            Console.WriteLine("\n");
            Console.WriteLine("     MATRIZ RESULTANTE"+ "\n");
            
            for (F = 1; F <= 5; F++)
            {
                
                for (C = 1; C <= 5; C++)
                {
                    Console.SetCursorPosition(C * 4, F + 13);
                    Console.Write(MATC[F, C]);
                }
            }
            Console.ReadKey();

        }
    }
}
