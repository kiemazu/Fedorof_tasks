using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<int> numbers = new List<int>();
        HashSet<int> seen = new HashSet<int>();

        Console.WriteLine("Вводите числа (ввод остановится при повторе):");
        while (true) {
            int num = int.Parse(Console.ReadLine());
            if (seen.Contains(num)) {
                break; 
            }
            seen.Add(num);
            numbers.Add(num);
        }

        Console.WriteLine("\nВведенный массив:");
        Console.WriteLine(string.Join(" ", numbers));
    }
}