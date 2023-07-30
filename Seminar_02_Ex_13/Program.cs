// Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет

int ThirdNumber ( int number )
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

Console.Write("Give me a number: ");
int number = Math.Abs(int.Parse(Console.ReadLine() ?? ""));

if (number < 100)
{
    Console.WriteLine("There is no 3ed number");
}
else
{
    Console.WriteLine($"Third number: {ThirdNumber(number)}");
}