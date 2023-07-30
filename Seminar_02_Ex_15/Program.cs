// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

int TextInput ()
{
    while(true)
    {
        System.Console.Write("Give me a number of the day (1-7): ");
        int number = int.Parse(Console.ReadLine() ?? "");
        if (number <= 7 && number > 0)
        {
            return number;
        }
        else
        {
            Console.WriteLine($"{number} is not a day!");
        }
    }
}

if (TextInput() > 5)
{
    Console.WriteLine("Yeaaah, it's a weekend!");
}
else
{
    Console.WriteLine("Oh, it's not a weekend :(");
}