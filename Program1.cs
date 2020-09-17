using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Value1; /*хранит значение true или false (логические литералы)*/
            Value1 = true;
            byte Value2 = 3; /*хранит целое число от 0 до 255 и занимает 1 байт*/
            sbyte Value3 = -84; /*хранит целое число от -128 до 127 и занимает 1 байт*/
            short Value4 = -3122; /*хранит целое число от -32768 до 32767 и занимает 2 байта*/
            uint d;
            d = (uint)Value4;

            ushort Value5 = 61230; /*хранит целое число от 0 до 65535 и занимает 2 байта*/
            int Value6 = 15; //хранит целое число от -2147483648 до 2147483647 и занимает 4 байта
            short q;
            q = (short)Value6;

            uint Value7 = 26; //хранит целое число от 0 до 4294967295 и занимает 4 байта
            long Value8 = 32165487; //хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт
            byte f;
            f = (byte)Value8;

            //ulong: хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт. 
            float Value9; //хранит число с плавающей точкой от -3.4 * 1038 до 3.4 * 1038 и занимает 4 байта.
            double Value10; //хранит число с плавающей точкой от ±5.0*10-324 до ±1.7*10308 и занимает 8 байта.
            decimal Value11; //хранит десятичное дробное число. 
            char Value12 = 's'; //хранит одиночный символ в кодировке Unicode и занимает 2 байта.
            string Value13 = "apple"; //хранит набор символов Unicode. 
            object a = 58;
            object b = 3.14;
            object c = "The Sun"; //может хранить значение любого типа данных и занимает 4 байта на 32-РП и 8 байт на 64-РП.

            double x = 1.7;
            int s;
            s = (int)x;
            Console.WriteLine(s);

            int i = 10;
            object first_obj = i; //упаковка
           
            int j = (int)first_obj; //распаковка

            var p = 42;     // переменная p инициализируется целочисленным литералом
            var h = 65.8;   // переменная h инициализируется литералом с плавающей точкой,
                            // имеющему тип double
            var k = 0.61F;  // переменная k теперь имеет тип float

            var name = "Елизавета";
            var age = 18;
            var isArtist = true;

            // Определяем тип переменных
            Type nameType = name.GetType();
            Type ageType = age.GetType();
            Type isArtistType = isArtist.GetType();

            // Выводим в консоль результаты
            Console.WriteLine("Тип name: {0}", nameType);
            Console.WriteLine("Тип age {0}", ageType);
            Console.WriteLine("Тип isArtist {0}", isArtistType);

            Nullable<int> y = null; //int? y = null;
            int? u = y + 9;

            int? l = null;
            int? o = 7;
            Console.WriteLine(l < o); //во всех случаях false
        }
    }
}
