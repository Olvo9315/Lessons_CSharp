Console.WriteLine("Give me a number A: ");
int numberA = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Give me a number B: ");
int numberB = int.Parse(Console.ReadLine() ?? "");
int sqrA = numberA * numberA;
int sqrB = numberB * numberB;
if (sqrA == numberB)
{
    Console.WriteLine($"{numberB} is SQR of {numberA}");
}
else if (sqrB == numberA)
{
    Console.WriteLine($"{numberA} is SQR of {numberB}");
}
else
{
    Console.WriteLine("No SQRs");
}