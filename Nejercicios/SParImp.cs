using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nejercicios
{
    public class SParImp
    {
        public void ParimparVect()
        {
            int I = 0;
            int CAN = 0;
            int SUMP = 0;
            int SUMI = 0;
            int[] VEC = new int[13];
           
            string linea;
            Console.SetCursorPosition(5, 6); Console.Write("CUANTOS ELEMENTOS MÁX=12:");
            linea = Console.ReadLine();
            CAN = int.Parse(linea);
            // INGRESO
            Console.Clear();
            int F = 6;
            for (I = 1; I <= CAN; I++)
            {
                Console.SetCursorPosition(5, F); Console.Write("POSICIÓN {0} ==>", I);
                linea = Console.ReadLine();
                VEC[I] = int.Parse(linea);
                F = F + 2;
            }
            // PROCESO
            SUMP = 0;
            SUMI = 0;
            for (I = 1; I <= CAN; I++)
            {
                if ((VEC[I] % 2) == 0)
                {
                    SUMP = SUMP + VEC[I];
                }
                else
                {
                    SUMI = SUMI + VEC[I];
                }
            }
            // SALIDA
            Console.Clear();
            Console.WriteLine();
            Console.SetCursorPosition(5, 6); Console.WriteLine("SUMA VALORES PARES: " + SUMP);
            Console.SetCursorPosition(5, 8); Console.WriteLine("SUMA VALORES IMPARES: " + SUMI);
            Console.SetCursorPosition(5, 10); Console.Write("Pulse una Tecla:");
            Console.ReadLine();

        }
    }
}
