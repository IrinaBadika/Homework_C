// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива
Console.Write("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int row = 0;
int column = 0;
int[,] array = new int[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10, 100);
    }
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

int min = array[0, 0];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] < min)
        {
            min = array[i, j];
            row = i;
            column = j;
        }
    }
}
Console.WriteLine();
Console.WriteLine("Наименьший элемент массива: " + min);
Console.WriteLine($"Находится на строке {row + 1}, в столбце {column + 1}");

int posX = 0;
int posY = 0;
int[,] newArray = new int[m - 1, n - 1];
for (int i = 0; i < newArray.GetLength(0); i++)
{
    if (posX == row)
    {
        posX++;
    }
    for (var j = 0; j < newArray.GetLength(1); j++)
    {
        if (posY == column)
        {
            posY++;
        }
        newArray[i, j] = array[posX, posY];
        posY++;
    }
    posY = 0;
    posX++;
}
Console.WriteLine();
for (int i = 0; i < newArray.GetLength(0); i++)
{
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        Console.Write(newArray[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();