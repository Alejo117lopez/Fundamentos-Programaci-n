using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_Switch_case
{
    class Program
    {
        static void Main()
        {
            //ENTRADAS
            Console.WriteLine("Ingrese su Salario Mensual en Números y sin separadores: ");
            int Salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese (1) si su contrato es INDEPENDIENTE o (2) si es DEPENDIENTE : ");
            int TipoContrato = int.Parse(Console.ReadLine());

            //VARIABLES INTERNAS
            int smmlv = 877803;
            double baseCotizacion = (Salario*40)/100;
            double salarioReal,arl=0,pension, eps, prima, salarioAnual;
            

            if (baseCotizacion < smmlv) baseCotizacion = smmlv;
            

            switch (TipoContrato)
            {
                
                case 1:
                      Console.WriteLine("Ingrese de 1 a 5 su nivel de riesgo: ");
                      int riesgo = int.Parse(Console.ReadLine());
                      pension = (16 * baseCotizacion) / 100;
                      eps = (12.5 * baseCotizacion) / 100;
                    
                    switch (riesgo)
                    {
                        case 1: arl = (baseCotizacion * 0.522) / 100;
                                break;
                        case 2: arl = (baseCotizacion * 1.044) / 100;
                            break;
                        case 3: arl = (baseCotizacion * 2.436) / 100;
                            break;
                        case 4: arl = (baseCotizacion * 4.350) / 100;
                            break;
                        case 5: arl = (baseCotizacion * 6.960) / 100;
                            break;
                        default: Console.WriteLine("El valor no está en el rango de riesgo");
                            break;
                            
                    }

                    salarioReal = Salario - arl - pension - eps;
                    salarioAnual = (salarioReal * 12);
                    Console.WriteLine("Su Salario Real es: " + salarioReal);
                    Console.WriteLine("Sus ingresos anuales son: " + salarioAnual);
                    break;


                case 2:  
                    eps = (4 * baseCotizacion) / 100; 
                    pension = (4 * baseCotizacion) / 100;
                    prima = Salario;
                    salarioReal = Salario - eps - pension;
                    salarioAnual = (salarioReal * 12) + prima;

                    Console.WriteLine("Su Salario Real es: " + salarioReal);
                    Console.WriteLine("Sus ingresos anuales son: " + salarioAnual);
                    
                    break;

                    
            }
        
           
        }
    }
}
