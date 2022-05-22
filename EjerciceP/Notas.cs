using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciceP
{
    public class Notas
    {
        public void promedio()
        {
            double cont;
            double i;
            string nombre;
            double nota;
            int num_notas;
            double promedio;
            string op;
            do
            {
                cont = 0;
                Console.SetCursorPosition(15, 2); Console.WriteLine("ingrese el nombre del estudiante >");
                Console.SetCursorPosition(50, 2); nombre = Console.ReadLine();
                Console.SetCursorPosition(15, 4); Console.WriteLine("Cuantas notas va a ingresar >");
                Console.SetCursorPosition(45, 4); num_notas = int.Parse(Console.ReadLine());
                for (i = 1; i <= num_notas; i++)
                {
                    Console.SetCursorPosition(15, 6); Console.WriteLine("Ingrese las notas >");
                    Console.SetCursorPosition(35, 6); nota = Double.Parse(Console.ReadLine());
                    cont = cont + nota;
                }
                promedio = cont / num_notas;
                Console.SetCursorPosition(15, 6); Console.WriteLine("El promedio del estudiante " + nombre + " es de " + promedio);
                
                Console.SetCursorPosition(30, 10); Console.WriteLine("Desea otro estudiante? S / N :");
                Console.SetCursorPosition(60, 10); op = Console.ReadLine();
                Console.Clear();
            } while (!(op.Equals("n") || op.Equals("N")));
            Console.SetCursorPosition(15, 12); Console.WriteLine("Terminado...");
            Console.ReadKey();
        }
    }
}
