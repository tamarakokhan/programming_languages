int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] array, int n1, int n2)
{
    int index = 0;
    while (index < array.Length)
    {
        array[index] = new Random().Next(n1, n2);
        index++;
    }
}

void PrintArray(int[] array)
{
    int index = 0;
    while (index < array.Length)
    {
        Console.Write(array[index] + " ");
        index++;
    }
}

void Ex39()
{
    // Напишите программу, которая перевернёт одномерный
    // массив (последний элемент будет на первом месте, а первый - на
    // последнем и т.д.)

    int[] array = new int[Input("Введите размер массива: ")];
    FillArray(array, 0, 10);
    PrintArray(array);

    int i = 0;
    int j = array.Length - 1;

    while (i < array.Length / 2)
    {
        int position = array[j];
        array[j] = array[i];
        array[i] = position;
        i++;
        j--;
    }

    // for (int a = 0; a < array.Length / 2; a++)
    // {
    //     int temp = array[a];
    //     array[a] = array[array.Length - 1 - a];
    //     array[array.Length - 1 - a] = temp;
    // }

    Console.WriteLine();
    PrintArray(array);
}

void Ex40()
{
    // Напишите программу, которая принимает на вход три числа и
    // проверяет, может ли существовать треугольник с сторонами такой длины.
    // Теорема о неравенстве треугольника: каждая сторона треугольника
    // меньше суммы двух других сторон.

    int a = Input("Введите первое число: ");
    int b = Input("Введите второе число: ");
    int c = Input("Введите третье число: ");

    if (a < b + c && b < a + c && c < a + b) Console.WriteLine("Такой треугольник может существовать.");
    else Console.WriteLine("Такой треугольник не может существовать.");
}

void Ex42()
{
    // Напишите программу, которая будет преобразовывать
    // десятичное число в двоичное.

    // Вариант 1

    int num = Input("Введите число: ");

    int count = 1;
    int num2 = 0;
    while (num > 0)
    {
        int n = num % 2;
        num = num / 2;
        num2 = num2 + n * count;
        count = count * 10;
    }

    Console.WriteLine(num2);

    // Вариант 2

    int x = Input("Введите число: ");

    string result = "";

    while ( x > 0)
    {
        result = x % 2 + result;
        x = x / 2;
    }

    Console.WriteLine(result);
}

void Ex44()
{
    // Не используя рекурсию, выведите первые N чисел
    // Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

    // Вариант 1

    int n = Input("Введите число: ");

    int fib1 = 0;
    int fib2 = 1;
    Console.Write(fib1 + " " + fib2);

    int j = 0;
    while (j < n - 2)
    {
        int fib3 = fib1 + fib2;
        Console.Write(" " + fib3);
        fib1 = fib2;
        fib2 = fib3;
        j++;
    }

    // Вариант 2

    int num = Input("Введите число: ");

    int firstNum = 0;
    int secondNum = 1;
    Console.Write(firstNum + " " + secondNum);

    for (int i = 3; i <= num; i++)
    {
        int nextNum = firstNum + secondNum;
        Console.Write(" " + nextNum);
        firstNum = secondNum;
        secondNum = nextNum;
    }
}

void Ex45()
{
// Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования.

    int[] array = new int[Input("Введите размер массива: ")];
    FillArray(array, 1, 10);
    PrintArray(array);

    int[] array_copy = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        array_copy[i] = array[i];
    }

    Console.WriteLine();
    PrintArray(array_copy);
}

Console.Clear();
Ex39();