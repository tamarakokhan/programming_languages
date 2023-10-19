﻿//Ничего не принимает и ничего не возвращает
void Method1()
{
    Console.WriteLine("Автор ...");
}

//Принимает, но не возвращает

void Method2(string msg)
{
    Console.WriteLine(msg);
}

void Method2_1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

//Не принимают, но возвращают
int Method3()
{
    return DateTime.Now.Year;
}

//Принимают и возвращают
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

//Цикл for
string Method4_1(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

// Method1();
// Method2("Текст сообщения");
// Method2_1("Текст", 4);
// Method2_1(count: 4, msg: "Новый текст");
// int year = Method3();
// Console.WriteLine(year);
// string res1 = Method4(10, "qwerty");
// Console.WriteLine(res1);
// string res2 = Method4_1(10, "qwerty");
// Console.WriteLine(res2);

void Ex1()
{
    for (int i = 2; i <= 10; i++)
    {
        for (int j = 2; j <= 10; j++)
        {
            Console.WriteLine($"{i} * {j} = {i * j}");
        }
        Console.WriteLine();
    }
}

void Ex2()
{
    // Дан текст. В тексте нужно все побелы заменить черточками, 
    // маленькие буквы "к" заменить большими "К", а большие "С" заменить маленькми "с".
    string txt = "– Я думаю, – сказал князь, улыбаясь, – что, "
                 + " ежели бы вас послали вместо нашего милого Винценгероде, "
                 + "вы бы взяли приступом согласие прусского короля. "
                 + "Вы так красноречивы. Вы дадите мне чаю?";

    string Replace(string text, char oldValue, char newValue)
    {
        string result = String.Empty;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == oldValue) result = result + $"{newValue}";
            else result = result + $"{text[i]}";
        }
        return result;
    }

    string newText = Replace(txt, ' ', '-');
    Console.WriteLine(newText);
    Console.WriteLine();
    newText = Replace(newText, 'к', 'К');
    Console.WriteLine(newText);
    Console.WriteLine();
    newText = Replace(newText, 'С', 'с');
    Console.WriteLine(newText);
}

void Ex3() //Сортировка массива от минимального к максимальному
{
    int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

    void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }

    void SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minPosition = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minPosition]) minPosition = j;
            }
            int temporary = array[i];
            array[i] = array[minPosition];
            array[minPosition] = temporary;
        }
    }
    PrintArray(arr);
    SelectionSort(arr);
    PrintArray(arr);
}

void Ex4() //Сортировка массива от максимального к минимальному
{
    int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

    void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }

    void SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int maxPosition = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] > array[maxPosition]) maxPosition = j;
            }
            int temporary = array[i];
            array[i] = array[maxPosition];
            array[maxPosition] = temporary;
        }
    }
    PrintArray(arr);
    SelectionSort(arr);
    PrintArray(arr);
}

Ex4();