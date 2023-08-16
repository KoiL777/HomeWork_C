// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите натуральное число N");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNums(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NaturalNums(num - 1);
}

bool VerifyNum(int number)
{
    return number > 0;
}

if (!VerifyNum(number))
{
    Console.WriteLine("Ошибка! Введено не натуральное число N");
    return;
}

NaturalNums(number);