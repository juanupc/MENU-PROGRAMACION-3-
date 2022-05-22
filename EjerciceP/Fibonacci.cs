using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciceP
{
    public class Fibonacci
    {
        public void fibo()
        {

            int n, primero = 0, segundo = 1, siguiente;
            Console.SetCursorPosition(40, 3); Console.WriteLine("Ingrese el valor de n para completar la  serie fibonacci : ");
            Console.SetCursorPosition(98, 3); n = Convert.ToInt32(Console.ReadLine());
            int F = 40;
            for (int i = 0; i <= n; i++)
            {
                if (i <= 1)
                {
                    siguiente = i;
                }
                else
                {
                    siguiente = primero + segundo;
                    primero = segundo;
                    segundo = siguiente;

                }
                Console.SetCursorPosition(F,10 ); Console.Write("{0} - ", siguiente);
                F = F + 8;
            }
            Console.ReadKey();
        }
    }
}

