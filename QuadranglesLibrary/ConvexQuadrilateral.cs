using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadranglesLibrary
{
    public class ConvexQuadrilateral
    {
        public static double[] x = new double[6];
        public static double[] y = new double[6];
        public static double[] str = new double[5];
        public static double[] diag = new double[3];
        public static double[] angle = new double[5];
        public static double P, S;
        public static void LenghtOfSides()
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("Enter coordinates of {0} vertex: ", i);
                Console.Write("x{0}=", i);
                x[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("y{0}=", i);
                y[i] = Convert.ToInt32(Console.ReadLine());
            }
            x[5] = x[1]; y[5] = y[1];
            for (int i = 1; i <= 4; i++)
            {
                str[i] = Math.Sqrt(Math.Pow((x[i + 1] - x[i]), 2) + Math.Pow((y[i + 1] - y[i]), 2));
                Console.WriteLine("Side ({0}) = {1:f2}", i, str[i]);
            }
            diag[1] = Math.Sqrt(Math.Pow((x[3] - x[1]), 2) + Math.Pow((y[3] - y[1]), 2));
            diag[2] = Math.Sqrt(Math.Pow((x[4] - x[2]), 2) + Math.Pow((y[4] - y[2]), 2));
        }
        public void Perimetr()
        {
            P = str[1] + str[2] + str[3] + str[4];
            Console.WriteLine("Perimetr = {0:f2}", P);
        }
        public void Diagonals()
        {
            diag[1] = Math.Sqrt(Math.Pow((x[3] - x[1]), 2) + Math.Pow((y[3] - y[1]), 2));
            diag[2] = Math.Sqrt(Math.Pow((x[4] - x[2]), 2) + Math.Pow((y[4] - y[2]), 2));
            Console.WriteLine("Diagonals = {0:f2}; {1:f2}", diag[1], diag[2]);
        }
        public void Angles()
        {
            angle[1] = Math.Acos((Math.Pow(str[1], 2) + Math.Pow(str[4], 2) - Math.Pow(diag[2], 2)) / (2 * str[1] * str[4])) * 180 / Math.PI;
            angle[2] = Math.Acos((Math.Pow(str[1], 2) + Math.Pow(str[2], 2) - Math.Pow(diag[1], 2)) / (2 * str[1] * str[2])) * 180 / Math.PI;
            angle[3] = Math.Acos((Math.Pow(str[2], 2) + Math.Pow(str[3], 2) - Math.Pow(diag[2], 2)) / (2 * str[2] * str[3])) * 180 / Math.PI;
            angle[4] = Math.Acos((Math.Pow(str[3], 2) + Math.Pow(str[4], 2) - Math.Pow(diag[1], 2)) / (2 * str[3] * str[4])) * 180 / Math.PI;
            Console.WriteLine("Angels = {0:f2}; {1:f2}; {2:f2}; {3:f2}", angle[1], angle[2], angle[3], angle[4]);
        }
        public void Area()
        {
            S = str[1] / 2 * str[4] * Math.Sin(angle[1]) + str[2] / 2 * str[3] * Math.Sin(angle[3]);
        }
        public void Convex()
        {
            Console.WriteLine("This is Convex Quadrilateral");
        }
    }
}
