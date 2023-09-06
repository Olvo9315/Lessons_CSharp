// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.Write("Enter M: ");
int m_num = int.Parse(Console.ReadLine() ?? "");

Console.Write("Enter N: ");
int n_num = int.Parse(Console.ReadLine() ?? "");

if (m_num >= 0 && n_num >= 0)
{
    int result = Ackermann(m_num, n_num);

    Console.WriteLine($"A({m_num}, {n_num}) = {result}");
}
else Console.WriteLine("Incorrect M or N number");


int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
    else
    {
        throw new ArgumentException("Incorrect M or N number");
    }
}