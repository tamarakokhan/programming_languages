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

void Ex54()
{
    // Задайте двумерный массив. Напишите программу, которая
    // упорядочит по убыванию элементы каждой строки двумерного массива.

    int m = Input("Введите количество строк матрицы: ");
    int n = Input("Введите количество столбцов матрицы: ");

    int[,] matrix = new int[m, n];

    FillMatrix(matrix, 0, 10);
    PrintMatrix(matrix);

    void SortDescending(int[,] matr)
    {
        for (int k = 0; k < matr.GetLength(0); k++)
        {
            for (int i = 0; i < matr.GetLength(1) - 1; i++)
            {
                int maxPosition = i;
                for (int j = i + 1; j < matr.GetLength(1); j++)
                {
                    if (matr[k, j] > matr[k, maxPosition]) maxPosition = j;
                }
                int temp = matr[k, i];
                matr[k, i] = matr[k, maxPosition];
                matr[k, maxPosition] = temp;
            }

        }
    }

    SortDescending(matrix);
    Console.WriteLine();
    PrintMatrix(matrix);
}

void Ex56()
{
    // Задайте прямоугольный двумерный массив. Напишите
    // программу, которая будет находить строку с наименьшей суммой элементов.

    int m = Input("Введите количество строк матрицы: ");
    int n = Input("Введите количество столбцов матрицы: ");

    int[,] matrix = new int[m, n];

    FillMatrix(matrix, 0, 10);
    PrintMatrix(matrix);

    void MinSumRow(int[,] matr)
    {
        Dictionary<int, int> minSumRow = new Dictionary<int, int>();

        int min = 1000;
        int minRow = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                sum = sum + matr[i, j];
            }
            minSumRow.Add(i, sum);
            if (sum < min)
            {
                min = sum;
                minRow = i + 1;
            }
        }

        Console.WriteLine($"Минимальная сумма в {minRow} строке -  {min}.");

        foreach (var n in minSumRow)
        {
            Console.WriteLine($"Сумма чисел в {n.Key} строке -  {n.Value}.");
        }
    }

    MinSumRow(matrix);
}

void Ex58()
{
    // Задайте две матрицы. Напишите программу, которая будет
    // находить произведение двух матриц.

    int m = Input("Введите количество строк 1-ой матрицы: ");
    int n = Input("Введите количество столбцов 1-ой матрицы: ");

    int x = Input("Введите количество строк 2-ой матрицы: ");
    int y = Input("Введите количество столбцов 2-ой матрицы: ");

    int[,] matrix1 = new int[m, n];
    int[,] matrix2 = new int[x, y];

    FillMatrix(matrix1, 0, 10);
    PrintMatrix(matrix1);
    Console.WriteLine();
    FillMatrix(matrix2, 0, 10);
    PrintMatrix(matrix2);
    Console.WriteLine();

    int[,] MultiplicationMatrix(int[,] matr1, int[,] matr2)
    {
        int[,] matrix = new int[matr1.GetLength(0), matr2.GetLength(1)];

        if (matr1.GetLength(1) != matr2.GetLength(0))
        {
            Console.WriteLine("Произведение матриц невозможно! Проверьте размерность матриц!");
        }
        else
        {
            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                for (int j = 0; j < matr2.GetLength(1); j++)
                {
                    matrix[i, j] = 0;
                    for (int k = 0; k < matr1.GetLength(1); k++)
                    {
                        matrix[i, j] += matr1[i, k] * matr2[k, j];
                    }
                }
            }
        }
        return matrix;
    }

    PrintMatrix(MultiplicationMatrix(matrix1, matrix2));
}

Console.Clear();
Ex58();
