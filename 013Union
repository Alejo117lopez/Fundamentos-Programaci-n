using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace union
{
    class Program
    {
        static void Main()
        {
            int[] a = { 0, 15, 12, 18, 6, 3, 12, 6, 9 };
            int[] b = { 4, 6, 2, 2, 0, 10, 12, 18, 16, 6, 14, 8 };
            int[] ab = new int[a.Length + b.Length]; // Creo un arreglo con capacidad (a+b)

            for (int i =  0; i<a.Length; i++) // recorro los datos de A
            {
                ab[i] = a[i]; // voy agregando lo datos de A al arreglo AB
            }
            for (int i = 0; i < b.Length; i++)//recorro los datos de B
            {
                ab[a.Length+i] = b[i];//voy agregando los datos de B al arrglo AB desde la última posición de A (numero de datos de A)
            }

            Array.Sort(ab); // Se ordenan los datos de menor a Mayor

            int[] tmp = new int[ab.Length]; // Arreglo para almecenar los datos NO repetidos
            int contador = 0; // para saber el tamaño exacto del arreglo Unión
            for ( int i = 0; i< ab.Length - 1; i++)
            {
                if (ab[i] != ab[i + 1]) // Para eliminar los datos repetidos (==) y que solo quede uno.
                {
                    tmp[contador] = ab[i];
                    contador++; //Se va almacenando la cantidad de datos NO repetidos
                }
            }
            int[] union = new int[contador]; // Creo un Array "Unión" con el tamaño de "Contador"

            for (int i = 0; i< union.Length;i++)//recorro los campos de "Unión"
            {
                union[i] = tmp[i]; // Voy agregando a Union los datos de Tmp
            }

            for (int i = 0; i < union.Length; i++) Console.Write(union[i] + " , "); //se imprime cada uno de los datos
        }
    }
}
