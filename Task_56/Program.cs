// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int m = 4;
int n = 4;
int[,] array = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(1, 10);
    }
}
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine(" ");
}
Console.WriteLine(" ");
int sum = 0;
int index = 0;
int min = 0;
for (int i = 0; i < m; i++)
{
    sum = 0;
    for (int j = 0; j < n; j++)
    {

        sum = sum + array[i, j];
    }
    Console.WriteLine($"Сумма элементов строки {i + 1} = {sum}");
    if (i == 0)
    {
        min = sum;
    }
    else if (sum < min)
    {
        min = sum;
        index = i;
    }
}
Console.WriteLine($"Наименьшая сумма элементов находится в строке {index+1} = {min}");

