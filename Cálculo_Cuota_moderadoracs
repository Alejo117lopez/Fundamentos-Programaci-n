using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cálculo_Cuota_moderadora
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese el valor de su salario (En números): ");
            double s = double.Parse(Console.ReadLine());

            double sm = 877803.00;

            if (s < (2 * sm))
            {
                Console.WriteLine("Usted es Tarifa A, y el valor de su cuota moderadora es de $3.400");
            }

            else if ((2*sm)<= s && s < (5 * sm))
            {
                Console.WriteLine("Usted es Tarifa B, y el valor de su cuota moderadora es de $13.500");
            }
            else
            {
                Console.WriteLine("Usted es Tarifa C, y el valor de su cuota moderadora es de $35.600");
            }
        }
    }
}
