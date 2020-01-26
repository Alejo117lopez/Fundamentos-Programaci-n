using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_0104_03
{
    class Program
    {
        static void Main()
        {
            //Ingreso de datos

            Console.WriteLine("Ingrese los siguientes datos para obtener el cateto Y: ");

            Console.Write("Ingrese la hipotenusa W: ");
            double w = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el cateto X: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el ángulo D: ");
            double dGrados = double.Parse(Console.ReadLine());

            // Conversión de grados a radianes:

            double d = dGrados * (Math.PI / 180);

            // Cálculo de Y

            double y = (w * Math.Cos(d)) - x;

            //Resultado

            Console.WriteLine("El cateto Y es: " + y);
        }
    }
}
