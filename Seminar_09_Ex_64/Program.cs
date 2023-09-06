// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

Console.Write("Enter N: ");
int num = int.Parse(Console.ReadLine() ?? "");

string n_nums = GetNums(num, 1);

Console.WriteLine(n_nums);

string GetNums(int num, int last_n)
{
    if (last_n == num) return num.ToString();
    return num + " " + GetNums(num - 1, last_n);
}