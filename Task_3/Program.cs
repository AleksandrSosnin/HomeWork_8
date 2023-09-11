/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int rows1 = 2;
int cols1 = 2;
int rows2 = 2;
int cols2 = 2;

Random random = new Random();
int[,] matrix1 = new int[rows1, cols1];
for (int i = 0; i < rows1; i++)
{
    for (int j = 0; j < cols1; j++)
    {
        matrix1[i, j] = random.Next(1, 10); 
    }
}

int[,] matrix2 = new int[rows2, cols2];
for (int i = 0; i < rows2; i++)
{
    for (int j = 0; j < cols2; j++)
    {
        matrix2[i, j] = random.Next(1, 10); 
    }
}

int[,] result = new int[rows1, cols2];
for (int i = 0; i < rows1; i++)
{
    for (int j = 0; j < cols2; j++)
    {
        result[i, j] = 0;
        for (int k = 0; k < cols1; k++)
        {
            result[i, j] += matrix1[i, k] * matrix2[k, j];
        }
    }
}

Console.WriteLine("Первая матрица:");
for (int i = 0; i < rows1; i++)
{
    for (int j = 0; j < cols1; j++)
    {
        Console.Write(matrix1[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Вторая матрица:");
for (int i = 0; i < rows2; i++)
{
    for (int j = 0; j < cols2; j++)
    {
        Console.Write(matrix2[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Результирующая матрица:");
for (int i = 0; i < rows1; i++)
{
    for (int j = 0; j < cols2; j++)
    {
        Console.Write(result[i, j] + " ");
    }
    Console.WriteLine();
}