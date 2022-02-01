using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anketa
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Как вас зовут? ");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Здравствуйте, " + FirstName + "!");
            Console.Write("Хотите заполнить небольшую анкету? Да/Нет: ");
            string next = Console.ReadLine();

            if (next == "Нет" || next == "нет")
            {
                Console.WriteLine("Извините за беспокойство");
                Console.ReadLine();
            }
            else
            {
                Console.Write("Какая у вас Фамилия? ");
                string SecondName = Console.ReadLine();
                Console.Write("Сколько вам лет? ");
                string Age = Console.ReadLine();
                Console.Write("Какой у вас рост? ");
                string Growth = Console.ReadLine();
                double a;
                a = Convert.ToDouble(Growth);
                Console.Write("Какой у вас вес? ");
                string Weight = Console.ReadLine();
                double b;
                b = Convert.ToDouble(Weight);

                Console.WriteLine("Вас зовут " + FirstName + " " + SecondName + ". Вам " + Age + " год. Ваш рост " + Growth + " сантиметров, а вес " + Weight + " килограмм.");
                Console.WriteLine("Вас зовут {0} {1}. Вам {2} год. Ваш рост {3} сантиметров, а вес {4} килограмм", FirstName, SecondName, Age, Growth, Weight);
                Console.WriteLine($"Вас зовут {FirstName} {SecondName}. Вам {Age} год. Ваш рост {Growth} сантиметров, а вес {Weight} килограмм");

                Console.Write("Хотите узнать ваш Индекс массы тела (ИМТ)? Да/Нет ");
                string IMT = Console.ReadLine();

                if (IMT == "Нет" || IMT == "нет")
                {
                    Console.WriteLine("Спасибо что воспользовались нашей программой! Всего доброго!");
                }
                else
                {
                    double result;
                    result = (b / ((a / 100) * (a / 100)));
                    Console.WriteLine("Ваш индекс массы тела равен: " + result);


                }

                Console.ReadLine();
            }
        }
    }
}
