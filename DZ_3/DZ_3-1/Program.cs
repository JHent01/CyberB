


Random random = new Random();

int[] array = new int[100];

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(100);
}

int  average, sum=0, min = array[0],max =0;
for (var i = 0; i < array.Length; i++)
{
    if (min > array[i])
    {
        min = array[i];
    }
}

foreach (var element in array)
{
    if (max < element)
    {
        max = element;
    }
}



for (int i=0; i<array.Length;i++)
{ 
    sum += array[i];
}
average = sum / array.Length;
for (var i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
Console.WriteLine("Всі непарні числа :");

for (int i = 0; i<array.Length;i++)
{
    if (array[i]%2!=0)
    {
        Console.Write(array[i]+",");
    }
}

Console.WriteLine($"\nНайменше число : {min}. Найбільше число : {max}");
Console.WriteLine($"Сумма всіх чисел : {sum}. Середнє арифметичне : {average}");