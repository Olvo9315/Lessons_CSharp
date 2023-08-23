//  Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

double GetNumberFromUser(string messsage, string errorMessage)
{
    while (true)
    {
        Console.Write(messsage);
        bool isCorrect = double.TryParse(Console.ReadLine(), out double userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

void PrintLine(double[] line, string name_line)
{
    Console.Write($"{name_line}: [");
    for (int i = 0; i < line.Length; i++)
    {
        if (i == line.Length - 1)
        {
            Console.Write($"{line[i]}");
        }
        else
            Console.Write($"{line[i]} ");
    }
    Console.WriteLine($"]");
}


void MainPart()
{
    while (true)
    {
        double k1 = GetNumberFromUser("Enter k1 value: ", "Invalid input type! Please enter a number.");
        double b1 = GetNumberFromUser("Enter b1 value: ", "Invalid input type! Please enter a number.");
        double k2 = GetNumberFromUser("Enter k2 value: ", "Invalid input type! Please enter a number.");
        double b2 = GetNumberFromUser("Enter b2 value: ", "Invalid input type! Please enter a number.");

        if (k1 == k2 && b1 == b2)
        {
            Console.WriteLine("Identical lines, select different coefficients.");
        }
        else if (k1 == k2)
        {
            Console.WriteLine("The lines are parallel, select different coefficients.");
        }
        else
        {
            // Method 1: 

            double y = 0;
            double x = 0;


            x = (b1 - b2) / (k2 - k1);
            y = k1 * x + b1;

            Console.WriteLine($"Intersection point on (x = {x}; y = {y})");


            // Method 2: 

            double x1 = -1;
            int len = 20;
            double step = 0.1;
            double[] line1 = new double[len];
            double[] line2 = new double[len];
            double intersect_x = 0;
            double intersect_y = 0;

            for (int i = 0; i < len; i++)
            {
                line1[i] = Math.Round(k1 * x1 + b1, 2);
                line2[i] = Math.Round(k2 * x1 + b2, 2);
                if (line1[i] == line2[i])
                {
                    intersect_x = x1;
                    intersect_y = line1[i];
                }
                x1 = x1 + step;
            }
            PrintLine(line1, "Line 1");
            PrintLine(line2, "Line 2");
            Console.WriteLine($"Intersection point on (x = {intersect_x:F1}, y = {intersect_y:F1})");

            break;
        }
    }
}

MainPart();