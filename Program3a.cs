using System;

namespace Lab_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
          
            int[,] myArr = new int[n, m];  // Объявляем двумерный массив
            Random ran = new Random();/*объект – ran, принадлежащий к классу Random,
            метод которого (функция Next() ) возвращает целое число в заданном диапазоне (1,15).*/
            
            for (int i = 0; i < n; i++)// Инициализируем массив
            {
                for (int j = 0; j < m; j++)
                {
                    myArr[i, j] = ran.Next(1, 15);
                    Console.Write("{0}\t", myArr[i, j]);

                }
                Console.WriteLine();
            }
        }
    }
}
