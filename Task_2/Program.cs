/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int rowCount = 4; 
int colCount = 4; 

static int[,] GenerateRandomArray(int rowCount, int colCount)
{
    int[,] array = new int[rowCount, colCount];
    Random rand = new Random();

    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < colCount; j++)
        {
            array[i, j] = rand.Next(1, 101);
        }
    }
    return array;
}

static int FindRowWithMinSum(int[,] array)
{
    int rowCount = array.GetLength(0); 
    int colCount = array.GetLength(1); 
    int minSumRow = 0;
    int minSum = int.MaxValue;

    for (int i = 0; i < rowCount; i++)
    {
        int currentSum = 0;
        for (int j = 0; j < colCount; j++)
        {
            currentSum += array[i, j];
        }

        if (currentSum < minSum)
        {
            minSum = currentSum;
            minSumRow = i;
        }
    }
    return minSumRow;
}

static void PrintArray(int[,] array)
{
    int rowCount = array.GetLength(0);
    int colCount = array.GetLength(1);

    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < colCount; j++)
        {
        Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array = GenerateRandomArray(rowCount, colCount);
Console.WriteLine("Случайный массив:");
PrintArray(array);
int minSumRow = FindRowWithMinSum(array);
Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRow + 1}");