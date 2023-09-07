// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Enter M: ");
int m_num = int.Parse(Console.ReadLine() ?? "");

Console.Write("Enter N: ");
int n_num = int.Parse(Console.ReadLine() ?? "");

if (m_num > n_num)
{
    int tmp = m_num;
    m_num = n_num;
    n_num = tmp;
}
if (m_num == n_num) Console.WriteLine("There are not nums between M and N");
else{
int sum_nums = GetSum(m_num, n_num);
Console.WriteLine(sum_nums);
}

int GetSum(int first_n, int last_n)
{
    if (first_n == last_n) return last_n;
    return first_n + GetSum(first_n + 1, last_n);
}