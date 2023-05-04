// Программа , которая принимает от пользователя на вход индексы элемента двумерного массива и выводит значение элемента в консоль , либо показывает , что данного элемента нет.

Console.Clear();

int rows = 4;
int columns = 5;

int[,] array = GetArray(rows, columns, -10, 10);
PrintArray(array);
Console.WriteLine();

int rowPosition = GetNumberFromUser("Введите индекс строки искомого элемента, который равен или больше 0: ", "Ошибка ввода!Повторите попытку!");
Console.WriteLine();
int columnPosition = GetNumberFromUser("Введите индекс столбца искомого элемента, который равен или больше 0: ", "Ошибка ввода!Повторите попытку!");
Console.WriteLine();

bool result = CheckElemByUserPositions(rowPosition, columnPosition, array);

PrintReport(result);

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#region Methods

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] arr = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return arr;
}

int[,] PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
    return arr;
}

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber) && userNumber >= 0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

bool CheckElemByUserPositions(int m, int n, int[,] arr)
{
    return m < arr.GetLength(0) && n < arr.GetLength(1);
}

void PrintReport(bool res)
{
    if (res == true)
    {
        Console.WriteLine($"Да , данный элемент массива существует и равняется -> {array[rowPosition, columnPosition]}");
    }
    else
    {
        Console.WriteLine("Данного элемента массива не существует");
    }
}

#endregion;