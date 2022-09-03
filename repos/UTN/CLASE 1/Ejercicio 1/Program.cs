using System;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I01 - Máximo, mínimo y promedio
            /*
             * Ingresar 5 números por consola, guardándolos en una variable escalar.
             * Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
             * */

            //CTRL+K , CTRL+D, order code, beauty <3

            string number;
            int numberParser;
            bool verify;

            int maxNumber = 0;
            int minNumber = 0;
            int totalNum = 0;
            int counterNum = 0;
            decimal averageNumbers;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter numbers: ");

                number = Console.ReadLine();
                verify = int.TryParse(number, out numberParser); //verifica si es entero

                if (verify == true && numberParser!=0)
                {
                    if (numberParser < minNumber || i == 0)
                    {
                        minNumber = numberParser;
                    }
                    if (numberParser > maxNumber || i == 0)
                    {
                        maxNumber = numberParser;
                    }
                    totalNum += numberParser;
                    counterNum++;
                }
                else
                {
                    Console.WriteLine("Not a number");
                    Console.WriteLine($"Retrys availables: {4 - i}");
                }
            }

            averageNumbers = (decimal)totalNum / counterNum;

            Console.WriteLine($"Average: {averageNumbers}; maximun: {maxNumber}, minimun: {minNumber}");

        }
    }
}
