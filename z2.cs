using System;

class Program {
    static void Main() {
        Console.Write("Введите количество студентов: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Введите количество предметов: ");
        int m = int.Parse(Console.ReadLine());

        int[,] grades = new int[n, m];

        for (int i = 0; i < n; i++) {
            Console.WriteLine($"\nСтудент {i + 1}:");
            for (int j = 0; j < m; j++) {
                Console.Write($"Оценка по предмету {j + 1}: ");
                grades[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nСредние оценки:");
        for (int i = 0; i < n; i++) {
            double sum = 0;
            for (int j = 0; j < m; j++) {
                sum += grades[i, j];
            }
            Console.WriteLine($"Студент {i + 1}: {sum / m:F2}");
        }
    }
}