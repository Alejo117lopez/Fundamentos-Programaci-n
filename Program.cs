using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08CiclosSimulacroCasa
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("B I E N V E N I D O  A L  J U E G O");
            Random aleatorio = new Random();
            int puntos = 0, dado=0, turnos=0, pierdes = 0, win= 0;
            string continuar = "s";

           
            while (continuar == "s" && puntos < 100 && pierdes != 1 && win != 2)
            {
                turnos++;
                dado = aleatorio.Next(1, 13);
                puntos += dado;
                if (dado != 10) win = 0;
                if (win == 1 && dado == 10)
                {
                    Console.WriteLine("Dado: " + dado + "\n Puntos: " + puntos);
                    Console.WriteLine("Has Ganado");
                    win++;
                   
                }
                if (dado == 12) win++;
                if (turnos <= 3 && win !=2)
                {
                    Console.WriteLine(" Turno: " + turnos);
                    Console.WriteLine("Dado: " + dado + "\n Puntos: " + puntos);
                    Console.WriteLine(" ¿Deseas continuar? s/n: ");
                    continuar = Console.ReadLine();

                }

                else if (turnos > 3 && dado % 2 == 0 && win != 2)
                {
                    Console.WriteLine("Dado: " + dado + "\n Puntos: " + puntos);
                    Console.WriteLine("Mod hard ¿Deseas continuar? s/n: ");
                    continuar = Console.ReadLine();

                }
                else if (win != 2) pierdes++;
            }
            if (continuar == "n") Console.WriteLine("¿Qué te molestó?");
            if (pierdes == 1)
            {
                Console.WriteLine("Dado: " + dado);
                Console.WriteLine("Game Over");
            }
        }
    }
}
