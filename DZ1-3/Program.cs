using DZ1_3;


    Console.OutputEncoding = System.Text.Encoding.Unicode;
    Figure rectangle = new Figure(
    new Point(2, 3, "A"),
    new Point(5, 3, "B"),
    new Point(5, 8, "C"),
    new Point(2, 8, "D"), "Прямокутник");

    Console.WriteLine($"Периметр для фігури {rectangle.Name} = {rectangle.PerimeterCalculator()}");

