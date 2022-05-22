using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjMatriz
{
    public class Matriz5x5
    {
        public void Llenado5x5()
        {

            int[,] Matriz = new int[5, 5];
            Random rand = new Random();
            Console.SetCursorPosition(45, 6); Console.WriteLine("Llenado automatico Matriz 5x5");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Matriz[i, j] = rand.Next(0, 5);

                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(Matriz[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }

    }
}
