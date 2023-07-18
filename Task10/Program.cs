// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите любое трёхзначное число:");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99 & num < 1000)
{
    int res = RemoveSecondDigit(num);
Console.WriteLine($"Ответ: {res}");

int RemoveSecondDigit(int num)
{
    int position1 = num/10;
    int position2 = position1 % 10;
    return position2;
}
}
else {
Console.WriteLine("Ошибка! Данное число не является трёхзначным");}