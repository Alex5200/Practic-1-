using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Задание 1, калькулятор для алгебраических действий");
        Console.WriteLine("Введите 1 число");
        string? string_num1 = Console.ReadLine();
        Console.WriteLine("Введите 2 число");
        string? string_num2 = Console.ReadLine();
        Console.WriteLine("Введите алгебраическое действие");
        string? string_operaitor = Console.ReadLine();

        int final_num = 0;

        try
        {
            int num1 = Convert.ToInt16(string_num1);
            int num2 = Convert.ToInt16(string_num2);

            char operaitor = Convert.ToChar(string_operaitor);

            if (operaitor == '-')
            {
                final_num = num1 - num2;
            }
            else if (operaitor == '+')
            {
                final_num = num1 + num2;
            }
            else if (operaitor == '/')
            {
                final_num = num1 / num2;
            }
            else if (operaitor == '*')
            {
                final_num = num1 * num2;
            }
            Console.WriteLine("Ответ: " + final_num);
        }
        catch
        {
            Console.WriteLine("err operator or num");
        }

    }
}