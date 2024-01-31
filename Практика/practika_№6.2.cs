using System;

class Program
{
    static void Main()
    {
        Console.Write("A");
        char inputChar = ReadCharFromConsole();

        int charCode = GetCharCode(inputChar);

        Console.WriteLine($"\nКод символа '{inputChar}' в таблице Unicode: {charCode}");
    }

    static char ReadCharFromConsole()
    {
        char result;
        while (!char.TryParse(Console.ReadLine(), out result))
        {
            Console.Write("Некорректный ввод. Пожалуйста, введите символ заново: ");
        }
        return result;
    }

    static int GetCharCode(char c)
    {
        return (int)c;
    }
}