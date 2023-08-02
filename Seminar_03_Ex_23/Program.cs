// Задача 23
//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

static int InputNum()
{
    while (true)
    {
        try
        {
            Console.WriteLine("Enter a number > 0: ");
            int num = int.Parse(Console.ReadLine() ?? "");
            if (num < 1)
            {
                Console.WriteLine("Invalid input! Please enter a number that > 0.");
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

static double PowNumb(int x)
{
    return Math.Pow(x, 3);
}

static void ResultMessage ()
{
    double num = InputNum();
    int i = 1;
    while (i <= num)
    {
        if (i == num)
        {
            Console.Write($"{PowNumb(i)}");
        }
        else Console.Write($"{PowNumb(i)}, ");
        i++;
    }
}

ResultMessage ();