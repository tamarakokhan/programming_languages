void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

void FillArray(int[] array, int n1, int n2)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(n1, n2);
        index++;
    }
}

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


void Ex31()
{
    // Задайте массив из 12 элементов, заполненный
    // случайными числами из промежутка [-9, 9]. Найдите сумму
    // отрицательных и положительных элементов массива.

    int[] array = new int[12];
    FillArray(array, -9, 10);

    int sum_pos = 0;
    int sum_neg = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum_pos += array[i];
        else sum_neg += array[i];
    }

    PrintArray(array);
    Console.WriteLine($"\nСумма положительных элементов массива - {sum_pos}. \nСумма отрицательных элементов массива - {sum_neg}.");
}

void Ex32()
{
    // Напишите программу замена элементов
    // массива: положительные элементы замените на
    // соответствующие отрицательные, и наоборот.

    int[] array = new int[10];

    FillArray(array, -9, 10);
    PrintArray(array);

    void Replace(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = -arr[i];
        }
    }

    Replace(array);
    Console.WriteLine();
    PrintArray(array);
}

void Ex33()
{
    // Задайте массив. Напишите программу, которая
    // определяет, присутствует ли заданное число в массиве.

    void Find(int[] array, int find)
    {
        int index = 0;
        while (true)
        {
            if (index < array.Length)
            {
                if (array[index] == find)
                {
                    Console.WriteLine($"Такое число есть в массиве с индексом {index}.");
                    break;
                }
                index++;
            }
            else
            {
                Console.WriteLine("Такого числа нет в массиве.");
                break;
            }
        }
    }

    int[] array = new int[10];

    FillArray(array, 1, 10);
    PrintArray(array);
    Console.WriteLine();
    Find(array, Input("Введите искомое число: "));
}

void Ex35()
{
    // Задайте одномерный массив из 123 случайных чисел.
    // Найдите количество элементов массива, значения которых лежат в
    // отрезке [10,99].

    int NumFind(int[] array, int num1, int num2)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= num1 && array[i] <= num2) count += 1;
        }
        return count;
    }

    int[] array = new int[123];

    FillArray(array, 1, 200);
    Console.WriteLine($"Кол-во элементов массива от 10 до 99 - {NumFind(array, 10, 99)}.");
}

void Ex37()
{
    // Найдите произведение пар чисел в одномерном массиве.
    // Парой считаем первый и последний элемент, второй и предпоследний
    // и т.д. Результат запишите в новом массиве.

    // Для массива с нечетным колличеством элементов.

    int[] array1 = new int[5] { 1, 2, 3, 4, 5 };
    int[] array2 = new int[array1.Length / 2 + 1];

    int a = 0;
    int b = array1.Length - 1;
    while (a < (array1.Length / 2))
    {
        array2[a] = array1[a] * array1[b];
        a++;
        b--;
    }
    array2[a] = array1[a];

    PrintArray(array1);
    Console.WriteLine();
    PrintArray(array2);
    Console.WriteLine();

    // Для массива с четным количеством элементов.

    int[] arr1 = new int[4] { 6, 7, 3, 6 };
    int[] arr2 = new int[array1.Length / 2];

    int x = 0;
    int y = arr1.Length - 1;
    while (x < (arr1.Length / 2))
    {
        arr2[x] = arr1[x] * arr1[y];
        x++;
        y--;
    }

    PrintArray(arr1);
    Console.WriteLine();
    PrintArray(arr2);

    // Универсальный метод

    int[] ar1 = new int[Input("\nВведите размер массива: ")];
    int[] ar2 = new int[ar1.Length / 2 + ar1.Length % 2];


    void NewArrayPr(int[] ar1, int[] ar2)
    {
        int i = 0;
        int j = ar1.Length - 1;
        while (i < (ar1.Length / 2))
        {
            ar2[i] = ar1[i] * ar1[j];
            i++;
            j--;
            if (i == j) ar2[i] = ar1[i];
        }
    }

    FillArray(ar1, 0, 10);
    NewArrayPr(ar1, ar2);
    PrintArray(ar1);
    Console.WriteLine();
    PrintArray(ar2);
    Console.WriteLine();
}

Console.Clear();
Ex37();
