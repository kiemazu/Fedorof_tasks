using System;

class Program {
    static void Main() {
        int[,] matrix = new int[3, 3];
        Console.WriteLine("Введите 9 чисел через пробел:");
        string[] input = Console.ReadLine().Split(' ');
        for (int i = 0; i < 9; i++) {
            matrix[i / 3, i % 3] = int.Parse(input[i]);
        }

        Console.WriteLine("Стало:");
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                Console.Write(matrix[j, i] + " ");
            }
            Console.WriteLine();
        }
    }
}
