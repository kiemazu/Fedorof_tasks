using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        while (true) {
            Console.WriteLine("\nКоманды: add (добавить), find (поиск), show (все), exit (выход)");
            Console.Write("Введите команду: ");
            string cmd = Console.ReadLine().ToLower();

            if (cmd == "exit") break;

            if (cmd == "add") {
                Console.Write("Введите имя: ");
                string name = Console.ReadLine();
                Console.Write("Введите номер телефона: ");
                string phone = Console.ReadLine();
                phoneBook[name] = phone; 
                Console.WriteLine("Контакт сохранен.");
            }
            else if (cmd == "find") {
                Console.Write("Введите имя для поиска: ");
                string name = Console.ReadLine();
                if (phoneBook.TryGetValue(name, out string phone)) {
                    Console.WriteLine($"Телефон {name}: {phone}");
                } else {
                    Console.WriteLine("Контакт не найден.");
                }
            }
            else if (cmd == "show") {
                Console.WriteLine("Все контакты:");
                foreach (var kvp in phoneBook) {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                }
            }
        }
    }
}