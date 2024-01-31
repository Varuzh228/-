using System;

class SortingAlgorithms
{
    public static void Bogosort(int[] array)
    {
        Random random = new Random();
        while (!IsSorted(array))
        {
            Shuffle(array, random);
        }
    }

    public static void ShellSort(int[] array)
    {
        int n = array.Length;
        for (int gap = n / 2; gap > 0; gap /= 2)
        {
            for (int i = gap; i < n; i += 1)
            {
                int temp = array[i];
                int j;
                for (j = i; j >= gap && array[j - gap] > temp; j -= gap)
                {
                    array[j] = array[j - gap];
                }
                array[j] = temp;
            }
        }
    }

    private static bool IsSorted(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] > array[i])
                return false;
        }
        return true;
    }

    private static void Shuffle(int[] array, Random random)
    {
        int n = array.Length;
        for (int i = n - 1; i > 0; i--)
        {
            int j = random.Next(0, i + 1);
            Swap(array, i, j);
        }
    }

    private static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

class Program
{
    static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Введите элементы массива через пробел (например, 3 1 4 1 5):");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                exit = true;
            }
            else
            {
                try
                {
                    int[] array = Array.ConvertAll(input.Split(' '), int.Parse);

                    Console.WriteLine("Выберите метод сортировки:");
                    Console.WriteLine("1. Болотная сортировка");
                    Console.WriteLine("2. Сортировка Шелла");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            SortingAlgorithms.Bogosort(array);
                            break;
                        case 2:
                            SortingAlgorithms.ShellSort(array);
                            break;
                        default:
                            Console.WriteLine("Некорректный выбор.");
                            break;
                    }

                    Console.WriteLine("Отсортированный массив:");
                    PrintArray(array);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка ввода. Пожалуйста, введите целые числа через пробел.");
                }
            }
        }
    }

    private static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
