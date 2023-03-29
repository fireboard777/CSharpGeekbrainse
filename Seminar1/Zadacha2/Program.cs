using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите первое число: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Введите третье число: ");
        int c = int.Parse(Console.ReadLine());

        int max = Math.Max(a, Math.Max(b, c));

        Console.WriteLine("Максимальное число: " + max);

        Console.ReadLine();
    }
}
