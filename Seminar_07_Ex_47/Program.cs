// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

Console.Write("Enter nº of rows: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Enter nº of columns: ");
int columns = int.Parse(Console.ReadLine() ?? "");

double[,] array = GetArray(rows, columns, -10, 10);

PrintArray(array);

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]:F2} ");
        }
        Console.WriteLine();
    }
}