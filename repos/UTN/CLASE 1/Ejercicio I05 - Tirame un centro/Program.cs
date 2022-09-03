using System;

namespace Ejercicio_I05___Tirame_un_centro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ctrl E, W, word wrap ->

            //Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de números, cuyas sumas son iguales.

            //El primer centro numérico es el 6, el cual separa la lista(1 a 8) en los grupos: (1; 2; 3; 4; 5) y(7; 8) cuyas sumas son ambas iguales a 15.El segundo centro numérico es el 35, el cual separa la lista(1 a 49) en los grupos: (1 a 34) y(36 a 49) cuyas sumas son ambas iguales a 595.

            //Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.

            int numeroValidado;

            //titulo
            //Console.Title = "Ejercicio I05 - Tirame un centro";

            Console.WriteLine("Por favor, ingrese un numero: ");

            //numeroIngresado = Console.ReadLine();
            //esNumero = int.TryParse(numeroIngresado, out numeroValidado); //verifica si es entero
            while ((int.TryParse(Console.ReadLine(), out numeroValidado)) == false && numeroValidado <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número! ");
                //numeroIngresado = Console.ReadLine();
                //esNumero = int.TryParse(Console.ReadLine(), out numeroValidado);
            }

            //recorro desde 1 hasta el numero
            for (int centro = 1; centro < numeroValidado; centro++)
            {
                int sumaAnteriores = 0;
                //sumo numeros anteriores al centro.
                for (int anteriores = 1; anteriores < centro; anteriores++)
                {
                    sumaAnteriores += anteriores;
                }

                int sumaPosteriores = 0;
                //sumo posteriores hasta la igualdad de las sumas anteriores
                for (int posteriores = centro + 1; posteriores <= sumaAnteriores; posteriores++)
                {
                    //pero sin pasarse de la igualdad de sumas
                    if(sumaPosteriores>=sumaAnteriores)
                    {
                        break;
                    }
                    sumaPosteriores += posteriores;
                }

                //si la suma es igual en ambos lados, hay un centro
                if(sumaAnteriores==sumaPosteriores)
                {
                    Console.WriteLine($"Centro: {centro}");
                }
            }
        }
    }
}
