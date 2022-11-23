// Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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

void FindElementByPosition(int[,] array, int rows, int cols)
{
    if (rows < array.GetLength(0) && cols < array.GetLength(1))
    {
        Console.WriteLine($"Значение элемента на позиции [{rows+1}, {cols+1}]: {array[rows, cols]}");
    }
    else
    {
        Console.WriteLine($"Числа с позицией [{rows+1}, {cols+1}] нет");
    }
}

Console.Clear();
Console.Write("Введите позицию элемента(строку): ");
int positionElemRows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите позицию элемента(столбец): ");
int positionElemCols = int.Parse(Console.ReadLine() ?? "0");

int[,] massive = GetArrayRandom(4, 4);
PrintArray(massive);
FindElementByPosition(massive, positionElemRows-1, positionElemCols-1);

// +1 и -1 я добавляла для того, чтобы пользователю было более понятно (т.е. он видит 1 столбец и считает его 1, а не 0 как компьютер).
// Если это мешает, то можно просто убрать +1 и -1, тогда номера столбцов и строк будут идти не с 1, а с 0.