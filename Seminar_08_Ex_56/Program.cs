// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Write("Enter nº of rows: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Enter nº of columns: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 9);

Console.WriteLine();

Console.WriteLine("Your random array: ");
PrintArray(array);


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
    int min_index = -1;
    int min_sum = int.MaxValue;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum += inArray[i, j];
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
        if (sum < min_sum)
        {
            min_sum = sum;
            min_index = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"{min_index + 1} line is the row with the smallest sum ({min_sum}) of elements");
}

