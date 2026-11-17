using System;

class Program {
    static void Main() {
        Console.Write("Введите текущий курс доллара: ");
        double rate = double.Parse(Console.ReadLine());
        Console.Write("Введите сумму в рублях: ");
        double rub = double.Parse(Console.ReadLine());

        Console.WriteLine($"В долларах: {rub / rate:F2}");
    }
}