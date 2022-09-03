using System;
using System.Runtime.Intrinsics.X86;

namespace Ejercicio_I06___Años_bisiestos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Escribir un programa que determine si un año es bisiesto.

            //Un año es bisiesto si es múltiplo de 4.Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400.Por ejemplo: el año 2000 es bisiesto pero 1900 no.

            //Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.

            int anioInicio, anioFinal;

            Console.WriteLine("Por favor, ingrese el anio de inicio: ");
            while ((int.TryParse(Console.ReadLine(), out anioInicio)) == false && anioInicio <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar anio de inicio! ");
            }
            
            Console.WriteLine("Por favor, ingrese el anio final: ");
            while ((int.TryParse(Console.ReadLine(), out anioFinal)) == false && anioFinal <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar anio final! ");
            }

            //rango de anios
            for (int anio = anioInicio; anio <= anioFinal; anio++)
            {
                //descarto los no bisiestos y aplico condicion de bisiesto
                if((anio!=1900 && anio!=2100) && anio % 4 == 0)
                {
                    Console.WriteLine($"El anio {anio} es bisiesto.");
                }
            }
        }
    }
}
