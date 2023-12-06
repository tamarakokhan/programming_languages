int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double Input_double(string text)
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
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

void Ex64()
{
    // Задайте значение N. Напишите программу,
    // которая выведет все натуральные числа в промежутке от N до 1.
    // Выполнить с помощью рекурсии.

    //Для целых чисел.

    Console.WriteLine("Задача 64.\nЦелые числа.");

    int n = Input("Введите число: ");

    string PrintNums(int num)
    {
        if (num == 1) return num.ToString();
        return num + "\t" + PrintNums(num - 1);
    }

    Console.WriteLine($"Числа от {n} до 1 (шаг - 1): \n{PrintNums(n)}");

    // Для дробных чисел, шаг 0,5.

    Console.WriteLine("Вещественные числа (шаг 0,5).");

    double n1 = Input_double("Введите число: ");

    string PrintNumsDouble(double num)
    {
        if (num == 1) return num.ToString();
        return num + "\t" + PrintNumsDouble(num - 0.5);
    }

    Console.WriteLine($"Числа от {n1} до 1 (шаг - 0,5): \n{PrintNumsDouble(n1)}");
}

void Ex66()
{
    //Задайте значения M и N. Напишите программу,
    //которая найдёт сумму натуральных элементов в промежутке от M до N.

    Console.WriteLine("Задача 66.");

    int num1 = Input("Введите первое число: ");
    int num2 = Input("Введите второе число: ");

    int PrintSumNums(int start, int end)
    {
        if (start == end) return start;
        return start + PrintSumNums(start + 1, end);
    }

    if (num1 > num2)
    {
        Console.WriteLine($"Сумма чисел от {num2} до {num1} - {PrintSumNums(num2, num1)}.");
    }
    else if (num1 == num2)
    {
        Console.WriteLine("Числа равны. Введите данные корректно.");
    }
    else
    {
        Console.WriteLine($"Сумма чисел от {num1} до {num2} - {PrintSumNums(num1, num2)}.");
    }
}

void Ex68()
{
    // Напишите программу вычисления функции Аккермана
    // с помощью рекурсии. Даны два неотрицательных числа m и n.

    Console.WriteLine("Задача 68.");

    int m = Input("Введите первое целое положительное число: ");
    int n = Input("Введите второе целое положительное число: ");

    if (m < 0 || n < 0) Console.WriteLine("Оба числа должны быть положительными. Введите данные корректно.");
    else
    {
        int Ackermann(int m, int n)
        {
            if (m == 0) return n + 1;
            if (n == 0) return Ackermann(m - 1, 1);
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }

        Console.WriteLine($"Функция Аккермана А({m}, {n}) - {Ackermann(m, n)}.");
    }
}

//Дополнительные задачи

//Задача 69 из 9-ого семинара с добавлением условия для отрицательных степеней.
void Ex69()
{
    //Напишите программу, которая на вход принимает 
    //два числа А и В, и возводит число А в целую степень В с помощью рекусии.

    Console.WriteLine("Задача 69. Возведение числа в степень (с учетом отрицательной степени).");

    double num1 = Input("Введите число: ");
    double num2 = Input("Введите степень числа: ");

    double PowNum(double num1, double num2)
    {
        if (num2 == 0) return 1;
        else if (num2 == 1) return num1;
        else if (num2 < 0) return 1/num1 * PowNum(1/num1, - num2 - 1);
        return num1 * PowNum(num1, num2 - 1);
    }

    Console.WriteLine($"Число {num1} в степени {num2} - {PowNum(num1, num2)}.");
}

//Задача 57 из презентации к 8-ому семинару.
void Ex57()
{
    // Составить частотный словарь элементов
    // двумерного массива. Частотный словарь содержит
    // информацию о том, сколько раз встречается элемент
    // входных данных.

    Console.WriteLine("Задача 57. Частотный словарь.");

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

    Console.WriteLine();
    FrequencyDictionary(matrix);
}

Console.Clear();
Ex64();
Ex66();
Ex68();
Ex69();
Ex57();