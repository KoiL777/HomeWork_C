// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; 

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 5}");
        }
        Console.WriteLine("  |");
    }
}

int SumRowArray(int[,] array2d)
{
  int[] sumArr = new int[array2d.GetLength(0)];
  Console.WriteLine($"Значения суммы в строках");
  for (int i = 0; i < array2d.GetLength(0); i++)
  {
    for (int j = 0; j < array2d.GetLength(1); j++)
    {
      sumArr[i] += array2d[i, j];
    }
    Console.WriteLine($"{i + 1} = {sumArr[i]}");
  }
  int minSum = sumArr[0];
  int minRow = 1;
  for (int i = 0; i < array2d.GetLength(0); i++)
  {
    if (sumArr[i] < minSum)
    {
      minSum = sumArr[i];
      minRow = i + 1;
    }
  }
  return minRow;
}

int[,] array2d = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2d);

int row = SumRowArray(array2d);
Console.WriteLine($"Наименьшая сумма элементов в {row} строке.");