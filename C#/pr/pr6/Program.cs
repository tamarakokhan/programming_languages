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


void Ex41()
{
    // Пользователь вводит с клавиатуры M чисел.
    // Посчитайте, сколько чисел больше 0 ввёл пользователь.

    // Вариант 1

    int m = Input("Сколько чисел будет вводить пользователь? ");

    int count = 0;
    for (int i = 0; i < m; i++)
    {
        int n = Input("Введите число: ");
        if (n > 0) count++;
    }
    Console.WriteLine($"Количество положительных чисел - {count}.");

    // Вариант 2

    int num = Input("Введите число (для окончания введите 0): ");
    int pos_num = 0;

    while (num != 0)
    {
        if (num > 0) pos_num++;
        num = Input("Введите число (для окончания введите 0): ");
    }

    Console.WriteLine($"Количество положительных чисел - {pos_num}.");
}

void Ex43()
{
// Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 * x +
// b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.

double b1 = Input_double("Введите число b1: ");
double k1 = Input_double("Введите число k1: ");
double b2 = Input_double("Введите число b2: ");
double k2 = Input_double("Введите число k2: ");

double x = (b1 - b2) / (k2 - k1);

double y = k1 * x + b1;

Console.WriteLine($"Точка пересечения двух прямых имеет координаты: x = {x}, y = {y}.");
}

Console.Clear();
Ex43();