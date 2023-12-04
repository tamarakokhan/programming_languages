using System.Diagnostics.CodeAnalysis;

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillMatrix(int[,] matr, int n1, int n2)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(n1, n2);
        }
    }
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Ex46()
{
    // Задайте двумерный массив размером m×n,
    // заполненный случайными целыми числами.

    int m = Input("Введите количество строк матрицы: ");
    int n = Input("Введите количество столбцов матрицы: ");

    int[,] matrix = new int[m, n];

    FillMatrix(matrix, -100, 100);
    PrintMatrix(matrix);
}

void Ex48()
{
    // Задайте двумерный массив размера m на n,
    // каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
    // Выведите полученный массив на экран.

    int m = Input("Введите количество строк матрицы: ");
    int n = Input("Введите количество столбцов матрицы: ");

    int[,] matrix = new int[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }

    PrintMatrix(matrix);
}

void Ex49()
{
    // Задайте двумерный массив. Найдите элементы, у
    // которых оба индекса чётные, и замените эти элементы на их
    // квадраты.

    int m = Input("Введите количество строк матрицы: ");
    int n = Input("Введите количество столбцов матрицы: ");

    int[,] matrix = new int[m, n];

    FillMatrix(matrix, 0, 10);
    PrintMatrix(matrix);

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) matrix[i, j] = matrix[i, j] * matrix[i, j];
        }
    }

    Console.WriteLine();
    PrintMatrix(matrix);
}

void Ex51()
{
    // Задайте двумерный массив. Найдите сумму
    // элементов, находящихся на главной диагонали (с индексами
    // (0,0); (1;1) и т.д.

    // Вариант 1

    int m = Input("Введите количество строк матрицы: ");
    int n = Input("Введите количество столбцов матрицы: ");

    int[,] matrix = new int[m, n];

    FillMatrix(matrix, 0, 10);
    PrintMatrix(matrix);

    int sum = 0;
    int i = 0;
    int j = 0;

    while (i < matrix.GetLength(0) && j < matrix.GetLength(1))
    {
        sum = sum + matrix[i, j];
        i++;
        j++;
    }

    // Вариант 2

    int sum2 = 0;
    for (int a = 0; a < matrix.GetLength(0); a++)
    {
        for (int b = 0; b < matrix.GetLength(1); b++)
        {
            if (a == b) sum2 = sum2 + matrix[a, b];
        }
    }

    Console.WriteLine($"Сумма элементов главной диагонали - {sum}.");
    Console.WriteLine($"Сумма элементов главной диагонали - {sum2}.");
}

Console.Clear();
Ex51();
