using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Program
    {
        static void Task1()
        {
            int[] array = new int[20];
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                array[i] = random.Next(-10000, 10001);
            }
            
            DelenieNaTri();
            PrintArray(array);
            Console.WriteLine();
            Console.ReadLine();

            int DelenieNaTri()
            {
                int count = 0;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] % 3 == 0 || array[i + 1] % 3 == 0)
                        count++;
                    Console.WriteLine("Пара чисел: {0} и {1}", array[i], array[i + 1]);
                }
                Console.WriteLine("Количество пар: " + count);
                return count;
            }

            void PrintArray(int[] arr)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    Console.Write($"{arr[i]}  ");
                }
            }
        }

        static void Task2()
        {
            string LogIn = AppDomain.CurrentDomain.BaseDirectory + "login.txt";
            string fileUsername = string.Empty;
            string filePassword = string.Empty;
            int again = 0;
            int re = 0;
            bool value = true;

            for (int t = 0; t <= 3; t++)
            {
                do
                {
                    string[] massiv = new string[100];
                    Console.Write("Введите логин: ");
                    string login = Console.ReadLine();
                    Console.Write("Введите пароль: ");
                    string password = Console.ReadLine();
                    using (StreamReader str = new StreamReader(LogIn))

                        for (int i = 0; i < massiv.Length; i++)
                            massiv[i] = str.ReadLine();
                    for (int i = 0; i < massiv.Length; i++)
                    {
                        if (massiv[i] == null)
                            break;
                        int to = massiv[i].IndexOf(';');
                        fileUsername = massiv[i].Substring(0, to);
                        filePassword = massiv[i].Substring(++to);
                        if (login == fileUsername && password == filePassword)
                        {
                            Console.WriteLine("Hello: " + fileUsername);
                            re = 0;
                            break;
                        }
                        else
                            re++;
                    }
                    if (re++ > 0)
                    {
                        again++;
                        Console.WriteLine("Логин и пароль не верные! Попробуйте еще раз!");
                    }
                } while (again == 3);
            }
            Console.WriteLine("Конец программы: " + value);
            Console.ReadLine();

        }

        static void Main(string[] args)
        {
            bool f = true;
            while (f)
            {
                Console.WriteLine("Домашняя работа Переборщикова Романа");
                Console.WriteLine("=====================================");
                Console.WriteLine("1 -> Целочисленный массив");
                Console.WriteLine("2 -> Логин/Пароль");
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

                    default:
                        Console.WriteLine("Некорректный номер задачи.\nПовторите попытку ввода.");
                        break;
                }
            }
        }
    }
}