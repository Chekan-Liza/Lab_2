using System;

namespace Lab_2_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Tuple<int, string,char,string,ulong>(123, "Hello",'e',"lover", 7934076125); // Конструктор
            Console.WriteLine(t1);
            Console.WriteLine(t1.Item1);
            Console.WriteLine(t1.Item3);
            Console.WriteLine(t1.Item4);

            var t2 = Tuple.Create(12, "Hell");//упрощенная версия

            Console.WriteLine(t1.Equals(t2));

            var i1 = t1.Item1;
            var i2 = t1.Item2;
            var i3 = t1.Item3;
            var i4 = t1.Item4;
            var i5 = t1.Item5;

            Console.WriteLine("Type of 'i1' is : {0} ", i1.GetType());
            Console.WriteLine("Type of 'i2' is : {0} ", i2.GetType());
            Console.WriteLine("Type of 'i3' is : {0} ", i3.GetType());
            Console.WriteLine("Type of 'i4' is : {0} ", i4.GetType());
            Console.WriteLine("Type of 'i5' is : {0} ", i5.GetType());
        }
    }
}
