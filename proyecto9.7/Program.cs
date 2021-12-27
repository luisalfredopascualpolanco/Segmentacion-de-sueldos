using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto9._7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int posicion = 0;
                int empleado = 0;
                int sueldo = 0;
                int SueldoEntre100Y300 = 0;
                int SueldoMayor300 = 0;
                Console.Write("Dame la cantidad de empleados: ");
                int cantidad = int.Parse(Console.ReadLine());
                int[] sueldos = new int [cantidad];

                while (posicion < cantidad)
                {
                    empleado = posicion + 1;
                    Console.Write("Dame el sueldo del empleado #" + empleado+": ");
                    sueldo = int.Parse(Console.ReadLine());
                    while (sueldo < 100 || sueldo > 500)
                    {
                        Console.WriteLine();
                        Console.WriteLine("El sueldo debe ser entre 100 y 500");
                        Console.Write("Dame el sueldo del empleado #" + empleado + ": ");
                        sueldo = int.Parse(Console.ReadLine());
                    }
                    sueldos[posicion] = sueldo;
                    posicion++;
                }
                posicion = 0;
                while (posicion < cantidad)
                {
                    if (sueldos[posicion] > 99 && sueldos[posicion] < 301)
                    {
                        SueldoEntre100Y300 = SueldoEntre100Y300 + 1;
                    }
                    else
                    {
                        SueldoMayor300 = SueldoMayor300 + 1;
                    }
                    posicion++;
                }
                Console.WriteLine("Un total de "+SueldoEntre100Y300+" empleados tienen un suledo entre 100$ y 300$, pero "+SueldoMayor300+" empleados superan los 300$");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Ha introducido un valor invalido");
            }
            Console.ReadKey();
        }
    }
}
