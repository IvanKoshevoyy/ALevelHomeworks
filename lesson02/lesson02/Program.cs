using System;

//Homework 2 
namespace lesson02
{
    class Program
    {
        const int N = 20; //Размерность массивов для второго задания
        const string exit = "exit";
        static void Main(string[] args)
        {


            int arraySize;      //Пользователь выбирает размер массива
            int max;
            int min;
            string userChoose;  //Пользователь выбирает между заданиями 
            string sortChoose;   //Пользователь выбирает как именно сортировать массив
            do
            {
                Console.WriteLine("Какое задание желаете выполнить? Введите цифру:\n 1 - первое \n 2 - второе\n exit - выйти из программы ");
                userChoose = Console.ReadLine();

                switch (userChoose)
                {
                    case "1":

                        Console.WriteLine("Введите количество элементов в массиве");
                        arraySize = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите минимальное значение элемента в массиве");
                        min = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите максимальное значение элемента в массиве");
                        max = Convert.ToInt32(Console.ReadLine());

                        firstTask(arraySize, min, max);
                        break;
                    case "2":

                        Console.WriteLine("Введите минимальное значение элемента в массиве");
                        min = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите максимальное значение элемента в массиве");
                        max = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Каким методом желаете отсортировать массив?\n 1 - сортировка пузырьком\n 2 - сортировка вставками");
                        sortChoose = Console.ReadLine();
                        secondTask(min, max, sortChoose);
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


        static void firstTask(int arraySize, int min, int max)
        {
            int[] numbers = new int[arraySize];
            int counter = 0;          //Счетчик элементов, удовлетворяющих условию

            for (int i = 0; i < arraySize; i++)
            {
                numbers[i] = new Random().Next(min, max);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > -100 & numbers[i] < 100)
                {
                    counter++;
                    Console.WriteLine($"{i}. {numbers[i]} ++++++");
                }
                else
                {
                    Console.WriteLine($"{i}. {numbers[i]}");
                }
            }
            Console.WriteLine($"Количество элементов массива удовлетворяющих условию равняется {counter}");
        }

        static void secondTask(int min, int max, string sortChoose)
        {
            int[] A = new int[N];
            int[] B = new int[N];

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = new Random().Next(min, max);
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= 888)
                {
                    B[i] = A[i];
                }
            }
            switch (sortChoose)
            {
                case "1":
                    bubbleSort(B);
                    break;
                case "2":
                    insertionSort(B);
                    break;        
                default:
                    Console.WriteLine("Неправильный ввод");
                    break;
            }

            // вывод
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= 888)
                {
                    Console.WriteLine($"{i}. {A[i]} ++++++");
                }
                else
                {
                    Console.WriteLine($"{i}. {A[i]}");
                }
            }
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < B.Length; i++)
            {
                Console.WriteLine($"{i}. {B[i]}");
            }
        }

    
        //метод обмена элементов
        static void swap(ref int e1, ref int e2)
        {
            int temp = e1;
            e1 = e2;
            e2 = temp;
        }

        //сортировка пузырьком
        static void bubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        swap(ref array[i], ref array[j]);
                    }
                }
            }
        }

        //сортировка вставками
        static void insertionSort(int[] arr)
        {
            int j;
            for (int i = 1; i < arr.Length; i++)
            {
                j = i - 1;
                while (j >= 0 && arr[j + 1] >= arr[j])
                {
                    swap(ref arr[j + 1], ref arr[j]);
                    j--;
                }
            }
        }

        /*static void arrayPrint(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        */
    }

}
