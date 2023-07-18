// Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25; b = 5 -> да
// a = 10; b = 2 -> нет
// a = -3; b = 9 -> нет
// a = 9; b = -3 -> да

Console.WriteLine("Введите число 1:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2:");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2)
{
    Console.WriteLine($"Число {number2} является квадратом числа {number1}");
}
else
{
    Console.WriteLine($"Число {number2} не является квадратом числа {number1}");
}

