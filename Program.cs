using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroCiclosP2casa
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Bienvenido al Juego :D");

            Random aleatorio = new Random();

            int dado1, dado2 = 0, puntos = 0, turnoV =0 , turnoD= 0, vidas = 3;
            string continuar = "s";

          
            while (vidas > 0 && puntos < 100 && continuar == "s")
            {
                
                dado1 = aleatorio.Next(1, 2);
                dado2 = 0;
                turnoV++;
                turnoD++;
                Console.WriteLine("Dado Uno: " + dado1);
                

                if (turnoV == 2) //Cuenta cada dos turnos para rebajar una vida
                {
                    vidas--;
                    turnoV = 0;
                }

                if (turnoD == 3)//Cuenta cada tres turnos para accerder al segundo dado
                {

                    dado2 = aleatorio.Next(1, 2);
                    
                    turnoD = 0;
                    
                    Console.WriteLine("Dado Dos: " + dado2); 

                    if (dado2 == dado1)
                    {
                        vidas++;
                    }
                }

                puntos += (dado1 + dado2);
                Console.WriteLine("Puntos: " + puntos + "  Vidas: " + vidas);

                if (puntos >= 100)
                {
                    Console.WriteLine("V I C T O R I A =D");
                }
                if (vidas == 0)
                {
                    Console.WriteLine("G A M E   O V E R ");
                }
                
                

                if (vidas>0 && puntos<100)
                {                 
                    Console.WriteLine("¿Desea continuar? s/n: ");
                    continuar = Console.ReadLine();
                }
            }
            if (continuar != "s") Console.WriteLine("¿Te vas tan pronto? =c ");
            
        }
    }
}
