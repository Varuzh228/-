using System;

class Program
{
    static void Main()
    {
        Console.Write("привет привет мой дорогой друг");
        string sentence = Console.ReadLine();

        Console.Write("привет");
        string wordToCount = Console.ReadLine();

        int count = CountWordOccurrences(sentence, wordToCount);
        Console.WriteLine($"Слово \"{wordToCount}\" встречается в предложении {count} раз(а).");
    }

    static int CountWordOccurrences(string sentence, string word)
    {
        // Разделение предложения на слова по пробелам
        string[] words = sentence.Split(' ');

        int count = 0;
        foreach (string w in words)
        {
            // Сравнение слова с каждым словом в предложении (без учета регистра)
            if (string.Equals(w, word, StringComparison.OrdinalIgnoreCase))
            {
                count++;
            }
        }

        return count;
    }
}