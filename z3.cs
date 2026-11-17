using System;

class Program {
    static void Main() {
        double sum = 0;
        for (int i = 1; i <= 7; i++) {
            Console.Write($"Введите температуру за {i}-й день: ");
            sum += double.Parse(Console.ReadLine());
        }
        Console.WriteLine($"Средняя температура: {sum / 7:F2}");
    }
}