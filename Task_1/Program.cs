/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

Random random = new Random();
int rows = 3;
int cols = 4;

int[,] array = new int[rows, cols];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        array[i, j] = random.Next(1, 100);
    }
}
Console.WriteLine("Исходный массив:");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
for (int i = 0; i < rows; i++)
{
    for (int j = 1; j < cols; j++)
    {
        int current = array[i, j];
        int k = j - 1;

        while (k >= 0 && array[i, k] < current)
        {
            array[i, k + 1] = array[i, k];
            k--;
        }

        array[i, k + 1] = current;
    }
}
Console.WriteLine("Отсортированный массив:");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}




