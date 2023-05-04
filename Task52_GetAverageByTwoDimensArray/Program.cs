// Программа по поиску среднего арифметического каждого столбца двумерного массива.

Console.Clear();

int rows = GetNumberFromUser("Введите число строк , не равное 0: ", "Ошибка ввода!Повторите попытку.");
int columns = GetNumberFromUser("Введите число столбцов , не равное 0: ", "Ошибка ввода!Повторите попытку.");

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();

double[] result = GetAverageByArray(array);

PrintReport(result);

/////////////////////////////////////////////////////////////////////////////////////////////////////////

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

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] arr = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

double[] GetAverageByArray(int[,] arr)
{
    double[] res = new double[arr.GetLength(1)];
    int k = 0;

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            res[k] = res[k] + arr[i, j];
        }
        res[k] = res[k] / arr.GetLength(0);
        k++;
    }

    return res;
}

void PrintReport(double[] arr)
{
    Console.WriteLine($"Среднее арифметическое каждого столбца данного массива равняется: {String.Join("|", arr)}");
}

#endregion;