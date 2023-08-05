// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве

int arr_len = GetNumberFromUser("Enter array length (it must be > 0): ", "Invalid input for array length! Please enter a number.");
int[] array = Getarray(arr_len);
DisplayArray(array);
PositiveCount(array);

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

int[] Getarray(int arr_len)
{
    int[] arr = new int[arr_len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

void DisplayArray(int[] arr)
{
    Console.Write("Your array: [");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write(arr[i]);
        }
        else
            Console.Write(arr[i] + ", ");
    }
    Console.WriteLine("]");  
}

void PositiveCount(int[] arr)
{
    int i = 0;
    foreach(int element in arr)
    {
        i += element % 2 == 0 ? 1 : 0;
    }
    Console.WriteLine($"Even numbers in your array: {i}");
}