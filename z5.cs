using System;

class Program {
    static void Main() {
        int[,] matrix = new int[3, 3];
        Console.WriteLine("Введите 9 чисел через пробел:");
        
        // Чтение чисел в одну строку и разбиение по пробелам
        string[] input = Console.ReadLine().Split(' ');
        
        // Заполнение исходной матрицы
        for (int i = 0; i < 9; i++) {
            matrix[i / 3, i % 3] = int.Parse(input[i]);
        }

        Console.WriteLine("Стало:");
        // Вывод транспонированной матрицы (столбцы становятся строками)
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                Console.Write(matrix[j, i] + " ");
            }
            Console.WriteLine();
        }
    }
}