
Console.OutputEncoding = System.Text.Encoding.Unicode;

int nam = 3; 


int[] array = new int[nam];
Random random = new Random();
for (int i = 0; i < nam; i++)
{
    array[i] = random.Next(1, 100); 
}


Console.WriteLine("Масив:");
foreach (int num in array)
{
    Console.Write(num + " ");
}
Console.WriteLine();


int max = array[0];
int min = array[0];
foreach (int num in array)
{
    if (num > max)
        max = num;
    if (num < min)
        min = num;
}
Console.WriteLine("Найбільше значення: " + max);
Console.WriteLine("Найменше значення: " + min);


int sum = 0;
foreach (int num in array)
{
    sum += num;
}
double average = (double)sum / nam;
Console.WriteLine("Загальна сума: " + sum);
Console.WriteLine("Середнє арифметичне: " + average);


Console.WriteLine("Непарні значення:");
foreach (int num in array)
{
    if (num % 2 != 0)
        Console.Write(num + " ");
}
Console.ReadKey();