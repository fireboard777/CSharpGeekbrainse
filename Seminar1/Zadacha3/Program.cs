using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Число чётное");
        }
        else
        {
            Console.WriteLine("Число нечётное");
        }

        Console.ReadLine();
    }
}