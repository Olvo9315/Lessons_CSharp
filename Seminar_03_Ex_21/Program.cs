//Задача 21
//Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве

static int InputNum(string arg)
{
    while (true)
    {
        try
        {
            int num = int.Parse(Console.ReadLine() ?? "");
            return num;
        }
        catch (Exception e)
        {
            Console.WriteLine($"Invalid input for {arg} coordinate! Please enter a number. {e.Message}");
        }
    }
}

static void DistanceMethod()
{
    Console.WriteLine("Enter Ax coordinate: ");
    int ax = InputNum("Ax");
    Console.WriteLine("Enter Ay coordinate: ");
    int ay = InputNum("Ay");
    Console.WriteLine("Enter Az coordinate: ");
    int az = InputNum("Az");
    Console.WriteLine("Enter Bx coordinate: ");
    int bx = InputNum("Bx");
    Console.WriteLine("Enter By coordinate: ");
    int by = InputNum("By");
    Console.WriteLine("Enter Bz coordinate: ");
    int bz = InputNum("Bz");
    double d = Math.Sqrt((bx-ax)*(bx-ax) + (by-ay)*(by-ay) + (bz-az)*(bz-az));
    Console.WriteLine($"Distance between A ({ax}, {ay}, {az}) and B ({bx}, {by}, {bz}) = {d}");
}

DistanceMethod();