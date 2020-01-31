using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cálculo_de_tarifa
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese en números la cantidad de su salario mensual: ");
            double s = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese en números la cantidad de UN (1) SMMLV: ");
            double sm = double.Parse(Console.ReadLine());

            if (s < (2 * sm)) { 
            
               Console.WriteLine("Usted es Tarifa A");
            }

            else if ( (2*sm)<= s && s< (4 * sm))
            {
                Console.WriteLine("Usted es Tarifa B");
            }
            else
            {
                Console.WriteLine("Usted es Tarifa C");
            }

        }
    }
}
