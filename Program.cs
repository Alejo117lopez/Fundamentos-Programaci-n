using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglo_de_Datos
{
    class Program
    {
        static void Main()
        {                      //0  1  2  3
            double[] coordsX = { 0, 2, 3, 7 };
            double[] coordsY = { 0, 1, 5, 6 };
            
            // p1 = (0,0) -> p2 = (2,1) -> p3 = (3,5) -> p4 = (7,6)
            // Dp1p4 = Dp1p2 + Dp2p3 + Dp3p4 --> D = distancia

            double Dp1p2 = Math.Sqrt(((coordsX[0] - coordsX[1]) * (coordsX[0] - coordsX[1])) + (coordsY[0] - coordsY[1]));
            double Dp2p3 = Math.Sqrt(((coordsX[1] - coordsX[2]) * (coordsX[1] - coordsX[2])) + (coordsY[1] - coordsY[2]));
            double Dp3p4 = Math.Sqrt(((coordsX[2] - coordsX[3]) * (coordsX[2] - coordsX[3])) + (coordsY[2] - coordsY[3]));
            double Dp1p4 = Math.Sqrt(((coordsX[0] - coordsX[3]) * (coordsX[0] - coordsX[3])) + (coordsY[0] - coordsY[3]));

            bool Colineal = Dp1p4 == (Dp1p2 + Dp2p3 + Dp3p4);

            if (Colineal)
            {
                Console.WriteLine("Los puntos pertenecen a la misma recta");
                Console.WriteLine("La mayor distancia es: " + Dp1p4);
            }
            else Console.WriteLine("Los puntos no pertenecen a una misma recta");
            
            if (Dp1p2 > Dp2p3 && Dp1p2 > Dp3p4 && Dp1p2 > Dp1p4) Console.WriteLine("La Mayor distancia es " + Dp1p2);
            else if(Dp2p3 > Dp1p2 && Dp2p3 > Dp3p4 && Dp2p3 > Dp1p4) Console.WriteLine("La Mayor distancia es " + Dp2p3);
            else Console.WriteLine("La Mayor distancia es " + Dp3p4);
            
        }
    }
}
