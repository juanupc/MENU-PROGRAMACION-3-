using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciceP
{
    public class ParImpar
    {
        public void numeros()
        {
            int num_1;
            string op;
            do
            {
                Console.SetCursorPosition(15, 2); Console.WriteLine("Ingrese un numero > ");
                Console.SetCursorPosition(35, 2); num_1 = int.Parse(Console.ReadLine());
                if (num_1 % 2 == 0)
                {
                    Console.SetCursorPosition(15, 4); Console.WriteLine(num_1 + " Es un numero par");
                }
                else
                {
                    Console.SetCursorPosition(15, 4); Console.WriteLine(num_1 + " Es un numero impar");
                }
                Console.SetCursorPosition(15, 6); Console.WriteLine("Desea otro numero? S / N :");
                Console.SetCursorPosition(42, 6); op = Console.ReadLine();
                Console.Clear();
            } while (!(op.Equals("n") || op.Equals("N")));
            Console.SetCursorPosition(15, 8); Console.WriteLine("Terminado...");
            Console.ReadKey();
        }
    }
}
