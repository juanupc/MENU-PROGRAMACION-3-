using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciceP
{
    public class Opbasicas
    {
        public void OperacionesB()
        {
            int Numero1, Numero2;
            int Suma, Resta, Mult ,Div;
            Console.SetCursorPosition(40, 4); Console.WriteLine("Por favor ingresa el primer numero : ");
            Console.SetCursorPosition(77, 4); Numero1 = Convert.ToInt32(Console.ReadLine());
            Console.SetCursorPosition(40,8); Console.WriteLine("Por favor ingresa el segundo  numero : ");
            Console.SetCursorPosition(79, 8); Numero2 = Convert.ToInt32(Console.ReadLine());

            Suma = Numero1 + Numero2;
            Resta = Numero1 - Numero2;
            Mult = Numero1 * Numero2;
            Div = Numero1 / Numero2;

            Console.SetCursorPosition(40, 12); Console.WriteLine("Suma :" + Suma);
            Console.SetCursorPosition(40, 14); Console.WriteLine("Resta :" + Resta);
            Console.SetCursorPosition(40, 16); Console.WriteLine("Multiplicación :" + Mult);
            Console.SetCursorPosition(40, 18); Console.WriteLine("Division :" + Div);

            Console.ReadKey();
        }

    }
}
