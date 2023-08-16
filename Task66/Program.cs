// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите натуральное число N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число M:");
int m = Convert.ToInt32(Console.ReadLine());

if (n < 0 || m < 0)
{
    Console.WriteLine("Ошибка! Не корректное число!");
    return;
}
int NumbersRange(int n, int m)
{

    if (n == m) return n;
    if (n > m) return NumbersRange(n - 1, m) + n;
    else return NumbersRange(n + 1, m) + n;

}
Console.WriteLine($"Сумма чисел диапозона от {n} до {m} равна {NumbersRange(n, m)}");