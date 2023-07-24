void Ex1()
{
    // Напишите программу, которая на вход
    // принимает число и выдаёт его квадрат (число
    // умноженное на само себя).

    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(num * num);
}

void Ex2()
{
    // Напишите программу, которая на вход
    // принимает число и выдаёт его квадрат (число
    // умноженное на само себя).

    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(num * num);
}

void Ex3()
{
    // Напишите программу, которая на вход принимает два
    // числа и проверяет, является ли первое число квадратом
    // второго.

    Console.WriteLine("Введите 1-ое число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите 2-ое число: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    if (num2 == num1 * num1)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}

void Ex4()
{
    // Напишите программу, которая будет выдавать
    // название дня недели по заданному номеру.

    // Вариант 1
    Console.WriteLine("Введите число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    if (num1 > 7)
    {
        Console.WriteLine("Нет такого дня недели.");
    }
    else if (num1 == 1)
    {
        Console.WriteLine("Понедельник");
    }
    else if (num1 == 2)
    {
        Console.WriteLine("Вторник");
    }
    else if (num1 == 3)
    {
        Console.WriteLine("Среда");
    }
    else if (num1 == 4)
    {
        Console.WriteLine("Четверг");
    }
    else if (num1 == 5)
    {
        Console.WriteLine("Пятница");
    }
    else if (num1 == 6)
    {
        Console.WriteLine("Суббота");
    }
    else if (num1 == 7)
    {
        Console.WriteLine("Воскресенье");
    }

    // Вариант 2
    var days = new Dictionary<int, string>()
{
    { 1, "Понедельник"},
    { 2, "Вторник"},
    { 3, "Среда"},
    { 4, "Четверг"},
    { 5, "Пятница"},
    { 6, "Суббота"},
    { 7, "Воскресенье"},
};
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0 & num < 8)
        Console.WriteLine(days[num]);
    if (num > 7)
    {
        Console.WriteLine("Нет такого дня недели.");
    }
}

void Ex5()
{
    // Напишите программу вычисления значения
    // функции возведения числа в квадрат.

    int Square(int x) => x * x;

    Console.WriteLine("Введите число: ");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(Square(x));
}

void Ex6()
{
    // Напишите программу, которая на вход принимает одно число
    // (N), а на выходе показывает все целые числа в промежутке от -N
    // до N.

    Console.WriteLine("Введите число: ");
    int x = Convert.ToInt32(Console.ReadLine());

    for (int i = -x; i <= x; i++)
    {
        Console.Write(i + " ");
    }
}