// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях

int arr_len = GetNumberFromUser("Enter array length (it must be > 0): ", "Invalid input for array length! Please enter a number.");
int[] array = Getarray(arr_len);
DisplayArray(array);
OddPosCount(array);

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
        arr[i] = new Random().Next(-99, 100);
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

void OddPosCount(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += i % 2 != 0 ? arr[i] : 0;
    }
    Console.WriteLine($"Sum of numbers in odd position in your array: {sum}");
}