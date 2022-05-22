using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nejercicios
{
    public class SumVectores
    {
        public void sumavector()
        {

            int[] A;//Declaramos un vector A
            int[] B;//Declaramos un vector B
            int[] C;//Declaramos un vector C

            Console.SetCursorPosition(5, 2); Console.Write("Ingrese la longitud de los vectores a sumar: ");
            string linea;
            linea = Console.ReadLine();
            int n = int.Parse(linea);
            A = new int[n];
            B = new int[n];
            C = new int[n];
            Console.Clear();
            Console.SetCursorPosition(5, 4); Console.WriteLine("Ingresando valores al vector A");
            int F = 6;
            for (int i = 0; i < A.Length; i++)
            {
                Console.SetCursorPosition(5, F); Console.Write("Ingrese componente [" + (i + 1) + "]: ");
                linea = Console.ReadLine();
                A[i] = int.Parse(linea);
                F = F + 2;
            }
            Console.Clear();
            Console.SetCursorPosition(5, 4); Console.WriteLine("Ingresando valores al vector B");
            int p = 6;
            for (int j = 0; j < B.Length; j++)
            {
                Console.SetCursorPosition(5, p); Console.Write("Ingrese componente [" + (j + 1) + "]: ");
                linea = Console.ReadLine();
                B[j] = int.Parse(linea);
                p = p + 2;
            }
            for (int i = 0; i < A.Length; i++)
            {
                C[i] = A[i] + B[i];
            }
            Console.Clear();
            Console.SetCursorPosition(5, 6); Console.WriteLine("La suma de los vecores es: ");
            int K = 5;
            for (int i = 0; i < A.Length; i++)
            {
                Console.SetCursorPosition(K, 8); Console.Write("[" + C[i] + "] ");
                K = K + 10;
            }
            Console.ReadLine();
        }
    }

}
