//Семинар 1 - Задача 2
Console.WriteLine("Give me a number A: ");
int numberA = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Give me a number B: ");
int numberB = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine($"A = {numberA}; B = {numberB} -> max = " + Math.Max(numberA, numberB));

//or with if-else: 
// if (numberB > numberA)
// {
//    Console.WriteLine($"A = {numberA}; B = {numberB} -> max = {numberB}");
// }
// else
// {
//    Console.WriteLine($"A = {numberA}; B = {numberB} -> max = {numberA}");
// }
