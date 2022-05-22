using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ejercicios
{
    public class MayorMenor
    {
        public void run()
        {
            int tamano, mayor, menor;
            int[] Vector;
            int suma = 0;
            Console.SetCursorPosition(5, 8); Console.WriteLine("Por favor ingrese el tamaño que desea el vector :");
            Console.SetCursorPosition(54, 8); tamano = int.Parse(Console.ReadLine());
            Vector = new int[tamano];
            for (int i = 0; i < tamano; i++)
            {
                Console.SetCursorPosition(15, 10); Console.WriteLine("Ingrese el elemento " + (i + 1) + " : "); //cadena = Console.ReadLine();
                Console.SetCursorPosition(38, 10); Vector[i] = int.Parse(Console.ReadLine());
                suma += Vector[i];

            }

            mayor = Vector[1];
            menor = Vector[1];
            for (int i = 0; i < tamano; i++)
            {
                if (Vector[i] > mayor)
                {
                    mayor = Vector[i];
                }
                if (Vector[i] < menor)
                {
                    menor = Vector[i];
                }
            }
            Console.WriteLine();
            Console.SetCursorPosition(15, 12); Console.WriteLine("El numero mayor es : " + mayor);
            Console.SetCursorPosition(15, 14); Console.WriteLine("El numero menor es : " + menor);
            Console.ReadKey();
        }
    }
}

