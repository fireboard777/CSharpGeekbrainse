using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Четные числа от 1 до " + n + ": ");
        for (int i = 2; i <= n; i += 2)
        {
            Console.Write(i + " ");
        }

        Console.ReadLine();
    }
}