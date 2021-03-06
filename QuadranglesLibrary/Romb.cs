using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadranglesLibrary
{
    class Romb : ConvexQuadrilateral
    {
        public void AreaRomb()
        {
            S = (diag[1] * diag[2]) / 2;
            Console.WriteLine("Area = {0:f2}", S);
        }
        public void AnglesRomb()
        {
            angle[1] = angle[3] = Math.Acos((Math.Pow(str[1], 2) + Math.Pow(str[4], 2) - Math.Pow(diag[2], 2)) / (2 * str[1] * str[4])) * 180 / Math.PI;
            angle[2] = angle[4] = Math.Acos((Math.Pow(str[1], 2) + Math.Pow(str[2], 2) - Math.Pow(diag[1], 2)) / (2 * str[1] * str[2])) * 180 / Math.PI;
            Console.WriteLine("Angels = {0:f2}; {1:f2}; {2:f2}; {3:f2}", angle[1], angle[2], angle[3], angle[4]);
        }
        public Romb()
        {
            Console.WriteLine("This is Romb");
        }
    }
}
