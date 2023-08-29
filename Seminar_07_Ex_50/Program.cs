// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Enter nº of rows: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Enter nº of columns: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 10);

Console.WriteLine("Your random array: ");
PrintArray(array);

Console.Write("Enter nº of row you want to check: ");
int in_row = int.Parse(Console.ReadLine() ?? "");

Console.Write("Enter nº of column you want to check: ");
int in_column = int.Parse(Console.ReadLine() ?? "");

PrintElementCheck(in_row, in_column, array);

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

void PrintElementCheck(int m, int n, int[,] inArray)
{
    if (m > inArray.GetLength(0))
    {
        Console.WriteLine("Out of range, select another row number");
    }
    else if (n > inArray.GetLength(1))
    {
        Console.WriteLine("Out of range, select another column number");
    }
    else
    {
        Console.WriteLine($"{inArray[m,n]}");
    }
}