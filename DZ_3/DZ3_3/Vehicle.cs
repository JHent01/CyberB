using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3_3
{
    internal class Vehicle
    {
       
            protected double[] coordinates = new double[2];
            protected double price;
            protected double speed;
            protected int year;

            public Vehicle(double x, double y, double price, double speed, int year)
            {
                coordinates[0] = x;
                coordinates[1] = y;
                this.price = price;
                this.speed = speed;
                this.year = year;
            }

            public virtual void ShowInfo()
            {
            Console.WriteLine($"Інформація:");
                Console.WriteLine($"Координати: ({coordinates[0]}, {coordinates[1]})");
                Console.WriteLine($"Ціна: {price}$");
                Console.WriteLine($"Швидкість: {speed} Км/г");
                Console.WriteLine($"Рік: {year}");
            }
    }

    
}
