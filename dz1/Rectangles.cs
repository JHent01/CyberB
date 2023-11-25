using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1
{
    internal class Rectangles
    {

        public double side1;
        public double side2;
        public double Side1 { get; }
        public double Side2 { get; }
        public double Area { get; }

        public double Perimeter { get; }

        public Rectangles(double side1, double side2)

        {
            this.side1 = side1;
            this.side2 = side2;
            this.Area = AreaCalculator(side1, side2);
            this.Perimeter = PerimeterCalculator(side2, side1);

            

        }

       

        #region
        public double AreaCalculator(double side1, double side2)
        {
            return Math.Abs(side1 * side2);
        }
        public double PerimeterCalculator(double side1, double side2)
        {
            return Math.Abs(side1 * 2) + (side2 * 2);
        }
        #endregion

    }
}
