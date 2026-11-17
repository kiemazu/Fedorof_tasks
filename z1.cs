using System;

class Program {
    static void Main() {
        Console.Write("Введите длину: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введите ширину: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine($"Площадь: {a * b}");
        Console.WriteLine($"Периметр: {2 * (a + b)}");
    }
}