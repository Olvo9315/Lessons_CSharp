// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Enter nº of rows: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Enter nº of columns: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 10);

Console.WriteLine();

Console.WriteLine("Your random array: ");
PrintArray(array);

Console.WriteLine();
PrintAverage(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintAverage(int[,] inArray)
{
    Console.Write("The average of each columns: ");
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        double mean = 0;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            mean = mean + (inArray[i, j]);
        }
        if (j == inArray.GetLength(1) - 1)
        {
            Console.Write($"{mean/inArray.GetLength(0):F2}.");
        }
        else
        {
            Console.Write($"{mean/inArray.GetLength(0):F2}; ");
        }
    }
}