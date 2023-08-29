// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] array = GetArray(4, 4);
PrintArray(array);

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    int num = 1;
    int last_m = m - 1;
    int last_n = n - 1;
    int min_m = 0;
    int min_n = 0;
    int row = 0;
    int col = 0;

    while (num <= m * n)
    {
        for (int i = col; i <= last_n; i++)
        {
            result[row, i] = num++;
        }
        min_m++;

        for (int i = row + 1; i <= last_m; i++)
        {
            result[i, last_n] = num++;
        }
        last_n--;

        for (int i = last_n; i >= min_n; i--)
        {
            result[last_m, i] = num++;
        }
        last_m--;

        for (int i = last_m; i >= min_m; i--)
        {
            result[i, min_n] = num++;
        }
        min_n++;
        row++;
        col++;
    }
    return result;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]:D2} ");
        }
        Console.WriteLine();
    }
}
