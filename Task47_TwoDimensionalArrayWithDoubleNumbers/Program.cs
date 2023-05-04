// Программа для генерации двумерного массива , заполненного случайными, вещественными числами.

Console.Clear();

int rows = GetNumberFromUser("Введите число строк , не равное 0: ", "Ошибка ввода!Повторите попытку.");
int columns = GetNumberFromUser("Введите число столбцов , не равное 0: ", "Ошибка ввода!Повторите попытку.");

double[,] array = GetArray(rows, columns);

Console.WriteLine();
PrintArray(array);

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#region Methods

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber) && userNumber > 0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

double[,] GetArray(int m, int n)
{
    double[,] arr = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().NextDouble();
            int randomNumb = new Random().Next(100, 1000 + 1);
            arr[i, j] = arr[i, j] * randomNumb;
        }
    }
    return arr;
}

void PrintArray(double[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            Console.Write($"{result[i, j]}\t");
        }
        Console.WriteLine();
    }
}

#endregion;