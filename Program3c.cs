using System;
/*Ступенчатый массив представляет собой массив массивов, в котором длина каждого массива может быть разной.
 Следовательно, ступенчатый массив может быть использован для составления таблицы из строк разной длины.*/
namespace Lab_2_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] myArr = new int[3][];// Объявляем ступенчатый массив
            myArr[0] = new int[2];
            myArr[1] = new int[3];
            myArr[2] = new int[4];

            for (int i=0; i < 2; i++)// Инициализируем ступенчатый массив
            {
                myArr[0][i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                myArr[1][i] = int.Parse(Console.ReadLine()); 
            }

            Console.WriteLine();

            for (int i = 0; i < 4; i++)
            {
                myArr[2][i] = int.Parse(Console.ReadLine()); 
            }
        }
    }
}
