using System;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Ingresar un número y mostrar el cuadrado y el cubo del mismo.
            Se debe validar que el número sea mayor que cero, caso contrario,
            mostrar el mensaje: "ERROR. ¡Reingresar número!".
            */

            string numeroIngresado;
            int numeroValidado;
            bool esNumero;
            double cuadradoNumIng;
            double cuboNumIng;

            Console.WriteLine("Por favor, ingrese un numero: ");

            numeroIngresado = Console.ReadLine();
            esNumero = int.TryParse(numeroIngresado, out numeroValidado); //verifica si es entero
            while(esNumero == false && numeroValidado <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número! ");
                numeroIngresado = Console.ReadLine();
                esNumero = int.TryParse(numeroIngresado, out numeroValidado);
            }

            //Utilizar el método Pow de la clase Math para calcular las potencias.
            cuadradoNumIng = Math.Pow((double)numeroValidado, 2);
            cuboNumIng = Math.Pow((double)numeroValidado, 3);

            Console.WriteLine($"El numero es: {numeroValidado}, al cuadrado: {cuadradoNumIng} y al cubo: {cuboNumIng}");
        }
    }
}
