// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int temp = n;
while (temp > 1)
{
    Console.Write($"{temp}, ");
    temp = temp - 1;
}
if (temp == 1)
{
    Console.Write(temp + " ");
}
Console.WriteLine();