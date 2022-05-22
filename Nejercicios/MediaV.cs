using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nejercicios
{
    public class MediaV
    {
        public void Numaleatoreosvet()

        {
            int f = 10, suma = 0;
            int[] vec = new int[6];
            Random random = new Random();
            Console.SetCursorPosition(5, 6); Console.WriteLine("Hallar la media de los valores de un vector con numeros aleatorios y mostrar el resultado. ");
            for (int i = 0; i < vec.Length; i++)
            {
                vec[i] = random.Next(1, 20);
            }
            for (int i = 0; i < vec.Length; i++)
            {
                suma += vec[i];
                Console.SetCursorPosition(5, f); Console.WriteLine(vec[i]);
                f = f + 2;
            }
            double media = (double)suma / vec.Length;
            Console.SetCursorPosition(5, 22); Console.WriteLine("La media es " + media);

            Console.ReadLine();
            Console.ReadKey();





        }
    }
}
