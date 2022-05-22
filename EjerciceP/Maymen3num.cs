using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciceP
{
    public class Maymen3num
    {
        public void May3num()
        {
        
          int numero1, numero2, numero3, mayor, menor;
          Console.SetCursorPosition(40, 4); Console.WriteLine("Ingrese el primer numero :");
          Console.SetCursorPosition(67, 4); numero1 = Convert.ToInt32(Console.ReadLine());

          Console.SetCursorPosition(40, 6); Console.WriteLine("Ingrese el segundo  numero :");
          Console.SetCursorPosition(67, 6); numero2 = Convert.ToInt32(Console.ReadLine());

          Console.SetCursorPosition(40, 8); Console.WriteLine("Ingrese el tercer  numero :");
          Console.SetCursorPosition(67, 8); numero3 = Convert.ToInt32(Console.ReadLine());
                mayor = numero1; menor = numero1;

                if (numero2 > mayor) mayor = numero2;


                if (numero3 > mayor) mayor = numero3;

                if (numero2 < menor) menor = numero2;

                if (numero3 < menor) menor = numero3;

                Console.SetCursorPosition(45, 10); Console.WriteLine("El numero mayor es:" + mayor);
                Console.SetCursorPosition(45, 12); Console.WriteLine("El numero menor es:" + menor);

                Console.ReadKey();
                  
        }
    }
}
