using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadranglesLibrary
{
    class Rectangle : ConvexQuadrilateral
    {
        public void AnglesRectangle()
        {
            angle[1] = angle[2] = angle[3] = angle[4] = Math.Acos((Math.Pow(str[1], 2) + Math.Pow(str[2], 2) - Math.Pow(diag[1], 2)) / (2 * str[1] * str[2])) * 180 / Math.PI;
            Console.WriteLine("All angels = {0:f2}", angle[1]);
        }
        public void AreaRectangle()
        {
            S = str[1] * str[2];
            Console.WriteLine("Area = {0:f2}", S);
        }
        public Rectangle()
        {
            Console.WriteLine("This is Rectangle");
        }
    }
}
