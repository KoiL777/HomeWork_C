// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



Console.Write("Введите число А: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите положительное число B: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int mult = Mult(num1, num2);
Console.WriteLine($"Число {num1} в степени {num2} = {mult}");

int Mult(int numA, int numB)
{
    int result = 1;
    for (int i = 0; i < numB; i++)
    {
        result *= numA;

    }
    return result;
}