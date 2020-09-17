using System;
using System.Linq;

namespace Lab_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 21, 58, -7, 6, 13, 41, -13 };
            string word = "Sea lard";
            var results = (Max(array), Min(array), Sum(array), Letter(word));

            Console.WriteLine(results);          

            Console.ReadKey();            
        }
        static int Max(int[] array)       
        {
            int max = array[0];       
            for (int i = 0; i < array.Count(); i++) 
            {
                if (max < array[i])  
                {
                    max = array[i]; 
                }
            }
            return max;   
        }
        static int Min(int[] array)
        { 
            int min = array[0];        
            for (int i = 0; i < array.Count(); i++) 
            {
                if (min > array[i])    
                {
                    min = array[i];  
                }
            }
            return min;    
        }

        static int Sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }
        static string Letter(string word)
        {
            //char first = word.FirstOrDefault();//преобразование
            string first = word.Substring(0, 1);
            return first;
        }
    }
}