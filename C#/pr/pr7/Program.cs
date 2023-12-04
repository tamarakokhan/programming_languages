using System.Globalization;

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

void FillMatrixDouble(double[,] matr, int n1, int n2)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Math.Round(new Random().Next(n1, n2) + new Random().NextDouble(), 1);
        }
    }
}

void PrintMatrixDouble(double[,] matr)
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

void Ex47()
{
    // Задайте двумерный массив размером m×n,
    // заполненный случайными вещественными числами.

    int m = Input("Введите количество строк матрицы: ");
    int n = Input("Введите количество столбцов матрицы: ");

    double[,] matrix = new double[m, n];

    FillMatrixDouble(matrix, -100, 100);
    PrintMatrixDouble(matrix);
}

void Ex50()
{
    // Напишите программу, которая на вход
    // принимает позиции элемента в двумерном массиве, и
    // возвращает значение этого элемента или же указание,
    // что такого элемента нет.

    int m = Input("Введите количество строк матрицы: ");
    int n = Input("Введите количество столбцов матрицы: ");

    int[,] matrix = new int[m, n];

    FillMatrix(matrix, 0, 10);
    PrintMatrix(matrix);

    int find = Input(("Введите число: "));

    void FindNum(int[,] matr, int num)
    {
        bool flag = false;
        int a = 0;
        int b = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (matr[i, j] == num)
                {
                    flag = true;
                    a = i;
                    b = j;
                    break;
                }
            }
        }
        if (flag == true) Console.WriteLine($"Такое число есть в матрице с индексом [{a}, {b}].");
        else Console.WriteLine("Такого числа нет в матрице.");
    }

    FindNum(matrix, find);
}

void Ex52()
{
    // Задайте двумерный массив из целых чисел.
    // Найдите среднее арифметическое элементов в каждом
    // столбце.

    int m = Input("Введите количество строк матрицы: ");
    int n = Input("Введите количество столбцов матрицы: ");

    int[,] matrix = new int[m, n];

    FillMatrix(matrix, 0, 10);
    PrintMatrix(matrix);

    void AverageColumn(int[,] matr)
    {
        int j = 0;
        double sum = 0;
        while (j < matr.GetLength(1))
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                sum = sum + matr[i, j];
            }
            double avr = Math.Round(sum / matr.GetLength(0), 1);
            Console.WriteLine($"Среднее арифметическое {j + 1}-го столбца - {avr:f2}.");
            j++;
            sum = 0;
        }
    }

    AverageColumn(matrix);
}

Console.Clear();
Ex52();



