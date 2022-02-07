using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        struct Complex
        {
            public double im;
            public double re;

            public Complex Plus(Complex x)
            {
                Complex y;
                y.re = re + x.re;
                y.im = im + x.im;
                return y;
            }

            public Complex Minus(Complex x)
            {
                Complex y;
                y.re = re - x.re;
                y.im = im - x.im;
                return y;
            }

            public Complex Multi(Complex x)
            {
                Complex y;
                y.re = re * x.re - im * x.im;
                y.im = re * x.im + im * x.re;
                return y;
            }

            public override string ToString()
            {
                return $"{re} + {im}i";
            }
        }


        static void Task1()
        {
            Console.Write("(1) Введите действительную часть комплексного числа: ");
            double inputRe = double.Parse(Console.ReadLine());
            Console.Write("(1) Введите мнимую часть комплексного числа: ");
            double inputIm = double.Parse(Console.ReadLine());

            Console.Write("(2) Введите действительную часть комплексного числа: ");
            double inputRe02 = double.Parse(Console.ReadLine());
            Console.Write("(2) Введите мнимую часть комплексного числа: ");
            double inputIm02 = double.Parse(Console.ReadLine());

            Complex complex01;
            complex01.re = inputRe;
            complex01.im = inputIm;

            Complex complex02;
            complex02.re = inputRe02;
            complex02.im = inputIm02;

            Console.WriteLine($"Первое комплексное число: {complex01}");
            Console.WriteLine($"Второе комплексное число: {complex02}");

            Console.WriteLine($"Результат сложения комплексных чисел: {complex01.Plus(complex02)}");
            Console.ReadKey();
        }

        static void Task2()
        {
            Console.Write("(1) Введите действительную часть комплексного числа: ");
            double inputRe = double.Parse(Console.ReadLine());
            Console.Write("(1) Введите мнимую часть комплексного числа: ");
            double inputIm = double.Parse(Console.ReadLine());

            Console.Write("(2) Введите действительную часть комплексного числа: ");
            double inputRe02 = double.Parse(Console.ReadLine());
            Console.Write("(2) Введите мнимую часть комплексного числа: ");
            double inputIm02 = double.Parse(Console.ReadLine());

            Complex complex01;
            complex01.re = inputRe;
            complex01.im = inputIm;

            Complex complex02;
            complex02.re = inputRe02;
            complex02.im = inputIm02;

            Console.WriteLine($"Первое комплексное число: {complex01}");
            Console.WriteLine($"Второе комплексное число: {complex02}");

            Console.WriteLine($"Результат вычетания комплексных чисел: {complex01.Minus(complex02)}");
            Console.ReadKey();
        }

        static void Task3()
        {
            Console.Write("(1) Введите действительную часть комплексного числа: ");
            double inputRe = double.Parse(Console.ReadLine());
            Console.Write("(1) Введите мнимую часть комплексного числа: ");
            double inputIm = double.Parse(Console.ReadLine());

            Console.Write("(2) Введите действительную часть комплексного числа: ");
            double inputRe02 = double.Parse(Console.ReadLine());
            Console.Write("(2) Введите мнимую часть комплексного числа: ");
            double inputIm02 = double.Parse(Console.ReadLine());

            Complex complex01;
            complex01.re = inputRe;
            complex01.im = inputIm;

            Complex complex02;
            complex02.re = inputRe02;
            complex02.im = inputIm02;

            Console.WriteLine($"Первое комплексное число: {complex01}");
            Console.WriteLine($"Второе комплексное число: {complex02}");

            Console.WriteLine($"Результат умножения комплексных чисел: {complex01.Multi(complex02)}");
            Console.ReadKey();
        }

        static void Task4()
        {

            int a = 0;
            int sum = 0;
            do
            {
                Console.Write("Введите значение: ");
                string input = Console.ReadLine();
                bool inputString = int.TryParse(input, out a);
                if (a > 0)
                {
                    if (a % 2 != 0)
                    {
                        sum += a;
                    }
                }
            }
            while (a < 0 || a > 0);

            Console.WriteLine("Сумма положительных нечетных чисел: " + sum);
            Console.ReadKey();
        }

            static void Main(string[] args)
            {
            bool f = true;
            while (f)
            {
                Console.WriteLine("Домашняя работа Переборщикова Романа");
                Console.WriteLine("=====================================");
                Console.WriteLine("1 -> Сложение комплексных чисел");
                Console.WriteLine("2 -> Вычитание комплексных чисел");
                Console.WriteLine("3 -> Произведение комплексных чисел");
                Console.WriteLine("4 -> Сумма нечетных положительных чисел");
                Console.WriteLine("0 -> Завершение работы приложения");
                Console.WriteLine("====================================");
                Console.Write("Введите номер задачи: ");
                int number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 0:
                        Console.WriteLine("Завершение работы приложения.......");
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

                    default:
                        Console.WriteLine("Некорректный номер задачи.\nПовторите попытку ввода.");
                        break;
                }
            }
        }
    }
}