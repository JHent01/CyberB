using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1_3
{
    internal class Figure
    {

        Point[] points;
        string name;
        public string Name { get; }

        public Figure(Point point1, Point point2, Point point3, string name)
        {
            this.Name = name;
            points = new Point[3];
            points[0] = point1;
            points[1] = point2;
            points[2] = point3;
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, string name)
        {
            this.Name = name;
            points = new Point[4];
            points[0] = point1;
            points[1] = point2;
            points[2] = point3;
            points[3] = point4;
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5, string name)
        {
            this.Name = name;
            points = new Point[5];
            points[0] = point1;
            points[1] = point2;
            points[2] = point3;
            points[3] = point4;
            points[4] = point5;
        }

        private double LengthSide(Point A, Point B)
        {
            return (double)Math.Sqrt(Math.Pow((A.X - B.X), 2) + Math.Pow((A.Y - B.Y), 2));
        }

        public double PerimeterCalculator()
        {
            double perimeter = LengthSide(points[0], points[points.Length - 1]);

            for (int i = 0; i < points.Length - 1; i++)
            {
                perimeter += LengthSide(points[i], points[i + 1]);
            }
            return perimeter;

        }
    }
}
