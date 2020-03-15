using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersección
{
    class Program
    {
        static void Main()
        {
            int[] A = { 0, 15, 12, 18, 6, 3, 12, 6, 9 };
            int[] B = { 4, 6, 2, 2, 0, 10, 12, 18, 16, 6, 14, 8 };

            List<int> interseccion = new List<int>(); // Se crea una lista para almacenar la intersección

            for (int i = 0; i < A.Length; i++) // se recorren los datos de A
            {
                for (int j = 0; j < B.Length; j++) // Se recorren los datos de B ( analiza cada uno de sus datos en comparación con A, una vez
                                                   // los analiza todos A aumenta de posición y se repite el ciclo
                {
                    if (A[i] == B[j])
                    {
                        interseccion.Add(A[i]);
                    }
                }
            }

            interseccion.Sort(); // Ordenar de menor a mayor los datos en a lista

            for (int i = 0; i < interseccion.Count-1; i++) // analizo cada uno de los datos de la lista, (-1) x que se va a comparar con el ss
            {
                if (interseccion[i] == interseccion[i + 1]) // se compara si el dato es igual al siguiente
                {
                    interseccion.RemoveAt(i);              // si se da la condición, se elimina el dato repetido
                    i = 0;                                 // i vuelve a 0 para analizar de nuevo desde el inicio
                } 
            }         
            for (int i = 0; i < interseccion.Count; i++) //Se imprimen cada uno de los datos de la lista
            {
                Console.WriteLine(interseccion[i]);
            }
        }
    }
}
