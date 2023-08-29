// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента

Console.Write("Enter nº of planes: ");
int dim1 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Enter nº of rows: ");
int dim2 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Enter nº of columns: ");
int dim3 = int.Parse(Console.ReadLine() ?? "");

if (dim1 * dim2 * dim3 < 89)
{
    int[,,] array = GetArray(dim1, dim2, dim3);

    Console.WriteLine();

    Console.WriteLine("Your array: ");
    PrintArray(array);
}
else
{
    Console.WriteLine("Dimentions out of range. Try another dimentions");
}

int[,,] GetArray(int m, int n, int p)
{
    int num = 10;
    int[,,] result = new int[m, n, p];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < p; k++)
            {
                result[i, j, k] = num;
                num++;
            }
        }
    }
    return result;
}

void PrintArray(int[,,] array)
{
    int dim1 = array.GetLength(0);
    int dim2 = array.GetLength(1);
    int dim3 = array.GetLength(2);

    for (int i = 0; i < dim1; i++)
    {
        Console.WriteLine($"Plane {i + 1}:");
        for (int j = 0; j < dim2; j++)
        {
            for (int k = 0; k < dim3; k++)
            {
                Console.Write($"[{i},{j},{k}] = {array[i, j, k]}   ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
