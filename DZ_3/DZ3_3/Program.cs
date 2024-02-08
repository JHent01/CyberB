using DZ3_3;
Console.OutputEncoding = System.Text.Encoding.Unicode;

Vehicle[] vehicles = new Vehicle[3];
vehicles[0] = new Plane(10, 20, 100000, 900, 2020, 10000, 200);
vehicles[1] = new Car(30, 40, 5000, 250, 2018, "Toyota Camry");
vehicles[2] = new Ship(50, 60, 20000, 60, 2015, 50, "New York");

foreach (Vehicle vehicle in vehicles)
{
    vehicle.ShowInfo();
    Console.WriteLine();
}