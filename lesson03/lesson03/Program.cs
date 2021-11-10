using System;
using System.Globalization;

namespace lesson03
{
    class Program
    {
        static void Main(string[] args)
        {
            string userChoose;  //Пользователь выбирает между заданиями 
            string str;  
            do
            {
                Console.WriteLine("\nКакое задание желаете выполнить? Введите цифру:\n 1 - первое \n 2 - второе \n 3 - третье\n exit - выйти из программы ");
                userChoose = Console.ReadLine();

                switch (userChoose)
                {
                    case "1":
                        Console.WriteLine("Введите строку");
                        str = Console.ReadLine();
                        FirstTask(str);
                        break;
                    case "2":
                        Console.WriteLine("Введите строку");
                        str = Console.ReadLine();
                        SecondTask(str);
                        break;
                    case "3":
                        Console.WriteLine("Введите строку");
                        str = Console.ReadLine();
                        ThirdTask(str);
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("Неправильный ввод");
                        break;
                }
            }
            while (userChoose != "exit");
        }



        static void FirstTask(string str)
        {
            string newStr = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsDigit(str[i]))
                {
                    newStr += str[i];
                }
            }
            Console.WriteLine(newStr);
            string[] arr = newStr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < arr.Length; i++)
            {
                if ((i + 1) % 2 != 0)
                {
                    char[] temp = arr[i].ToCharArray();
                    Array.Reverse(temp);
                    Console.Write(temp);
                }
                else
                {
                    Console.Write($" {arr[i]} ");
                }

            }

        }
        static void SecondTask(string str)
        {
            string[] arr = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            foreach (var value in arr)
                Console.Write($" {ti.ToTitleCase(value)} ");
        }
        static void ThirdTask(string str)
        {
            string[] arr = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < arr.Length; i++)
            {
                char[] temp = arr[i].ToCharArray();
                Console.Write(" ");
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (temp[0] == 'P' || temp[0] == 'p')
                    {
                        temp[0] = 'S';
                    }
                    if (temp[arr[i].Length - 1] == 'N' || temp[arr[i].Length - 1] == 'n')
                    {
                        temp[arr[i].Length - 1] = 'O';
                    }
                    Console.Write(temp[j]);
                }
            }
        }
    }
}

















            











/*string[] arr = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
string newStr = "";
foreach (var value in arr)
{

    if (value.EndsWith("n"))
    {
        string temp = value.ToString();

    }
    else
    {
        Console.Write(value);
    }
}
*/