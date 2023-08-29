// Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.

// int[,] array_A = GetArray(2, 2, 0, 9);
// int[,] array_B = GetArray(2, 2, 0, 9);

int[,] array_A = {
            { 2, 4 },
            { 3, 2 }
        };

int[,] array_B = {
            { 3, 4 },
            { 3, 3 }
        };

int[,] resultMatrix = MultiplyResult(array_A, array_B);

Console.WriteLine("Your 2 random arrays: ");
Console.WriteLine();
PrintArray(array_A);
Console.WriteLine();
PrintArray(array_B);

Console.WriteLine();
Console.WriteLine("Result of multiply of this arrays: ");
Console.WriteLine();
PrintArray(resultMatrix);


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

int[,] MultiplyResult(int[,] matrixA, int[,] matrixB)
{
    int rowsA = matrixA.GetLength(0);
    int colsA = matrixA.GetLength(1);
    int colsB = matrixB.GetLength(1);

    int[,] result = new int[rowsA, colsB];

    for (int i = 0; i < rowsA; i++)
    {
        for (int j = 0; j < colsB; j++)
        {
            int sum = 0;
            for (int k = 0; k < colsA; k++)
            {
                sum += matrixA[i, k] * matrixB[k, j];
            }
            result[i, j] = sum;
        }
    }

    return result;
}