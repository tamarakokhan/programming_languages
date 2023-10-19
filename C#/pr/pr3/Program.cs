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


void Ex19()
{
    // Напишите программу, которая принимает на
    // вход пятизначное число и проверяет, является ли оно
    // палиндромом.

    int num = Input("Введите пятизначное число: ");

    if (num < 10000 || num > 99999) Console.WriteLine("Это не пятизначное число, введите пятизначное.");

    else
    {
        int n5 = num % 10;
        int n4 = num / 10 % 10;
        int n1 = num / 10000;
        int n2 = num / 1000 % 10;
        if (n1 == n5 && n2 == n4) Console.WriteLine($"Да, число {num} палиндром.");
        else Console.WriteLine($"Нет, число {num} не палиндром.");
    }


    int reverse = 0;
    int temp = num;
    while (temp > 0)
    {
        reverse = reverse * 10 + temp % 10;
        temp /= 10;
    }
    if (reverse == num) Console.WriteLine($"Да, число {num} палиндром.");
    else Console.WriteLine($"Нет, число {num} не палиндром.");
}

void Ex21()
    {
        // Напишите программу, которая принимает на
        // вход координаты двух точек и находит расстояние
        // между ними в 3D пространстве.

        double x1 = Input_double("Введите х-координату первой точки: ");
        double y1 = Input_double("Введите y-координату первой точки: ");
        double z1 = Input_double("Введите z-координату первой точки: ");
        double x2 = Input_double("Введите х-координату второй точки: ");
        double y2 = Input_double("Введите y-координату второй точки: ");
        double z2 = Input_double("Введите z-координату второй точки: ");

        double c = Math.Round(
                   Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)), 2
                   );


        Console.WriteLine($"Расстояние между точкой А ({x1}, {y1}, {z1}) и В ({x2}, {y2}, {z2}) равно {c}.");
    }

void Ex23()
    {
        // Напишите программу, которая принимает на
        // вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

        int n = Input("Введите число: ");
        for (int i = 1; i <= n; i++)
        {
            Console.Write((Math.Pow(i, 3)) + " ");
        }
    }

Console.Clear();
