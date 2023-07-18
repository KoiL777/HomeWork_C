// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет





Console.WriteLine("Введите цифру, обозначающую день недели:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0 && number < 8)
{
    bool num = IsDay(number);
    Console.WriteLine(num ? "Да" : "Нет");
    bool IsDay(int num)
    {
        return number > 5 && number < 8;
    }
}
else
{
    Console.WriteLine("Ошибка! Введено некорректное число");
}