using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3_3
{
    class Ship : Vehicle
    {
        private int passengers;
        private string port;

        public Ship(double x, double y, double price, double speed, int year, int passengers, string port)
            : base(x, y, price, speed, year)
        {
            this.passengers = passengers;
            this.port = port;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Кількість пасажирів: {passengers}");
            Console.WriteLine($"Порт: {port}");
        }
    }
}
