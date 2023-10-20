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

void Ex17()
{
    // Напишите программу, которая принимает на вход
    // координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
    // номер четверти плоскости, в которой находится эта
    // точка.

    int x = Input("Введите число x: ");
    int y = Input("Введите число y: ");

    if (x > 0 && y > 0) Console.WriteLine($"Точка с координатами х = {x}, y = {y} лежит в I четверти.");
    else if (x < 0 && y > 0) Console.WriteLine($"Точка с координатами х = {x}, y = {y} лежит во II четверти.");
    else if (x < 0 && y < 0) Console.WriteLine($"Точка с координатами х = {x}, y = {y} лежит в III четверти.");
    else if (x > 0 && y < 0) Console.WriteLine($"Точка с координатами х = {x}, y = {y} лежит в IV четверти.");
    else Console.WriteLine($"Точка с координатами х = {x}, y = {y} лежит на оси.");
}


void Ex18()
{
    // Напишите программу, которая по
    // заданному номеру четверти, показывает диапазон
    // возможных координат точек в этой четверти (x и y).

    int n = Input("Введите номер четверти: ");

    if (n == 1) Console.WriteLine($"В {n} четверти x > 0, y > 0.");
    else if (n == 2) Console.WriteLine($"Во {n} четверти x < 0, y > 0.");
    else if (n == 3) Console.WriteLine($"В {n} четверти x < 0, y < 0.");
    else if (n == 4) Console.WriteLine($"В {n} четверти x > 0, y < 0.");
    else Console.WriteLine("Нет такой четверти.");


    switch (n)
    {
        case 1:
        {
            Console.WriteLine($"В {n} четверти x > 0, y > 0.");  
            break;      
        }
        case 2:
        {
            Console.WriteLine($"Во {n} четверти x < 0, y > 0.");  
            break;      
        }
        case 3:
        {
            Console.WriteLine($"В {n} четверти x < 0, y < 0.");  
            break;      
        }
        case 4:
        {
            Console.WriteLine($"В {n} четверти x > 0, y < 0.");  
            break;      
        }
        default:
        {
            Console.WriteLine("Нет такой четверти.");
            break;
        }
    }
}

void Ex21()
{
    // Напишите программу, которая
    // принимает на вход координаты двух точек и
    // находит расстояние между ними в 2D
    // пространстве.

    double x1 = Input_double("Введите х-координату первой точки: ");
    double y1 = Input_double("Введите y-координату первой точки: ");
    double x2 = Input_double("Введите х-координату второй точки: ");
    double y2 = Input_double("Введите y-координату второй точки: ");

    double c = Math.Round(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)), 3);

    Console.WriteLine($"Расстояние между точкой А ({x1}, {y1}) и В ({x2}, {y2}) равно {c}");
}

void Ex22()
{
    // Напишите программу, которая
    // принимает на вход число (N) и выдаёт таблицу
    // квадратов чисел от 1 до N.

    int n = Input("Введите число: ");
    for (int i = 1; i <= n; i++)
    {
        Console.Write((Math.Pow(i, 2)) + " ");
    }
}

Console.Clear();
Ex18();