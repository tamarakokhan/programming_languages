int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Ex10()
{
    // Напишите программу, которая принимает на вход
    // трёхзначное число и на выходе показывает вторую цифру этого числа.

    int num = Input("Введите трехзначное число: ");

    num = num / 10;
    int n2 = num % 10;

    Console.WriteLine($"Вторая цифра - {n2}.");
}

void Ex13()
{
    // Напишите программу, которая с помощью деления
    // выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

    int num = Input("Введите число: ");
    int n = 0;

    if (num / 100 == 0)
    {
        Console.WriteLine("Третьей цифры нет.");
    }
    else
    {
        while (num > 99)
        {
            n = num % 10;
            num = num / 10;
        }
        Console.WriteLine($"Третья цифра - {n}.");
    }
}

void Ex15()
{
    // Напишите программу, которая принимает на вход цифру, 
    // обозначающую день недели, и проверяет, является ли этот день выходным.

    int num = Input("Введите число дня недели: ");

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
    if (num > 7 || num == 0)
    {
        Console.WriteLine("Нет такого дня недели.");
    }
    else if (num == 6 || num == 7)
    {
        Console.WriteLine($"Да, {days[num]} - выходной день.");
    }
    else if (num < 6)
    {
        Console.WriteLine($"Нет, {days[num]} -  не выходной день.");
    }
}
