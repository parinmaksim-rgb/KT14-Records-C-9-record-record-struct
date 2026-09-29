using System;

namespace KT14
{
    class Program
    {
        static void Main()
        {
            var person = new Person("Иван", 20);
            var personStruct = new PersonStruct("Иван", 20);

            while (true)
            {
                Console.WriteLine("\n=========================================");
                Console.WriteLine("Выберите действие для проверки:");
                Console.WriteLine("1. Сравнение new Person(\"Иван\", 20) == new Person(\"Иван\", 20)");
                Console.WriteLine("2. Использование with: person with { Age = 21 }");
                Console.WriteLine("3. Деконструкция: var (name, age) = person;");
                Console.WriteLine("4. Изменение напрямую: personStruct.Age = 30;");
                Console.WriteLine("0. Выход");
                Console.Write("Ваш выбор: ");

                string? choice = Console.ReadLine()?.Trim();
                Console.WriteLine("-----------------------------------------");

                if (string.IsNullOrEmpty(choice))
                {
                    Console.WriteLine("Вы ничего не ввели. Пожалуйста, укажите номер действия (от 0 до 4).");
                    continue;
                }

                switch (choice)
                {
                    case "1":
                        var person1 = new Person("Иван", 20);
                        var person2 = new Person("Иван", 20);
                        bool isEqual = person1 == person2;
                        Console.WriteLine($"Результат: {isEqual}");
                        break;

                    case "2":
                        var updatedPerson = person with { Age = 21 };
                        Console.WriteLine($"Новый объект: {updatedPerson.Name}, Age == {updatedPerson.Age}");
                        Console.WriteLine($"Оригинал: {person.Name}, Age == {person.Age}");
                        break;

                    case "3":
                        var (name, age) = person;
                        Console.WriteLine($"name получает значение: {name}");
                        Console.WriteLine($"age получает значение: {age}");
                        break;

                    case "4":
                        personStruct.Age = 30;
                        Console.WriteLine($"personStruct.Age после изменения: {personStruct.Age}");
                        break;

                    case "0":
                        Console.WriteLine("Завершение программы.");
                        return;

                    default:
                        Console.WriteLine("Неверный ввод. Пожалуйста, введите существующий номер из меню (от 0 до 4).");
                        break;
                }
            }
        }
    }
}