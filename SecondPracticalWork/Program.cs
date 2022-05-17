using System;

namespace SecondPracticalWork
{
    internal class Program
    {
        static string FullName = "Подвальная Алина Олеговна";
        static int Age = 24;
        static string Email = "example@mail.com";
        static double ProgrammingScore = 20.5;
        static double MathScore = 50.4;
        static double PhysicsScore = 30.2;
        static void Main(string[] args)
        {
            Console.WriteLine("1. Создание переменных и вывод:");
            FirstTask();
            Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить...");
            Console.ReadKey();
            Console.WriteLine("_____________________________________");
            Console.WriteLine("\n2. Реализация подсчёта количества баллов по всем предметам:");
            SecondTask();
            Console.WriteLine("\nНажмите любую клавишу, чтобы выйти...");
            Console.ReadKey();
        }

        /// <summary>
        /// Создание переменных и вывод.
        /// </summary>
        static void FirstTask()
        {
            //1 вариант вывода
            Console.WriteLine("1 вариант вывода:");
            Console.WriteLine($"Ф.И.О.: {FullName}");
            Console.WriteLine($"Возраст: {Age}");
            Console.WriteLine($"Почта: {Email}");
            Console.WriteLine($"Баллы по программированию: {ProgrammingScore}");
            Console.WriteLine($"Баллы по математике: {MathScore}");
            Console.WriteLine($"Баллы по физике: {PhysicsScore}");

            //2 вариант вывода
            Console.WriteLine("\n2 вариант вывода:");
            string studentCard = string.Format("Ф.И.О.: {0}\nВозраст: {1}\nПочта: {2}\nБаллы по программированию: {3}\nБаллы по математике: {4}\nБаллы по физике: {5}", FullName, Age, Email, ProgrammingScore, MathScore, PhysicsScore) ;
            Console.WriteLine(studentCard);            
        }
        
        /// <summary>
        /// Реализация подсчёта количества баллов по всем предметам.
        /// </summary>
        static void SecondTask()
        {
            Console.WriteLine($"Баллы по программированию: {ProgrammingScore}");
            Console.WriteLine($"Баллы по математике: {MathScore}");
            Console.WriteLine($"Баллы по физике: {PhysicsScore}");

            double resultScore = Math.Round(ProgrammingScore + MathScore + PhysicsScore, 2);
            double gpa = resultScore / 3;//Grade Point Average

            Console.WriteLine($"\nОбщий балл: {resultScore}");
            Console.WriteLine($"Средний балл: {gpa}");
        }

    }
}
