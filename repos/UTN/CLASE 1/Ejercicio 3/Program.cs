using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Mostrar por pantalla todos los números primos que haya
            hasta el número que ingrese el usuario por consola.

            Validar que el dato ingresado por el usuario sea un número.

            Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".

            Si ingresa "salir", cerrar la consola.

            Al finalizar, preguntar al usuario si desea volver a operar.
            Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.

            IMPORTANTE
            Utilizar sentencias de iteración, selectivas y el operador módulo(%).
            */

            string ingreso;
            string continuar="no";
            int numeroValidado;
            bool esNumero;
            int contadorPrimos;

            do
            {
                Console.WriteLine("Por favor, ingrese un numero o \"salir\": ");
                ingreso = Console.ReadLine();
                esNumero = int.TryParse(ingreso, out numeroValidado); //verifica si es entero
                while (esNumero == false && numeroValidado <= 0 && ingreso!="salir")
                {
                    Console.WriteLine("ERROR. ¡Reingresar número! ");
                    ingreso = Console.ReadLine();
                    esNumero = int.TryParse(ingreso, out numeroValidado);
                    
                }
                if (ingreso == "salir")
                {
                    Environment.Exit(0);
                   //Console.WriteLine("Saliste");
                   //break;
                }

                        //Mostrar por pantalla todos los números primos que haya
                        //hasta el número que ingrese el usuario por consola.

                        //primos: divide por si mismo y por 1

                Console.WriteLine($"Numeros primos anteriores a: {numeroValidado}");

                for (int i = 2; i <= numeroValidado; i++)//recorro desde el 2 hasta el numero ingresado, 1 no es primo
                {
                    contadorPrimos = 0; //innit de contador para reiniciarlo cada que itera otro numero
                    //recorro por cada numero, todos los anteriores: desde el 1 hasta si mismo (i)
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            contadorPrimos++;
                        }
                    }
                    if(contadorPrimos==2) //si se divide por el anterio y si mismo, daria solo 2 el contador
                    {
                        Console.WriteLine($" {i} ");
                    }
                    
                }

                Console.WriteLine("Ingresar otro numero?: \"si\" u otro");
                continuar = Console.ReadLine();
            } while (continuar=="si");
        }
    }
}
