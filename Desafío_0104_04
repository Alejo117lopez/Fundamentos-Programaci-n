using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_0104_04
{
    class Program
    {
        static void Main()
        {
            //Ingreso de datos

            Console.WriteLine("Ingrese los siguientes datos para hallar X: ");

            Console.Write("Ingrese el valor de W: ");
            double w = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor de T: ");
            double t = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor de C: ");
            double cGrados = double.Parse(Console.ReadLine());

            //Conversión de grados a radianes

            double c = cGrados * (Math.PI / 180);

            //Cálculo de X

            double y = t * Math.Cos(c);
            double z = t * Math.Sin(c);
            double x = Math.Sqrt((Math.Pow(w, 2)) - (z * z)) - y;

            //Resultado

            Console.WriteLine("El Valor de X es: " + x);
        }
    }
}
