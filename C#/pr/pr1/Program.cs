void Ex2()
{
    // Напишите программу, которая на вход принимает 
    // два числа и выдаёт, какое число большее, а какое меньшее.

    Console.WriteLine("Введите первое число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if (num1 > num2)
    {
        Console.WriteLine("Max = " + num1);
    }
    else
    {
        Console.WriteLine("Max = " + num2);
    }
}

void Ex4()
{
    //  Напишите программу, которая принимает 
    //  на вход три числа и выдаёт максимальное из этих чисел.

    Console.WriteLine("Введите первое число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите третье число: ");
    int num3 = Convert.ToInt32(Console.ReadLine());

    // max = Math.Max(a, Math.Max(b, c));

    Console.WriteLine("Max = " + Math.Max(num1, Math.Max(num2, num3)));
}

void Ex6()
{
    // Напишите программу, которая на вход принимает число 
    // и выдаёт, является ли число чётным (делится ли оно на два без остатка).

    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num % 2 == 0)
    {
        Console.WriteLine("Да, число четное.");
    }
    else
    {
        Console.WriteLine("Нет, число нечетное.");
    }
}

void Ex8()
{
    // Напишите программу, которая на вход принимает 
    // число (N), а на выходе показывает все чётные числа от 1 до N.

    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= num; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write(i + " ");
        }
    }
}
