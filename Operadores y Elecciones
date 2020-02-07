using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_y_Elecciones
{
    class Program
    {
        static void Main()
        {
            //Ingreso de Datos
            Console.WriteLine("Ingrese el número de votos por el Parido Uno: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de votos por el Parido Dos: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de votos en blanco: ");
            int blancos = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de votos anulados: ");
            int anulados = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de total de la población (Todas las edades): ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el porcentaje(de 0 a 100) de la población que es mayor de edad: ");
            double p = double.Parse(Console.ReadLine());

            //Otras variables y conversiones

            double pp = (p * n) / 100; // Conversión de porcentaje a #s
            int votos = a + b + blancos + anulados; //Total de votos
            bool cD;
            //Bool
            
            if (a < b)
            {
                 cD = (b - a)< (votos*10)/100;
            }
             else
            {
                 cD = (a-b)< (votos * 10) / 100;
            }
            bool cU = votos > n;

            bool cT = votos < ((n * 30) / 100);

            //Condiciones para que se repitan las votaciones

            if ((cU || cD) && cT)
            {
                Console.WriteLine("Las elecciones deben ser ejecutadas nuevamente");
            }
            else
            {
                Console.WriteLine("las votaciones fueron exitosas");
                if (a > b)
                {
                    Console.WriteLine("el partido ganador es el Uno");
                }

                else
                {
                    Console.WriteLine("el partido ganador es el Dos");
                }

            }
        }
        
    }
}
