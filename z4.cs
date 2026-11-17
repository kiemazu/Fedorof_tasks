using System;

class Program {
    static void Main() {
        double[] averages = new double[3];

        for (int i = 0; i < 3; i++) {
            Console.WriteLine($"Студент {i + 1}:");
            double sum = 0;
            for (int j = 0; j < 5; j++) {
                Console.Write($"Оценка {j + 1}: ");
                sum += double.Parse(Console.ReadLine());
            }
            averages[i] = sum / 5;
        }

        Console.WriteLine($"Средние оценки: {averages[0]:F2}, {averages[1]:F2}, {averages[2]:F2}");
    }
}