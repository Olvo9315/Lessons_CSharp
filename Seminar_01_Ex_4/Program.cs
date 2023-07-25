//Семинар 1 - Задача 4
Console.WriteLine("Give me a number A: ");
int numberA = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Give me a number B: ");
int numberB = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Give me a number C: ");
int numberC = int.Parse(Console.ReadLine() ?? "");
int maxAB = Math.Max(numberA, numberB);
int max = Math.Max(numberC, maxAB);
Console.WriteLine($"max = {max}");