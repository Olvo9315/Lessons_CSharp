//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

int TextInput ()
{
    while(true)
    {
        System.Console.Write("Give me a number from 100 to 999: ");
        int number = int.Parse(Console.ReadLine() ?? "");
        if (number >= 100 && number <= 999)
        {
            return number;
        }
        else
        {
            Console.WriteLine($"{number} is not in [100:999]!");
        }
    }
}

int secondNumber = TextInput() / 10 % 10;
Console.WriteLine($"Second number: {secondNumber}");