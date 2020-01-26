using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_0104_02
{
    class Program
    {
        static void Main()
        {
            //Ingreso de datos

            Console.WriteLine("Ingrese los siguientes datos para hallar Z: ");
            Console.Write("Ingrese el ángulo B: ");
            double bGrados = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el ángulo D: ");
            double dGrados = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el cateto Y: ");
            double y = double.Parse(Console.ReadLine());

            // conversión de grados a radianes

            double b = bGrados * (Math.PI / 180);
            double d = dGrados * (Math.PI / 180);

            // Cálculo del cateto Z:

            double eGrados = 180 - bGrados - dGrados;
         
            double cGrados = 180 - eGrados;
            double c = cGrados * (Math.PI / 180);
            double z = y * Math.Tan(c);

            //Output

            Console.WriteLine("El cateto Z es: " + z);
        }
    }
}
