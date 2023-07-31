void Ex1()
{
    // Найти определенный элемент в массиве.

    int[] nums = { 39, 49, 96, 51, 94, 34, 98, 87, 69, 10 };

    Console.WriteLine("Введите число: ");
    int find = Convert.ToInt32(Console.ReadLine());

    int index = 0;
    while (true)
    {
        if (index < nums.Length)
        {
            if (nums[index] == find)
            {
                Console.WriteLine("Такое число есть в массиве с индексом " + index);
                break;
            }
            index++;
        }
        else
        {
            Console.WriteLine("Такого числа нет в массиве.");
            break;
        }
    }
}

void Ex2()
{
    //Заполняем массив случайными числами.

    void FillArray(int[] collection)
    {
        int length = collection.Length;
        int index = 0;
        while (index < length)
        {
            collection[index] = new Random().Next(1, 10);
            index++;
        }
    }

    //Печатаем массив со случайными числами.

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


    //Находим элемент в случайно сгенерированном массиве.
    
    void IndexOf(int[] collection, int find)
    {
        int index = 0;
        while (true)
        {
            if (index < collection.Length)
            {
                if (collection[index] == find)
                {
                    Console.WriteLine("Такое число есть в массиве с индексом " + index);
                    break;
                }
                index++;
            }
            else
            {
                Console.WriteLine("Такого числа нет в массиве.");
                break;
            }
        }
    }

    int[] array = new int[10];

    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    IndexOf(array, 4);

}
