// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

Console.WriteLine("Введите число: ");
int digit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: в которую хотите возвести число: ");
int exponent = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 0; i <= exponent; i++)
{
    result = result * digit;
}
Console.WriteLine($"Число {digit} в степени {exponent} = {result}");