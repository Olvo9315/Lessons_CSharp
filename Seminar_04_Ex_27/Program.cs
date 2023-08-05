// Задача 27: Напишите программу, 
//которая принимает на вход число и выдаёт сумму цифр в числе.

int num = GetNumberFromUser("Enter integer number A: ", "Invalid input! Please enter a number.");
int count = GetCountDigits(num);
Console.WriteLine($"{num} -> {count}");

int GetNumberFromUser(string messsage, string errorMessage)
{
    while (true)
    {
        Console.Write(messsage);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int GetCountDigits(int num)
{
    if (num < 0) num = num * -1;
    int count = 0;
    int sum = 0;
    while (num != 0)
    {
        sum += num % 10;
        num = num / 10;
        count++;
    }
    return sum;
}
