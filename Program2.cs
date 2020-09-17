using System;
using System.Text;
//Строковые литералы представляют строки.
namespace Lab_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Газета \"Правда\"");
            Console.WriteLine("Добрый \nдень!");

            string str_1 = "Hello World!";
            Console.WriteLine(String.Compare(str_1, "Hello World?"));//Сравнивает значения двух строк. Возвращает целочисленное значение.

            string str_2 = "Hello World";
            Console.WriteLine(str_2.Equals("Hello World"));//Определяет идентичность двух строк.

            string Example1 = "Apple";
            string Example2 = new String('Y', 5); // результатом будет строка "YYYYY"
            string Example3 = new String(new char[] { 's', 'u', 'm', 'm', 'e','r' });

            string Ex3_1 = String.Concat(Example3, Example1);
            Console.WriteLine(Ex3_1);

            string Ex1 = String.Copy(Example1);
            Console.WriteLine(Ex1);

            Console.WriteLine(Example3.Substring(3));

            const string Text = "Разделение строки: Вспомнили всё, что хотели забыть!";
            string[] words = Text.Split(new[] { ' ', ',', ':', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);//исп. в кач-ве разделителя
            //Избавится от пустых элементов массива: добавить к методу String.Split перечисление StringSplitOptions.RemoveEmptyEntries
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            string text = "Nice  day";
            Console.WriteLine(text);
            text = text.Insert(5, Example3);
            Console.WriteLine(text);

            string s1 = "Я люблю программировать!";
            Console.WriteLine(s1);
            string s2 = s1.Remove(8, 15);
            /*Remove(Позиция, ЧислоСимволов) удаляет заданное число символов из строки начиная с указанной позиции.
            Если число символов не указано, то строка завершится на указанной позиции.*/
            Console.WriteLine(s2);
            Console.WriteLine(s2.Insert(8, "рисовать"));
            //Insert(Позиция, подстрока) – вставляет подстроку в строку начиная с указанной позиции.

            string empty = "";
            Console.WriteLine(empty == ""); // True
            //"" - литерал пустой строки, константа
            Console.WriteLine(empty == string.Empty); // True
            //string.Empty - это статическое поле.
            Console.WriteLine(empty.Length == 0); // True

            string nullString = null;
            Console.WriteLine(nullString == null); // True
            Console.WriteLine(nullString == ""); // False

            //Статический метод string.IsNullOrEmpty позволяет проверить является ли строка null или пустой.

            StringBuilder sb = new StringBuilder("можем помолчать");
            sb.Append("!");//этот метод добавляет к строке подстроку.
            sb.Insert(0, "Мы ");//вставляет подстроку в объект StringBuilder, начиная с определенного индекса
            Console.WriteLine(sb);

            // заменяем слово
            sb.Replace("помолчать", "петь");//заменяет все вхождения определенного символа или подстроки на другой символ или подстроку
            Console.WriteLine(sb);

            // удаляем 13 символов, начиная с 7-го
            sb.Remove(13, 1);//удаляет определенное количество символов, начиная с определенного индекса
            Console.WriteLine(sb);

            sb.AppendFormat("...");//добавляет подстроку в конец объекта StringBuilder
            Console.WriteLine(sb);

            // получаем строку из объекта StringBuilder
            string s = sb.ToString();
            Console.WriteLine(s);

            /*Класс StringBuilder рекомендуется использовать в следующих случаях:
            -При неизвестном количестве операций и изменений над строками во время выполнения программы
            -Когда предполагается, что приложению придется сделать множество подобных операций*/

            Console.ReadKey();
        }
    }
}
