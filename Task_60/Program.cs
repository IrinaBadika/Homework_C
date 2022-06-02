// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int x = 4;
int y = 4;
int z = 3;
int count = 10;
int[,,] array = new int[z, x, y];
void FillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[i, j, z] = count;
                count++;
            }
        }
    }

}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine("№: " + (i + 1));

        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
                Console.Write($"{array[i, j, z]} [{i}, {j}, {z}] ");
            Console.WriteLine();
        }
        Console.WriteLine(" ");
    }
}
FillArray(array);
PrintArray(array);