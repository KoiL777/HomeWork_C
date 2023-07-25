// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A: ");
Console.Write("x: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
Console.Write("x: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double coord = GetDistance(x1, y1, x2, y2, z1, z2);
double distRound = Math.Round(coord, 2, MidpointRounding.ToZero);
Console.Write("Расстояние между A и B равно: " + distRound);

double GetDistance(int a1, int a2, int a3, int b1, int b2, int b3)
{
    double catet_1 = b1 - a1;
    double catet_2 = b2 - a2;
    double catet_3 = b3 - a3;
    double distance = Math.Sqrt(catet_1 * catet_1 + catet_2 * catet_2 + catet_3 * catet_3);
    return distance;

}