// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Write("Enter nº of rows: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Enter nº of columns: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 9);

Console.WriteLine();

Console.WriteLine("Your random array: ");
PrintArray(array);

Console.WriteLine();

Console.WriteLine("Your sort rows array: ");
int[,] sorted_array = SortRowsArray(array);
PrintArray(sorted_array);

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

int[,] SortRowsArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(1) - j - 1; k++)
            {
                if (inArray[i, k] < inArray[i, k + 1])
                {
                    int temp = inArray[i, k];
                    inArray[i, k] = inArray[i, k + 1];
                    inArray[i, k + 1] = temp;
                }
            }
        }
    }
    return inArray;
}