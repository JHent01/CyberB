struct Train
{
    public string destination;
    public int namberTrain;
    public double time;
    
}



class Program
{
    static void Main(string[] args)
    {
        
        Train[] trains = new Train[8];
        for (int i = 0; i < trains.Length; i++)
        { 
            Console.WriteLine("Введіть куди відправляється потяг,час відправлення");
            trains[i].destination = Console.ReadLine();
            trains[i].namberTrain=i;
            trains[i].time = double.Parse(Console.ReadLine());
        }

        foreach (Train tra in trains) 
        {
            Console.WriteLine($"Місце призначення: {tra.destination}; Номер потяга: {tra.namberTrain}; Час відправки: {tra.time}");
            
        }

        Console.WriteLine("Введіть час відправлення який ви шукаєте ");
        double inTime= double.Parse(Console.ReadLine()); 

        foreach (Train tra in trains) 
        {
            if (tra.time > inTime)
            {
                Console.WriteLine($"Потяги які відправляються після {inTime}\nМісце призначення: {tra.destination}; Номер потяга: {tra.namberTrain}; Час відправки: {tra.time}");
                
            }
           
        }


    }
}