using System;
using System.Xml.Serialization;

while (true)
{
    Console.WriteLine("Выберите операцию");
    Console.WriteLine("1." + "Угадай число ");
    Console.WriteLine("2." + "Таблица умножения");
    Console.WriteLine("3." + "Все делители числа");
    Console.WriteLine("4." + "Выход");
    Console.Write("Введите номер операции:");
    int choice = int.Parse(Console.ReadLine());

    if (choice == 1)
    {
        Random random = new Random();
        int targetNumber = random.Next(101);

        Console.WriteLine("Добро пожаловать в игру \"Угадай число\"!");
        Console.WriteLine("Я загадал число от 0 до 100. Попробуйте угадать.");

        int attempts = 0;
        bool guessed = false;

        while (!guessed)
        {
            Console.Write("Ваше число: ");
            string input = Console.ReadLine();
            int guess;

            if (int.TryParse(input, out guess))
            {
                attempts++;

                if (guess < targetNumber)
                {
                    Console.WriteLine("Загаданное число больше.");
                }
                else if (guess > targetNumber)
                {
                    Console.WriteLine("Загаданное число меньше.");
                }
                else
                {
                    Console.WriteLine($"Вы угадали число за {attempts} попыток. Поздравляю!");
                    guessed = true;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Попробуйте снова.");
            }
        }
    }


    if (choice == 2)
    {
        static void Calculate(int[] numbers)
        {
            int[] CalculateMultTable = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Calculate(CalculateMultTable);
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = numbers[i] * numbers[i];
                }
            }
        }
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write((i * j).ToString() + "\t");
            }
            Console.WriteLine();
        }
    
    }
    if (choice == 3)
    {
        Console.Write("Введите число: ");
        string input = Console.ReadLine();
        int number;

        if (int.TryParse(input, out number))
        {
            Console.WriteLine($"Делители числа {number}:");

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
    if (choice == 4)
    {
        Console.WriteLine("Программа завершена.");
        break;
    }
}