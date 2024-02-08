using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3_3
{
    class Plane : Vehicle
    {
        private double altitude;
        private int passengers;

        public Plane(double x, double y, double price, double speed, int year, double altitude, int passengers)
            : base(x, y, price, speed, year)
        {
            this.altitude = altitude;
            this.passengers = passengers;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Висота: {altitude} метрів");
            Console.WriteLine($"Кількість пасажирів: {passengers}");
        }
    }
}
