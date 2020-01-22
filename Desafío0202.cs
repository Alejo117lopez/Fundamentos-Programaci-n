using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_0202
{
    class Program
    {
        static void Main()
        {
            //Ingreso de Datos

            Console.Write("Ingrese el ángulo A: ");
            double aGrados = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la hipotenusa T: ");
            double t = double.Parse(Console.ReadLine());

            //Coversión de grados a radianes

            double a = aGrados * (Math.PI /180 );

            //Cálculo de los valores

            double c = 180 - 90 - aGrados;
            double y = (t * Math.Sin(a));
            double z = (t * Math.Cos(a));

           
            //Resultado de las opereaciones

            Console.WriteLine("El ángulo C es: "+ c);
            Console.WriteLine("El cateto Y es: " + y);
            Console.WriteLine("EL cateto Z es: " + z);


        }
    }
}
