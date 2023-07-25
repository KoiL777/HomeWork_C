// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите любое пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = number * -1;
}
if (number > 9999 && number < 100000)
{

    bool numFive = NumFive(number);
    Console.WriteLine(numFive ? "Да" : "Нет");
    bool NumFive(int num)
    {
        int Digit1 = num / 10000;
        int Digit2 = num % 10000 / 1000;
        int Digit3 = num % 100 / 10;
        int Digit4 = num % 100 % 10;
        return Digit1 == Digit4 && Digit2 == Digit3;
    }
}

else
{
    Console.WriteLine("Введеное число не пятизначное");
}