using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        int thirdDigit = (number / 100) % 10;

        if (thirdDigit == 0)
        {
            Console.WriteLine("Третьей цифры нет");
        }
        else
        {
            Console.WriteLine("Третья цифра числа: " + thirdDigit);
        }

        Console.ReadLine();
    }
}