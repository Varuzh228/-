using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Введите полный путь к файлу: ");
        string filePath = Console.ReadLine();

        try
        {
            int lineCount = CountLines(filePath);
            Console.WriteLine($"Количество строк в файле: {lineCount}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }

    static int CountLines(string filePath)
    {
        int lineCount = 0;

        using (StreamReader reader = new StreamReader(filePath))
        {
            while (reader.ReadLine() != null)
            {
                lineCount++;
            }
        }

        return lineCount;
    }
}