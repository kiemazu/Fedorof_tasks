using System;
using System.Linq;

class Program {
    static void Main() {
        Console.Write("Введите размер массива N: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        
        for (int i = 0; i < n; i++) {
            Console.Write($"Элемент {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nМассив в обратном порядке:");
        for (int i = n - 1; i >= 0; i--) {
            Console.Write(arr[i] + " ");
        }

        double avg = arr.Average();

        int closest = arr.OrderBy(x => Math.Abs(x - avg)).First();
        
        Console.WriteLine($"\n\nСреднее арифметическое: {avg:F2}");
        Console.WriteLine($"Ближайшее к среднему число: {closest}");
    }
}