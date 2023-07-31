int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Ex9()
{
    // Напишите программу, которая выводит
    // случайное число из отрезка [10, 99] и показывает
    // наибольшую цифру числа.

    Random rnd = new Random();
    int num = rnd.Next(10, 99);
    Console.WriteLine($"Число - {num}.");

    int n1 = num % 10;
    int n2 = num / 10;
    if (n1 > n2)
    {
        Console.WriteLine($"Наибольшая цифра - {n1}.");
    }
    else
    {
        Console.WriteLine($"Наибольшая цифра - {n2}.");
    }
}

void Ex11()
{
    // Напишите программу, которая выводит случайное
    // трёхзначное число и удаляет вторую цифру этого
    // числа.

    Random rnd = new Random();
    int num = rnd.Next(100, 1000);
    Console.WriteLine($"Число - {num}.");

    int n3 = num % 10;
    int n1 = num / 100;

    int new_num = n1 * 10 + n3;

    Console.WriteLine($"Новое число - {n1}{n3}.");
    Console.WriteLine($"Новое число - {new_num}.");

}

void Ex12()
{
    // Напишите программу, которая будет принимать
    // на вход два числа и выводить, является ли второе
    // число кратным первому. Если число 2 не кратно числу
    // 1, то программа выводит остаток от деления.

    Console.WriteLine("Введите первое число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if (num1 % num2 == 0)
    {
        Console.WriteLine("Кратно.");
    }
    else
    {
        Console.WriteLine($"Не кратно, остаток - {num1 % num2}.");
    }
}

void Ex14()
{
    // Напишите программу, которая принимает на
    // вход число и проверяет, кратно ли оно
    // одновременно 7 и 23.

    int num = Input("Введите число: ");

    if (num % 7 == 0 & num % 23 == 0)
    {
        Console.WriteLine("Да.");
    }
    else
    {
        Console.WriteLine("Нет.");
    }
}

void Ex16()
{
    // Напишите программу, которая принимает на
    // вход два числа и проверяет, является ли одно
    // число квадратом другого.

    int num1 = Input("Введите первое число: ");
    int num2 = Input("Введите второе число: ");

    if (Math.Pow(num1, 2) == num2 | Math.Pow(num2, 2) == num1)
    {
        Console.WriteLine("Да.");
    }
    else
    {
        Console.WriteLine("Нет.");
    }
}

Console.Clear();
Ex16();