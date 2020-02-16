using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroP2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Bienvenido al juego\n");

            Random aleatorio = new Random();
            int vidas = 3, puntos = 0, dado=0, consecutivo = 0, contador1s=0,sis=0, dadoEsp=2;
            string continuar = "s", ActDadoEsp = "s";

            while (vidas >0 && puntos < 100 && continuar == "s")
            {
                if (sis < 2)
                {
                    Console.WriteLine("¿Desea usar un dado especial? s/n: ");
                    ActDadoEsp = Console.ReadLine();
                    if (ActDadoEsp == "s")
                    {
                        dado = aleatorio.Next(1, 13);
                        sis++;
                        dadoEsp--;
                    }
                }
                
                else
                dado = aleatorio.Next(1, 7);
                puntos += dado;
                if (dado == 1)
                {
                    contador1s ++;
                }
                if (contador1s == 2)
                {
                    vidas -= 1;
                    puntos -= 10;
                    contador1s = 0;
                }
                if (dado == 6)
                {
                    consecutivo ++;
                }
                else consecutivo = 0;
                if (consecutivo == 2)
                {
                    vidas += 1;
                    if (vidas > 3) vidas = 3;
                    consecutivo = 0;
                }
                Console.WriteLine("Dado: " + dado + "\nPuntos Totales: " + puntos + "  Vidas: " + vidas + "  Dados especiales: "+dadoEsp);
                if( puntos >= 100) Console.WriteLine("V I C T O R I A");
                else if (vidas == 0) Console.WriteLine("G A M E   O V E R");
                else
                Console.WriteLine("¿Desea continuar?s/n: ");
                continuar = Console.ReadLine();
                
            }
            if (continuar == "n") Console.WriteLine("¿T E  V A S  T A N  P R O N T O? :c ");
        }
    }
}
