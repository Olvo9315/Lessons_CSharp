// Задача 19
//Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.

static int InputNum()
{
    while (true)
    {
        try
        {
            Console.WriteLine("Enter a five-digit number: ");
            int num = int.Parse(Console.ReadLine() ?? "");
            if (num < 10000 || num > 99999)
            {
                Console.WriteLine("Invalid input! Please enter a five-digit number.");
            }
            else
            {
                return (num);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Invalid input! Please enter a number. {e.Message}");
        }
    }
}

static bool CheckDigits(int num)
{
    int firstDigit = num / 10000;
    int lastDigit = num % 10;
    int secondDigit = (num / 1000) % 10;
    int secondToLastDigit = (num / 10) % 10;
    return firstDigit == lastDigit && secondDigit == secondToLastDigit;
}

static void ResultMessage(int num)
{
    
    if (CheckDigits(num))
        {
            Console.WriteLine($"The number {num} is palindrome");
        }
        else
        {
            Console.WriteLine($"The number {num} is not palindrome");
        }
}
ResultMessage(InputNum());