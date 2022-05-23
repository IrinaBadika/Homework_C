// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] array = new int[4, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
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
Console.WriteLine();

Console.Write("Позиция m: ");
int position1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Позиция n: ");
int position2 = Convert.ToInt32(Console.ReadLine());

if(position1 == array.GetLength(0) + 1 || position2 == array.GetLength(1) + 1)
{
    Console.WriteLine("Выберите позиции в пределах массива :(");
}
else
{
    Console.WriteLine("Ваше число: " + array[position1 - 1, position2 - 1]);
}



