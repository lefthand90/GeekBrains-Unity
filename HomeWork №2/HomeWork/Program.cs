using System;
using System.Linq;

namespace HomeWork2
{
    internal class Sample01
    {

        static void Task1()
        {
            Console.WriteLine("===================");
            Console.WriteLine("Выполнение задачи 1");
            Console.WriteLine("===================");

            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите третье число: ");
            int c = int.Parse(Console.ReadLine());

            int minNubmer;

            if (a < b && a < c)
            {
                minNubmer = a;
            }
            else if (b < a && b < c)
            {
                minNubmer = b;
            }
            else
            {
                minNubmer = c;
            }

            Console.WriteLine("Минимальное число из трех: " + minNubmer);
            Console.ReadLine();
        }

        static void Task2()
        {
            Console.WriteLine("===================");
            Console.WriteLine("Выполнение задачи 2");
            Console.WriteLine("===================");

            Console.WriteLine("Введите число любой длины");
            string a = Console.ReadLine();
            int number = a.Length;

            Console.WriteLine("Число состоит из {0} знаков.", number);
            Console.ReadLine();
        }

        static void Task3()
        {
            Console.WriteLine("===================");
            Console.WriteLine("Выполнение задачи 3 - Сумма нечетных чисел. \n При вводе 0 выводится результат.");

            Console.WriteLine("===================");

            int number;
            int sum = 0;
            do
            {
                Console.Write("Введите число: ");
                number = int.Parse(Console.ReadLine());

                if (number > 0)
                {
                    if (number % 2 != 0)
                    {
                        sum += number;
                    }
                }
            }
            while (number < 0 || number > 0);

            Console.WriteLine("Сумма положительных нечетных чисел: " + sum);
            Console.ReadLine();
        }

        static void Task4()
        {
            Console.WriteLine("===================");
            Console.WriteLine("Выполнение задачи 4");
            Console.WriteLine("===================");

            bool value = true;

            for (int t = 0; t <= 3; t++)
            {
                do
                {
                    Console.Write("Введите логин: ");
                    string login = Console.ReadLine();

                    Console.Write("Введите пароль: ");
                    string password = Console.ReadLine();

                    string a = "root";
                    string b = "GeekBrains";

                    if (login != a || password != b)
                    {
                        value = false;
                        Console.WriteLine(value);
                        t++;
                    }
                    else
                    {
                        value = true;
                        t = 3;
                        break;
                    }
                }
                while (t == 3);
            }
            Console.WriteLine("Конец программы: " + value);
            Console.ReadLine();
        }

        static void Task5()
        {
            Console.WriteLine("===================");
            Console.WriteLine("Выполнение задачи 5");
            Console.WriteLine("===================");

            Console.Write("Какой у вас рост? ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Какой у вас вес? ");
            double b = double.Parse(Console.ReadLine());
            
            double result;
            result = (b / ((a / 100) * (a / 100)));

            double i = 0.00;

            if (result > 18.5 && result < 25)
            {
                Console.WriteLine("Ваш индекс массы тела равен: {0:f2}. У вас здоровый вес, так держать!", result);
            }
            else if (result < 18.5)
            {
                Console.WriteLine("Ваш индекс массы тела равен: {0:f2}. У вас недостаточный вес.", result);
                Console.WriteLine("До нормального веса вам не хватает: {0:f2} кг", i = -(result - 18.5) * (b / result));
            }
            else if (result > 25 && result < 30)
            {
                Console.WriteLine("Ваш индекс массы тела равен: {0:f2}. У вас избыточный вес.", result);
                Console.WriteLine("До нормального веса вам надо сбросить: {0:f2}кг", i = (result - 25) * (b / result));
            }
            else
            {
                Console.WriteLine("Ваш индекс массы тела равен: {0:f2}. У вас ожирение, обратитесь к диетологу.", result);
                Console.WriteLine("До нормального веса вам надо сбросить: {0:f2}кг", i = (result - 25) * (b / result));
            }

            Console.ReadLine();
        }

        static void Task6()
        {
            Console.WriteLine("===================");
            Console.WriteLine("Выполнение задачи 6");
            Console.WriteLine("===================");          

            Console.WriteLine("Программа считает количество чисел-Харшад в любом заданном диапазоне, а также выводит сами числа.");
            Console.Write("Введите нижнюю границу диапозона: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Введите верхнюю границу диапозона: ");
            int max = int.Parse(Console.ReadLine());
            int goodnumber = 0;
            int a;
            int b;

            DateTime startTimer = DateTime.Now;

            for (int i = min; i <= max; i++)
            {
                a = 0;
                b = i;
                while (b != 0)
                {
                    a += b % 10;
                    b /= 10;
                }
                if (i % a == 0)
                {
                    //Console.Write(i + ", "); // можно вывести все числа при желании на экран консоли.
                    goodnumber++;
                }
            }

            Console.WriteLine();          
            Console.WriteLine("Количество чисел Харшад в заданном диапазоне: " + goodnumber);
            Console.WriteLine("На выполнение программы ушло: {0} миллисекунд", _ = DateTime.Now - startTimer);
            Console.ReadLine();
        }

        static void Task7()
        {
            Console.WriteLine("===================");
            Console.WriteLine("Выполнение задачи 7");
            Console.WriteLine("===================");

            Console.WriteLine("Введите число а: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            int sum = 0;

            recursion(a, b, sum);
            
            static void recursion(int a, int b, int sum)
            {
                if (a <= b)
                {
                    Console.Write(a + " ");
                    sum += a;
                    a++;
                    recursion(a, b, sum);
                    if (a > b)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Сумма чисел равна: " + sum);
                    }
                }
            }         
            Console.WriteLine("\n");
            Console.ReadLine();

        }


            static void Main(string[] args)
        {
            bool f = true;
            while (f)
            {
                Console.WriteLine("Домашнаяя работа Переборщикова Романа");
                Console.WriteLine("=====================================");
                Console.WriteLine("1 -> Задача 1");
                Console.WriteLine("2 -> Задача 2");
                Console.WriteLine("3 -> Задача 3");
                Console.WriteLine("4 -> Задача 4");
                Console.WriteLine("5 -> Задача 5");
                Console.WriteLine("6 -> Задача 6");
                Console.WriteLine("7 -> Задача 7");
                Console.WriteLine("0 -> Завершение работы приложения");
                Console.WriteLine("===================");
                Console.Write("Введите номер задачи: ");
                int number = int.Parse(Console.ReadLine());
                
                switch (number)
                {
                    case 0:
                        Console.WriteLine("Завершение работы приложения ...");
                        f = false;
                        break;
                    
                    case 1:
                        Task1();
                        break;

                    case 2:
                        Task2();
                        break;
                        
                    case 3:
                        Task3();
                        break;
                        
                    case 4:
                        Task4();
                        break;
                        
                    case 5:
                        Task5();
                        break;

                    case 6:
                        Task6();
                        break;

                    case 7:
                        Task7();
                        break;

                    default:
                        Console.WriteLine("Некорректный номер задачи.\nПовторите попытку ввода.");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
