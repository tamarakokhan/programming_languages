int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
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

void FillArrayDoub(double[] array, int n1, int n2)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(n1, n2);
        index++;
    }
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(arr[position] + " ");
        position++;
    }
}

void PrintArrayDouble(double[] arr)
{
    int count = arr.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(arr[position] + " ");
        position++;
    }
}

void Ex34()
{
    // Задайте массив заполненный случайными
    // положительными трёхзначными числами. Напишите
    // программу, которая покажет количество чётных чисел в
    // массиве.

    int[] array = new int[Input("Введите количество элементов массива: ")];

    int EvenNum(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0) count += 1;
        }
        return count;
    }

    FillArray(array, 100, 1000);
    PrintArray(array);
    Console.WriteLine($"\nКоличество положительных чисел в массиве - {EvenNum(array)}.");
}

void Ex36()
{
    // Задайте одномерный массив, заполненный
    // случайными числами. Найдите сумму элементов, стоящих
    // на нечётных позициях.

    int[] array = new int[Input("Введите количество элементов массива: ")];

    int SumOddInd(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 != 0) sum += array[i];
        }
        return sum;
    }

    FillArray(array, 0, 10);
    PrintArray(array);
    Console.WriteLine($"\nСумма элементов, стоящих на нечетных позициях  - {SumOddInd(array)}.");
}

void Ex38()
{
    // Задайте массив вещественных чисел.
    // Найдите разницу между максимальным и минимальным
    // элементов массива. 

    double[] array = new double[Input("Введите количество элементов массива: ")];

    double MaxNum(double[] array)
    {
        double max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) max = array[i];
        }
        return max;
    }

    double MinNum(double[] array)
    {
        double min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min) min = array[i];
        }
        return min;
    }

    FillArrayDoub(array, 0, 10);
    PrintArrayDouble(array);
    Console.WriteLine($"\nРазница между макс. эл. массива ({MaxNum(array)}) и мин. эл. массива ({MinNum(array)}) - {MaxNum(array) - MinNum(array)}.");
}

Console.Clear();
Ex38();
