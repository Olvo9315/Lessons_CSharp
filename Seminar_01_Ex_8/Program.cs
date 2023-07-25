//Семинар 1 - Задача 8
Console.WriteLine("Give me a number: ");
int N = int.Parse(Console.ReadLine() ?? "");
int i = 2;
if (N < 1)
{
    Console.WriteLine("Number must be > 0");
}
else
{
    while (i <= N)
    {
        Console.Write($"{i} ");
        i += 2;
    }
}
