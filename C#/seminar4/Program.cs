int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Ex24()
{
    // Напишите программу, которая
    // принимает на вход число (А) и выдаёт сумму чисел
    // от 1 до А.

    int num = Input("Введите число: ");
    int sum = 0;

    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    Console.WriteLine($"Сумма чисел от 1 до {num} - {sum}.");

    int Sum(int n)             //Сделали отдельную функцию, для поиска суммы от 1 до N
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum = sum + i;
        }
        return sum;
    }
    Console.WriteLine($"Сумма чисел от 1 до {num} - {Sum(num)}.");
}

void Ex26()
{
    // Напишите программу, которая принимает
    // на вход число и выдаёт количество цифр в числе.

    int num = Input("Введите число: ");

    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    Console.WriteLine($"Количество цифр в числе - {count}.");

    int num2 = Input("Введите число: ");

    int NumDig(int n)      // Создали функцию для нахождния количества цифр в числе
    {
        int count = 0;
        while (n > 0)
        {
            n = n / 10;
            count++;
        }
        return count;
    }

    Console.WriteLine($"Количество цифр в числе {num2} - {NumDig(num2)}.");
}

void Ex28()
{
    // Напишите программу, которая
    // принимает на вход число N и выдаёт
    // произведение чисел от 1 до N.

    int num = Input("Введите число: ");

    int pr = 1;
    for (int i = 1; i <= num; i++)
    {
        pr = pr * i;
    }
    Console.WriteLine($"Произведение чисел от 1 до {num} - {pr}.");

    int Pr(int n)
    {
        int pr = 1;
        for (int i = 1; i <= n; i++)
        {
            pr = pr * i;
        }
        return pr;
    }
    Console.WriteLine($"Произведение чисел от 1 до {num} - {Pr(num)}.");
}

void Ex30()
{
    // Напишите программу, которая
    // выводит массив из 8 элементов, заполненный
    // нулями и единицами в случайном порядке.

    void FillArray(int[] collection)
    {
        int length = collection.Length;
        int index = 0;
        while (index < length)
        {
            collection[index] = new Random().Next(0, 2);
            index++;
        }
    }

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

    int[] array = new int[8];

    FillArray(array);
    PrintArray(array);

    void CreateArray()
    {
        int[] array = new int[8];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(0, 2);
            Console.Write(array[i] + " ");
        }
    }

    Console.WriteLine();
    CreateArray();
}

Console.Clear();
Ex30();
