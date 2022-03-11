using System;
using QuadranglesLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadrangles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConvexQuadrilateral LoS = new ConvexQuadrilateral();
            ConvexQuadrilateral.LenghtOfSides();
            Determinanter determinanter = new Determinanter();
            determinanter.Determinanter01();
            Console.ReadKey();
        }
    }
}
