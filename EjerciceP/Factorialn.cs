using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciceP
{
    public class Factorialn
    {
        public void Fact()
        {
            byte NUM, K;
            long RESUL = 1;
            string linea;
            Console.SetCursorPosition(40, 8); Console.Write("DIGITE UN NÚMERO: "); linea = Console.ReadLine();
            NUM = byte.Parse(linea);
            for (K = 2; K <= NUM; K++)
            {
                RESUL = RESUL * K;
            }
            Console.SetCursorPosition(40, 12); Console.WriteLine("EL FACTORIAL ES: " + RESUL);
            Console.ReadKey();
        }
    }
}
