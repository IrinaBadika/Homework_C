// Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

double xA = Coords("x1", "A");
double yA = Coords("y1", "A");
double zA = Coords("z1", "A");
double xB = Coords("x2", "A");
double yB = Coords("y2", "A");
double zB = Coords("z2", "A");

double Coords(string CoorName, string PointName)
{
    Console.WriteLine($"Введите координаты {PointName} точки {CoorName}: ");
    return Convert.ToInt32(Console.ReadLine());
}

void Distance()
{
    double sum = 0;
    sum = ((xA - xB) * (xA - xB)) + ((yA - yB) * (yA - yB)) + ((zA - zB) * (zA - zB));
    double result = Math.Sqrt(sum);
    Console.WriteLine($"Координаты точки А: ({xA}, {yA}, {zA}).");
    Console.WriteLine($"Координаты точки B: ({xB}, {yB}, {zB}).");
    Console.WriteLine($"Расстояние между точками: {result}");
}

Distance();





