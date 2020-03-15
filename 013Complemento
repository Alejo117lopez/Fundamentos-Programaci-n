using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complemento
{
    class Program
    {
        static void Main()
        {
            int[] A = { 0, 15, 12, 18, 6, 3, 12, 6, 9 };
            int[] B = { 4, 6, 2, 2, 0, 10, 12, 18, 16, 6, 14, 8 };
            int[] U = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };

            List<int> complemento = new List<int>();

            List<int> union = new List<int>();

            for (int i = 0; i < A.Length; i++) union.Add(A[i]);
            for (int i = 0; i < B.Length; i++) union.Add(B[i]);
            union.Sort();
            for(int i = 0; i< union.Count-1; i++)
            {
                if (union[i] == union[i + 1])
                {
                    union.RemoveAt(i);
                    i = 0;
                }
            }
            //for (int i = 0; i < union.Count; i++) Console.WriteLine(union[i]);
            //----------------------------------------------------------------------------------------------------------------------------------
            
            int x = 0;
            int r = 0;

            
            while (x < U.Length)
            {
                for (int j = 0; j < union.Count; j++)
                {
                    if (union[j] == U[x]) r++;
                }

                if (r == 0) complemento.Add(U[x]); 
                   
                x++;
            r = 0;
            }
            
            for (int i = 0; i < complemento.Count; i++) Console.WriteLine(complemento[i]);

        }
    }
}
