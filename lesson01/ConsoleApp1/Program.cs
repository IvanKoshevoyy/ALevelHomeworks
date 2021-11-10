using System;

//Homework 1
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string first_name;
            string second_name;
            int age;
            Console.WriteLine("Введите Ваше имя");
            first_name = Console.ReadLine();
            Console.WriteLine("Введите Вашу фамилию");
            second_name = Console.ReadLine();
            Console.WriteLine("Введите Ваш возраст");
            age = Convert.ToInt32(Console.ReadLine());

            if (age < 40)
            {
                Console.WriteLine($"{first_name} {second_name}, до начала новой жизни вам осталось {40 - age} лет");
            }
            else if (age == 40)
            {
                Console.WriteLine($"{first_name} {second_name}, Вы только начали свою новую жизнь");
            }
            else
            {
                Console.WriteLine($"{first_name} {second_name}, Вы начали новую жизнь {age-40} лет назад");
            }
        }
    }
}
