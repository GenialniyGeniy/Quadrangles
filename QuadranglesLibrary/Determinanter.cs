using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadranglesLibrary
{
    public class Determinanter : ConvexQuadrilateral
    {
        public void Determinanter01()
        {
            string TypeOfFigure;
            if (str[1] == str[2] && str[2] == str[3] && str[3] == str[4])
            {
                if (diag[1] != diag[2])
                    TypeOfFigure = "Romb";
                else
                    TypeOfFigure = "Square";
            }
            else if (str[1] == str[3] && str[2] == str[4] && str[2] != str[3])
            {
                if (diag[1] != diag[2])
                    TypeOfFigure = "Parallelogram";
                else
                    TypeOfFigure = "Rectangle";
            }
            else TypeOfFigure = "Quadrangle";
            if (TypeOfFigure == "Square")
            {
                Square FigureSquare = new Square();
                FigureSquare.AnglesSquare();
                FigureSquare.AreaSquare();
                FigureSquare.Perimetr();
                FigureSquare.Diagonals();
            }
            else if (TypeOfFigure == "Romb")
            {
                Romb FigureRomb = new Romb();
                FigureRomb.AnglesRomb();
                FigureRomb.AreaRomb();
                FigureRomb.Perimetr();
                FigureRomb.Diagonals();
            }
            else if (TypeOfFigure == "Parallelogram")
            {
                Parallelogram FigureParallelogram = new Parallelogram();
                FigureParallelogram.AngelsParallelogram();
                FigureParallelogram.AreaParallelogram();
                FigureParallelogram.Perimetr();
                FigureParallelogram.Diagonals();
            }
            else if (TypeOfFigure == "Rectangle")
            {
                Rectangle FigureRectangle = new Rectangle();
                FigureRectangle.AnglesRectangle();
                FigureRectangle.AreaRectangle();
                FigureRectangle.Perimetr();
                FigureRectangle.Diagonals();
            }
            else
            {
                ConvexQuadrilateral FigureQuadrangles = new ConvexQuadrilateral();
                FigureQuadrangles.Convex();
                FigureQuadrangles.Angles();
                FigureQuadrangles.Area();
                FigureQuadrangles.Perimetr();
                FigureQuadrangles.Diagonals();
            }
        }
    }
}
