// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Enter quantity Rows Matrix A --> ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter quantity Columns Matrix A --> ");
int y = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter quantity Rows Matrix B --> ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter quantity Columns Matrix B --> ");
int y1 = Convert.ToInt32(Console.ReadLine());

if (y == x1)
{
    int[,] MatrixA = new int[x, y];
    int[,] MatrixB = new int[x1, y1];
    int[,] MatrixC = new int[x, y1];
    for (int i = 0; i < MatrixA.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixA.GetLength(1); j++)
        {
            MatrixA[i, j] = new Random().Next(0, 10);
            Console.Write($"{MatrixA[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int i = 0; i < MatrixB.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixB.GetLength(1); j++)
        {
            MatrixB[i, j] = new Random().Next(0, 10);
            Console.Write($"{MatrixB[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int i = 0; i < MatrixA.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixB.GetLength(1); j++)
        {
            for (int k = 0; k < MatrixA.GetLength(1); k++)
            {
                MatrixC[i, j] += MatrixA[i, k] * MatrixB[k, j];
            }
            Console.Write($"{MatrixC[i, j]} ");
        }
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("These matrices are not multiplied");
}

