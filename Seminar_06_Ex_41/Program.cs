// Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

// _Input len
int arr_len = GetLenFromUser("Enter the quantity of objects to type (it must be > 0): ", "Invalid input type! Please enter a number.");

// _Input array
int[] array = GetArrayFromUser(arr_len);

// _Count positive
int pos = CountPos(array);

// _Output
PrintOutput(array, pos);


int GetLenFromUser(string messsage, string errorMessage)
{
    while (true)
    {
        Console.Write(messsage);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber > 0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int[] GetArrayFromUser(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Enter {i} index number: ");
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            array[i] = userNumber;
        else
        {
            Console.WriteLine("Invalid input type! Please enter a number.");
            i--;
        }
    }
    return array;
}

int CountPos(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    return count;
}

void PrintOutput(int[] array, int countPos)
{
    Console.Write("Your array: [");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write(array[i]);
        }
        else
            Console.Write(array[i] + ", ");
    }
    Console.WriteLine($"] - has {countPos} positive numbers.");
}