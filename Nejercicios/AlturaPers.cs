﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nejercicios
{
    public class AlturaPers
    {
        public void PromAltura()
        {
            float[] alturas;
            float promedio;
            alturas = new float[5];
            for (int f = 0; f < 5; f++)
            {
                Console.Write("Ingrese la altura de la persona:");
                string linea = Console.ReadLine();
                alturas[f] = float.Parse(linea);
            }
            float suma;
            suma = 0;
            for (int f = 0; f < 5; f++)
            {
                suma = suma + alturas[f];
            }
            promedio = suma / 5;
            Console.WriteLine("Promedio de alturas:" + promedio);

            int may, men;
            may = 0;
            men = 0;
            for (int f = 0; f < 5; f++)
            {
                if (alturas[f] > promedio)
                {
                    may++;
                }
                else
                {
                    if (alturas[f] < promedio)
                    {
                        men++;
                    }
                }
            }
            Console.WriteLine("Cantidad de personas mayores al promedio:" + may);
            Console.WriteLine("Cantidad de personas menores al promedio:" + men);
            Console.ReadKey();
        } 
    }
}
