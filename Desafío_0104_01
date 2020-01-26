using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_0104_01
{
    class Program
    {
        static void Main()
        {
            //Ingreso de Datos

            Console.WriteLine("Para el cálculo del cateto X ingrese los siguientes datos: ");

            Console.Write("Ingrese el cateto Z: ");
            double z = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el cateto Y: ");
            double y = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el ángulo  B: ");
            double bGrados = double.Parse(Console.ReadLine());

            //conversión  de grados a radianes:

            double b = bGrados * (Math.PI/180);

            //cálculo de datos

            double a = Math.Atan(y / z);
           
            double ba = b + a;
         
            double x = (z * Math.Tan(ba)) - y;


            // Output

            Console.WriteLine("El cateto X es: " + x); 
        }
    }
}
