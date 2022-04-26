// Задача 19: Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void IsPalindrom()
{
    int a = number % 10;
    int b = number / 10000;

    int c = number % 10000 / 1000;
    int d = number % 100 / 10;
    if (a == b || c == d)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Заданное число не является палиндромом");
    }
}

IsPalindrom();




