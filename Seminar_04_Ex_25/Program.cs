// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

int num_a = GetNumberFromUser("Enter integer number A: ", "Invalid input for number A! Please enter a number.");
int num_b = GetNumberFromUser("Enter integer number B: ", "Invalid input for number B! Please enter a number.");
GetResult(num_a, num_b);

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

static void GetResult (int num_a, int num_b)
{
    if (num_b > 0)
    {
        int result = 1;
        for (int i = 1; i <= num_b; i++)
        {
            result = result * num_a;
        }
        Console.WriteLine($"{num_a}^{num_b} = {result}");
    }
    else if (num_b < 0)
    {
        double result = 1;
        int abs_b = Math.Abs(num_b);
        for (int i = 1; i <= abs_b; i++)
        {
            result = result * num_a;
        }
        result = 1 / result;
        Console.WriteLine($"{num_a}^{num_b} = {result}");
    }
    else
    {
        int result = 1;
        Console.WriteLine($"{num_a}^{num_b} = {result}");
    }
}