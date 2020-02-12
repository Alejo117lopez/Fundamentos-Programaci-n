using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Notas: pra generar numeros al azar se genera un objeto--> Random random = new Random(); además int dado = random.Next(1,7); un dado tiene 6 lados, pero el sistema 
// tiene en cuenta el primero pero no el utimo, por eso se le suma uno (1,7) y no (1,6)
namespace BlackJack_Game
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Bienvenido al Juego :D");
            Random aleatorio = new Random();
            int carta = 0, carta2 = 0, carta3=0,total = 0;
            string continuar = "s";



            while (continuar == "s" && total < 21)
            {
                if (total == 0)
                {
                    carta = aleatorio.Next(1, 11);
                    carta2 = aleatorio.Next(1, 11);
                    total = carta + carta2;

                    Console.WriteLine("Carta: " + carta);
                    Console.WriteLine("Carta: " + carta2);
                    Console.WriteLine("Puntos totales: " + total);
                    
                }
                else if (total < 21)
                {
                    Console.WriteLine("Presiona s para continuar o n para retirarte y Enter para confirmar: ");
                    continuar = Console.ReadLine();
                    carta3 = aleatorio.Next(1, 11);
                    Console.WriteLine("Carta: " + carta3);
                    total += carta3;
                    Console.WriteLine("Puntos totales: " + total);            
                }
                if (total > 21)
                {

                    Console.WriteLine(" P E R D I S T E");
                    Console.WriteLine("Tus Puntos Han Superado 21. ");
                }

                if (total == 21)
                {
                    Console.WriteLine("F E L I C I D A D E S, Has ganado ");
                }

            }

            if (continuar == "n")
            {
                Console.WriteLine("¿Te rindes tan pronto?");
                Console.WriteLine("Puntuación Final: " + total);
            }
        }
    }
}
