using System.Diagnostics.CodeAnalysis;
using System.Security.Principal;

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Ex63()
{
    //Задайте значение N. Напишите программу,
    // которая выведет все натуральные числа в промежутке от 1 до N.

    int num = Input("Введите число: ");
    int firstNum = 1;

    string RecPrintNums(int start, int end)
    {
        if (start == end) return start.ToString();
        return start + " " + RecPrintNums(start + 1, end);
    }

    Console.WriteLine(RecPrintNums(firstNum, num));
}

void Ex65()
{
    //Задайте значения M и N.
    //Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

    int num1 = Input("Введите первое число: ");
    int num2 = Input("Введите второе число: ");

    string RecPrintNums(int start, int end)
    {
        if (start == end) return start.ToString();
        return start + " " + RecPrintNums(start + 1, end);
    }

    if (num1 > num2)
    {
        Console.WriteLine(RecPrintNums(num2, num1));
    }
    else if (num1 == num2)
    {
        Console.WriteLine("Числа равны.");
    }
    else
    {
        Console.WriteLine(RecPrintNums(num1, num2));
    }
}

void Ex67()
{
    //Напишите программу, которая будет
    //принимать на вход число и возвращать сумму его цифр.

    int num = Input("Введите число: ");

    int RecSumDig(int num)
    {
        int sum = 0;
        if (num == 0) return sum;
        int n = num % 10;
        return sum + n + RecSumDig(num / 10);
    }
    Console.WriteLine(RecSumDig(num));
}

void Ex69()
{
    //Напишите программу, которая на вход принимает 
    //два числа А и В, и возводите число А в целую степень В с помощью рекусии.

    double num1 = Input("Введите первое число: ");
    double num2 = Input("Введите второе число: ");

    double RecPowNum(double num1, double num2)
    {
        if (num2 == 0) return 1;
        else if (num2 == 1) return num1;
        else if (num2 < 0) return 1/num1 * RecPowNum(1/num1, - num2 - 1);
        return num1 * RecPowNum(num1, num2 - 1);
    }

    Console.WriteLine(RecPowNum(num1, num2));
}

Console.Clear();
Ex69();