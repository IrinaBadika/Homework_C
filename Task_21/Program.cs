// Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты точки А: ");
double x1 = Convert.ToInt32(Console.ReadLine());
double y1 = Convert.ToInt32(Console.ReadLine());
double z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
double x2 = Convert.ToInt32(Console.ReadLine());
double y2 = Convert.ToInt32(Console.ReadLine());
double z2 = Convert.ToInt32(Console.ReadLine());

void Distance()
{
    double sum = 0;
    sum = ((x1 - x2)*(x1 - x2)) + ((y1 - y2)*(y1 - y2)) + ((z1 - z2)*(z1 - z2));
 double result = Math.Sqrt(sum);
 Console.WriteLine($"Координаты точки А: ({x1}, {y1}, {z1}).");
 Console.WriteLine($"Координаты точки B: ({x2}, {y2}, {z2}).");
 Console.WriteLine($"Расстояние между точками: {result}");
}

Distance();





