// Задача 29: Напишите программу, 
//которая задаёт массив из 8 элементов и выводит их на экран.

int arr_len = GetNumberFromUser("Enter array length (it must be > 0): ", "Invalid input for array length! Please enter a number.");
int[] array = Getarray(arr_len);
DisplayArray(array);

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

int GetArrayNumberFromUser(string messsage, string errorMessage)
{
    while (true)
    {
        Console.Write(messsage);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int[] Getarray(int arr_len)
{
    int[] arr = new int[arr_len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = GetArrayNumberFromUser($"Enter array[{i}] number: ", $"Invalid input for array[{i}]] number! Please enter a number.");
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