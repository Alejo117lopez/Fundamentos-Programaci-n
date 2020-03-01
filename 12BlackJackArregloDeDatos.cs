using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackArregloDeDatos
{
class Program
{
static void Main()
{
            // -----------------CAPCHAT PARA VERIFICAR EL USUARIO----------------------------
            Random aleatorio1 = new Random();

            int oportunidades = 0, a, b, suma = 0, sumaCorrecta = 1;

            while (oportunidades < 3 && suma != sumaCorrecta)
            {
                a = aleatorio1.Next(0, 10);
                b = aleatorio1.Next(0, 10);
                oportunidades++;
                sumaCorrecta = a + b;

                Console.WriteLine(" a = " + a + " b = " + b);
                Console.WriteLine("¿Cuánto es a+b = ");
                suma = int.Parse(Console.ReadLine());

                if (suma != sumaCorrecta && oportunidades < 3)
                {
                    Console.WriteLine("Ups, al parecer te haz equivocado, vuelve a intentarlo ._. ");
                }


            }
            // ---------- CIERRA EL PROGRAMA SI ERES UN ROBOT -----------------------------------------
            if (suma != sumaCorrecta && oportunidades == 3)
            {
                Console.WriteLine("Me temo que eres un Robot más...No vuelvas por aquí >:v ");
            }
            // De lo contrario, es decir, cuando resuelve correctamente el capchat if(suma ==sumaCorrecta)

            //     ----------------ENTRADA AL JUEGO --------------------------
            else
            {


                Console.WriteLine("Bienvenido al Juego :D");

                //  --------------------------VALIDACIÓN DE CANTIDAD DE JUGADORES----------------------
                Console.WriteLine("Ingrese el número de jugadores (entre 2 y 5): ");
                int n = int.Parse(Console.ReadLine());
                while (n < 2 || n > 5) // Si se cumple una de las dos faltas se pide al usuario ingrsar de nuevo el número
                {
                    Console.WriteLine("Deben haber entre 2 y 5 jugadores: ");
                    n = int.Parse(Console.ReadLine());
                }

                // -------------------------- INICIO DEL JUEGO ---------------------------------------------
                // ----------------------------------------------------VARIABLES----------------------------------------
                bool r1 = (n >= 2 && n <= 5); // Regla 1, Número de Jugadores entre 2 y 5
                int jugador = 0, maximo = 0, segundo = 0, tercero; // Las variables de máximos van FUERA del WHILE para que no se altere su valor al ingresar de nuevo al bucle
                string NombreMaximo = "x", nombreSegundo = "e";
                string[] nombres = new string[n];
                int[] puntos = new int[n];
                
                // ---------------------------------TURNO DE CADA JUGADOR ------------------------------------------------
                while (jugador < n) // El while contará n turnos, también puede ser un for
                {
                    for (int i = 0; i < nombres.Length; i++) // El for inmediatamente después del while para almacenar los nombres
                    {
                        Random aleatorio = new Random();
                        int carta = 0, carta2, carta3 = 0, total = 0;
                        string continuar = "s";
                        Console.WriteLine("Jugador " + (jugador + 1) + " Ingrese su nombre: ");
                        string nombre = Console.ReadLine();     // Aquí se almacena el nombre en esa posición
                        nombres[i] = nombre;
                        Console.WriteLine("\nTurno del Jugador: " + nombre);

                        // ------------------------------GAME PLAY Y SUS CONDICIONES-----------------------------

                        while (continuar == "s" && total < 21 && r1)
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
                                Console.WriteLine("\n¿Deseas continuar?(s/n): ");
                                continuar = Console.ReadLine();
                                while (continuar != "s" && continuar != "n") //Validación de respuestas --> obliga al usuario a presionar (S o N) para continuar
                                                                             //Este while va debajo de la pregunta, "el orden altera el resultado"
                                {
                                    Console.WriteLine("Esta opción no está disponible, presiona s/n: ");
                                    continuar = Console.ReadLine();
                                }

                                if (continuar == "n")
                                {
                                    Console.WriteLine("\nTe has retirado :O");
                                    Console.WriteLine("Puntuación Final: " + total);

                                }
                                if (continuar == "s")
                                {
                                    carta3 = aleatorio.Next(1, 11);
                                    Console.WriteLine("Carta: " + carta3);
                                    total += carta3;
                                    Console.WriteLine("Puntos totales: " + total);
                                }

                            }
                            if (total > 21)
                            {

                                Console.WriteLine(" \nP E R D I S T E");
                                Console.WriteLine("Tus Puntos Han Superado 21. ");

                            }

                            if (total == 21)
                            {
                                Console.WriteLine("\nF E L I C I D A D E S, Tienes un 21 ");

                            }
                            
                            if (total > maximo && total <= 21) //Se asigna el puntaje máximo con su respectivo nombre (Como en el trabajo de las edades)
                                                               //Para que esta condición se dé, el total debe ser menor o igual a 21, ya que si saca más, perdería
                            {
                                maximo = total;
                                NombreMaximo = nombre;
                            }

                            puntos[i] = total; // Se almacena la cantidad de puntos finales (luego de haber pasado por todos los if) y sigue el turno del
                                               // otro jugador
                        }

                        jugador++;
                    }
                }
                //---------------------- ------------- Fin del Juego -------------------------------------
                
                // -------------------------------EL SEGUNDO LUGAR-----------------------------------------------
                for (int i =0; i< puntos.Length; i++)
                {
                    if (puntos[i] < maximo) {

                        tercero = puntos[i];
                        if (puntos[i] > segundo)
                        {
                            segundo = puntos[i];
                            nombreSegundo = nombres[i];
                        }
                    }
                }
                //--------------------- SE MUESTRAN LOS RESULTADOS INDIVIDUALES DE CADA JUGADOR CON SUS RESPECTIVOS PUNTOS---------------------------
                for (int i = 0; i < nombres.Length; i++)
                {
                    Console.WriteLine(nombres[i] + "= " + puntos[i]);
                }
                //------------------------SE MUESTRAN EL PRIMER Y SEGUNDO LUGAR, LOS NOMBRES CON SUS RESPECTIVOS PUNTOS----------------------------
                Console.WriteLine("\n El ganador es: " + NombreMaximo + " con: " + maximo + " puntos");
                Console.WriteLine("El segundo lugar es: " + nombreSegundo + " con " + segundo + " puntos");
            }
        }
}
}
