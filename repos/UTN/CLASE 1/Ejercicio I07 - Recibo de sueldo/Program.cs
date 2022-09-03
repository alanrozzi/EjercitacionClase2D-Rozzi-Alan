using System;
using System.Drawing;

namespace Ejercicio_I07___Recibo_de_sueldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad(en años) y la cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.

            int valorPorhora;
            string nombre;
            int aniosDeAntiguedad;
            int cantidadHorasTrabajadasMes;

            int importePorMes;
            int importeTotal;
            decimal importeNeto;
            decimal descuento = 0.87M; //'M' por decimal. 'F' por float y 'L' por long. (literales)

            //Al ingresar un float o numero con coma en la consola, usar ',' y no '.'
            Console.WriteLine("Por favor, ingrese el valor de la hora: ");
            while ((int.TryParse(Console.ReadLine(), out valorPorhora)) == false && valorPorhora <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar hora! ");
            }

            Console.WriteLine("Por favor, ingrese el nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Por favor, ingrese la antiguedad en anios: ");
            while ((int.TryParse(Console.ReadLine(), out aniosDeAntiguedad)) == false && aniosDeAntiguedad <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar antiguedad! ");
            }

            Console.WriteLine("Por favor, ingrese las horas trabajadas en el mes (200 a 240): ");
            while ((int.TryParse(Console.ReadLine(), out cantidadHorasTrabajadasMes)) == false && cantidadHorasTrabajadasMes <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar horas trabajadas! ");
            }

            //Se pide calcular el importe a cobrar teniendo en cuenta que el total(que resulta de multiplicar el valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados multiplicados por $150, y al total de todas esas operaciones restarle el 13 % en concepto de descuentos.
            importePorMes = valorPorhora * cantidadHorasTrabajadasMes;
            importeTotal = importePorMes + (aniosDeAntiguedad * 150);
            importeNeto = (decimal)importeTotal * descuento;

            //poner consola linda 
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Antiguedad: {aniosDeAntiguedad} anios");
            Console.WriteLine($"Importe total por mes: {importePorMes}");
            Console.WriteLine($"Importe bruto: {importeTotal}");
            Console.WriteLine($"Importe neto: {importeNeto}");

            //Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto y el total a cobrar neto de todos los empleados ingresados.
        }
    }
}
