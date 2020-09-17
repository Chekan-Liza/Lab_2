using System;
/*Неявно типизированные переменные – это переменные, для которых отсутствует определение типа при их объявлении (например int, float).
 Вместо названия типа используется ключевое слово var.*/
namespace Lab_2_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var Array_1 = new[] { 126, 54, 83 }; // int
            var Array_2 = new[] { 'R', '!' }; // char
            var Array_3 = new[] { 12.16, 9.8 }; // double

            var Array_4 = new[,] { { 662, 37 },
                                  { 21, 1 } };

            var string_1 = "Cake";

            Console.WriteLine("Type of 'Array_1' is : {0} ", Array_1.GetType());
            Console.WriteLine("Type of 'Array_2' is : {0} ", Array_2.GetType());
            Console.WriteLine("Type of 'Array_3' is : {0} ", Array_3.GetType());
            Console.WriteLine("Type of 'Array_4' is : {0} ", Array_4.GetType());
            Console.WriteLine("Type of 'string_1' is : {0} ", string_1.GetType());
        }
    }
}
