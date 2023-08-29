// Console.WriteLine("Give me a number A: ");
// int numberA = int.Parse(Console.ReadLine() ?? "");
// Console.WriteLine("Give me a number B: ");
// int numberB = int.Parse(Console.ReadLine() ?? "");
// int sqrA = numberA * numberA;
// int sqrB = numberB * numberB;
// if (sqrA == numberB)
// {
//     Console.WriteLine($"{numberB} is SQR of {numberA}");
// }
// else if (sqrB == numberA)
// {
//     Console.WriteLine($"{numberA} is SQR of {numberB}");
// }
// else
// {
//     Console.WriteLine("No SQRs");
// }

using System.Numerics;

int[,] pic = new int[25, 30];
int x = 0;
void PrintArray(int[,] mat)
{
    if (x == mat.GetLength(0)) return;
    if (x > 0) mat[x - 1, 1] = 0;
    mat[x, 1] = 1;

    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            if (mat[i, j] == 0) Console.Write($".");
            else Console.Write($"O");

        }
        Console.WriteLine();
    }
    x++;
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    PrintArray(mat);

}

PrintArray(pic);