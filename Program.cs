using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Union
{
    class Program
    {
        static void Main()
        {
            int[] A = { 0, 15, 12, 18, 6, 3, 12, 6, 9 };
            int[] B = { 4, 6, 2, 2, 0, 10, 12, 18, 16, 6, 14, 8 };

            List<int> union = new List<int>();

            for (int i = 0; i<A.Length; i++) union.Add(A[i]);
           
            for (int i = 0; i < B.Length; i++) union.Add(B[i]);

            union.Sort();

            for (int i = 0; i < union.Count-1;i++)
            {
                if (union[i] == union[i + 1]) {

                    union.RemoveAt(i);
                    i = 0;
                }
            }

            for (int i = 0; i < union.Count; i++)
            {
                Console.Write(union[i] + " - ");
            }
            
        }
    }
}
