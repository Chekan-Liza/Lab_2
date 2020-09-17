using System;

namespace Lab_2_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Seasons = { "Autumn", "Winter", "Spring","Summer" };// Инициализация массива строк

            for (int i = 0; i < Seasons.Length; i++)// Вывод массива строк в цикле
                Console.WriteLine("Season [{0}]: {1}", i, Seasons[i]);

            int length = Seasons.Length;
            Console.WriteLine("Длина массива = "+length);

            Console.WriteLine("Введите номер заменяемого элемента: ");
            int x;
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите новую строку: ");
            string str;
            str = Console.ReadLine();

            Seasons[x] = str;

            for (int i = 0; i < Seasons.Length; i++)
                Console.WriteLine("Season [{0}]: {1}", i, Seasons[i]);
        }
    }
}
