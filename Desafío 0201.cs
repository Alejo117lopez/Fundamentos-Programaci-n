using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_0201
{
    class Program
    {
        static void Main()

        {
            // Ingresar datos, en este caso los catetos "z" y "y".

            Console.Write("Ingrese el cateto Z: ");
            double z = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el cateto Y: ");
            double y = int.Parse(Console.ReadLine());

            //Cálculo de los valores

            double t = Math.Sqrt((y * y) + (z * z));
            double c = Math.Atan(z / y);
            double a = Math.Atan(y / z);

            //Conversión de los ángulos a Grados

            double cGrados = c * (180/Math.PI);
            double aGrados = a * (180/Math.PI);


            //Se muestran los resultados

            Console.WriteLine("La hipotenusa T es: "+ t);
            Console.WriteLine("El ángulo C es: " + cGrados);
            Console.WriteLine("El ángulo A es: " + aGrados);


        }
    }
}
