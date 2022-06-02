// Задача 62: Заполните спирально массив 4 на 4.
int[,] array = new int[4, 4];
FillArray(array.GetLength(0), array.GetLength(1), array);
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
void FillArray(int lastRow, int lastCol, int[,] array)
{
    int value = 1;
    int firstRow = 0;
    int firstCol = 0;

    while (firstRow < lastRow && firstCol < lastCol)
    {
        for (int i = firstCol; i < lastCol; ++i)
        {
            array[firstRow, i] = value++;
        }
        firstRow++;
        for (int i = firstRow; i < lastRow; ++i)
        {
            array[i, lastCol - 1] = value++;
        }
        lastCol--;

        if (firstRow < lastRow)
        {
            for (int i = lastCol - 1; i >= firstCol; --i)
            {
                array[lastRow - 1, i] = value++;
            }
        }

        lastRow--;

        if (firstCol < lastCol)
        {
            for (int i = lastRow - 1; i >= firstRow; --i)
            {
                array[i, firstCol] = value++;
            }
        }

        firstCol++;
    }
    PrintArray(array);
}