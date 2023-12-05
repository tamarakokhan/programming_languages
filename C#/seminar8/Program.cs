using System.Data;
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

void Ex53()
{
    // Задайте двумерный массив. Напишите программу,
    // которая поменяет местами первую и последнюю строку
    // массива.


    int m = Input("Введите количество строк матрицы: ");
    int n = Input("Введите количество столбцов матрицы: ");

    int[,] matrix = new int[m, n];

    FillMatrix(matrix, 0, 10);
    PrintMatrix(matrix);

    void ReplaceLine(int[,] matr)
    {
        int i = 0;
        int x = matr.GetLength(0) - 1;    // Индекс поледней строки 
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            int temp = matr[i, j];
            matr[i, j] = matr[x, j];
            matr[x, j] = temp;
        }
    }

    ReplaceLine(matrix);
    Console.WriteLine();
    PrintMatrix(matrix);
}

void Ex55()
{
    // Задайте двумерный массив. Напишите программу,
    // которая заменяет строки на столбцы. В случае, если это
    // невозможно, программа должна вывести сообщение для
    // пользователя.

    //Когда нельзя выполнить условие??? Нужен квадратный массив!!!

    int m = Input("Введите количество строк матрицы: ");       // Вводим одну размерость для квадрата. 
    int n = Input("Введите количество столбцов матрицы: ");

    int[,] matrix = new int[m, n];

    FillMatrix(matrix, 0, 10);
    PrintMatrix(matrix);

    int[,] matrix2 = new int[n, m];

    void ReplaceLineColumn(int[,] matr, int[,] matr2)
    {
        for (int i = 0; i < matr2.GetLength(0); i++)
        {
            for (int j = 0; j < matr2.GetLength(1); j++)
            {
                matr2[i, j] = matr[j, i];
            }
        }
    }

    ReplaceLineColumn(matrix, matrix2);
    Console.WriteLine();
    PrintMatrix(matrix2);
}

void Ex57()
{
    // Составить частотный словарь элементов
    // двумерного массива. Частотный словарь содержит
    // информацию о том, сколько раз встречается элемент
    // входных данных.

    int m = Input("Введите количество строк матрицы: ");
    int n = Input("Введите количество столбцов матрицы: ");

    int[,] matrix = new int[m, n];

    FillMatrix(matrix, 0, 10);
    PrintMatrix(matrix);

    void FrequencyDictionary(int[,] matr)
    {
        Dictionary<int, int> frequencyDictionary = new Dictionary<int, int>();

        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                // if (matr[i, j] >= 0)
                if (frequencyDictionary.ContainsKey(matr[i, j]) == false)
                {
                    int temp = matr[i, j];
                    int count = 0;
                    for (int a = 0; a < matr.GetLength(0); a++)
                    {
                        for (int b = 0; b < matr.GetLength(1); b++)
                        {
                            if (matr[a, b] == temp)
                            {
                                count++;
                                // matr[a, b] = -1;
                            }
                        }
                    }
                    frequencyDictionary.Add(temp, count);
                }
            }
        }

        foreach (var n in frequencyDictionary)
        {
            Console.WriteLine($"{n.Key} встречается {n.Value} раз(а).");
        }
    }

    FrequencyDictionary(matrix);
}

void Ex59()
{
    // Задайте двумерный массив из целых чисел.
    // Напишите программу, которая удалит строку и столбец, на
    // пересечении которых расположен наименьший элемент
    // массива.

    int m = Input("Введите количество строк матрицы: ");
    int n = Input("Введите количество столбцов матрицы: ");

    int[,] matrix = new int[m, n];

    FillMatrix(matrix, 0, 100);
    PrintMatrix(matrix);

    int FindMin(int[,] matr)
    {
        int min = matr[0, 0];
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (matr[i, j] < min) min = matr[i, j];
            }
        }
        return min;
    }

    Console.WriteLine($"Минимальный элемент матрицы - {FindMin(matrix)}.");

    void PrintNewMatrix(int[,] matr, int num)
    {
        int row = 0;
        int column = 0;

        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (matr[i, j] == num)
                {
                    row = i;
                    column = j;
                    break;
                }
            }
        }

        Console.WriteLine($"Минимальный элемент находится в {row} строке и {column} столбце.");

        // Вариант 1 для вывода
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (i == row || j == column) continue;
                else
                {
                    Console.Write($"{matr[i, j]} ");
                }
            }
            Console.WriteLine();
        }

        // Вариант 2 для вывода
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (i != row && j != column)
                {
                    Console.Write($"{matr[i, j]} ");
                }
            }
            Console.WriteLine();
        }
    }

    PrintNewMatrix(matrix, FindMin(matrix));
}


Console.Clear();
Ex59();
