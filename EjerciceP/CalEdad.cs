using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciceP
{
    public class CalEdad
    {
        public void Calcular()
        {
            int edad, año;
            Console.SetCursorPosition(40, 12); Console.WriteLine("Ingrese su año de nacimiento : ");
            Console.SetCursorPosition(70, 12); año = int.Parse(Console.ReadLine());

            if (año >= 1000 && año< DateTime.Today.Year)
            {
                edad = DateTime.Today.Year - año;

                Console.SetCursorPosition(45, 15); Console.WriteLine("Usted tiene o está por cumplir  {0} años ", edad);

            }
            else
            {
                Console.SetCursorPosition(45, 17); Console.WriteLine("ERROR... SOLO PUEDE CALCULAR EDAD DESDE  EL AÑO 1000  EN ADELANTE ");

            }
            Console.ReadKey();
        }
    }
}
