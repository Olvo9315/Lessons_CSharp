// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива

int arr_len = GetNumberFromUser("Enter array length (it must be > 0): ", "Invalid input for array length! Please enter a number.");
double[] array = Getarray(arr_len);
DisplayArray(array);
DisplayDif(MinNumber(array), MaxNumber(array)); 

int GetNumberFromUser(string messsage, string errorMessage)
{
    while (true)
    {
        Console.Write(messsage);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber>0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

double[] Getarray(int arr_len)
{
    double[] arr = new double[arr_len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-99, 100) + new Random().NextDouble();
    }
    return arr;
}

void DisplayArray(double[] arr)
{
    Console.Write("Your array: [");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write($"{arr[i]:F2}");
        }
        else
            Console.Write($"{arr[i]:F2}, ");
    }
    Console.WriteLine("]");  
}

double MinNumber(double[] arr)
{
    double min_num = arr[0];
    foreach(double element in arr)
    {
        min_num = min_num < element ? min_num : element;
    }
    return min_num;
}

double MaxNumber(double[] arr)
{
    double max_num = arr[0];
    foreach(double element in arr)
    {
        max_num = max_num > element ? max_num : element;
    }
    return max_num;
}

void DisplayDif(double min_num, double max_num)
{
    double result = max_num - min_num;
    Console.WriteLine($"Difference between Max number {max_num:F2} and Min number {min_num:F2} = {result:F2}");
}