using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        Dictionary<string, int> fruits = new Dictionary<string, int>();

        while (true) {
            Console.Write("Введите фрукт (или 'exit' для выхода): ");
            string input = Console.ReadLine().ToLower();

            if (input == "exit") break;

            if (fruits.ContainsKey(input)) {
                fruits[input]++;
            } else {
                fruits[input] = 1;
            }
            Console.WriteLine($"Добавлено: {{{input}:{fruits[input]}}}");
        }

        Console.WriteLine("\nИтоговый словарь:");
        foreach (var kvp in fruits) {
            Console.WriteLine($"{kvp.Key} = {kvp.Value}");
        }
    }
}