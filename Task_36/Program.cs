// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int[] arr = new int[5];
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arr);
 int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (i % 2 > 0)
    {
        sum = sum + arr[i];
        i++;
    }
}
  Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sum}");
 