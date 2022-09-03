using System;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Un número perfecto es un entero positivo, que es igual a la suma
            //de todos los enteros positivos (excluido el mismo) que son divisores del número.

            //El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.

            //Escribir una aplicación que encuentre los 4 primeros números perfectos.

            double anterior;
            double potencia;
            double potenciaAnterior;
            double numeroPerfecto;

            Console.WriteLine("Numeros perfectos: ");

            for(int i = 1; i <= 10; i++)
            {
                anterior = i - 1;
                potencia = Math.Pow(2, anterior);
                potenciaAnterior=(Math.Pow(2, i))-1;
                numeroPerfecto = potencia * potenciaAnterior;

                Console.WriteLine($"{i} = {numeroPerfecto}");
            }
        }
    }
}
