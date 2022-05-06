// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
double[] arr = new double[5];
{
    for (int i = 0; i < arr.Length; i++)
    {
        Random rand = new Random();
        arr[i] = Math.Round(rand.NextDouble(), 1);
    }
}

void PrintArray(double[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void Difference(double[] array)
{
    double maxNumber = array[0];
    double minNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minNumber)
        {
            minNumber = array[i];
        }
        if (array[i] > maxNumber)
        {
            maxNumber = array[i];
        }
    }
    Console.WriteLine($"Минимальное число массива: {minNumber}");
    Console.WriteLine($"Максимальное число массива: {maxNumber}");
    double diff = maxNumber - minNumber;
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {diff}");
}
PrintArray(arr);
Difference(arr);