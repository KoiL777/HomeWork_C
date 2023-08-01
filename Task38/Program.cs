// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];

    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}


double MinMaxArrayDouble(double[] arr)
{
    double min = 0;
    double max = 0;
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) { max = arr[i]; }
        if (arr[i] < min) { min = arr[i]; }
        count++;
    }
    double result = max - min;
    return result;

}

double[] array = CreateArrayRndDouble(5, -10, 10);
PrintArrayDouble(array);

double minMaxArrayDouble = MinMaxArrayDouble(array);
Console.WriteLine($"Разница между минимальным и максимальным методом равна : {minMaxArrayDouble}");