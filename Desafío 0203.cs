using System;

namespace Desafío_0203
{
    class Program
    {
        static void Main()
        {
            // Ingreso de Datos

            Console.Write("Ingrese el ángulo C: ");
            double cGrados = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el cateto Z: ");
            double Z = double.Parse(Console.ReadLine());

            //Conversión de grados a radianes:
            double c = cGrados * (Math.PI/180.0);

            //Cálculo de valores

            double y = Z / Math.Tan(c);
            double a = 180 - 90 - cGrados;
            double t = Z / Math.Sin(c);

            //Mostrar los resultados

            Console.WriteLine("El cateto Y es:" + y);
            Console.WriteLine("La hipotenusa T es: " + t);
            Console.WriteLine("El ángulo A es: " + a);
        }
    }
}
