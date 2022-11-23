// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] GetArrayRandom(int rows, int cols, int minValue = 0, int maxValue = 10)             
{
    int[,] array = new int[rows, cols];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void GetArithmeticMeanOfColumns (int[,] array)
{
    int arc = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            arc +=array[j,i];
        }
        Console.WriteLine($"Среднее арифметическое {i+1}-го столбца: {arc}");
        arc = 0;
    }
}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов в массиве: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] massive = GetArrayRandom(m, n);
PrintArray(massive);
GetArithmeticMeanOfColumns(massive);