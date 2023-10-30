int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Ex25()
{
    // Напишите цикл, который принимает на вход
    // два числа (A и B) и возводит число A в натуральную
    // степень B.

    void Pow()
    {
        while (true)
        {
            int num1 = Input("Введите первую цифру: ");
            int num2 = Input("Введите вторую цифру: ");

            Console.WriteLine($"{num1} в {num2} степени - {Math.Pow(num1, num2)}.");
            break;
        }
    }

    Pow();
}

void Ex27()
{
    // Напишите программу, которая принимает на
    // вход число и выдаёт сумму цифр в числе.

    int num = Input("Введите число: ");

    int Sum(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            int n = number % 10;
            sum = sum + n;
            number = number / 10;
        }
        return sum;
    }

    Console.WriteLine($"Сумма цифр числа {num} - {Sum(num)}.");
}

void Ex29()
{
    // Напишите программу, которая задаёт массив
    // из 8 элементов и выводит их на экран.

    void FillArray(int[] collection)
    {
        int length = collection.Length;
        int index = 0;
        while (index < length)
        {
            collection[index] = Input("Введите число: ");
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
}

Console.Clear();
Ex25();
Ex27();
Ex29();
