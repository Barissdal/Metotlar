using System;
using System.Linq;

namespace RefKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 20;
            int number2 = 50;
            var result1 = Add(number1, number2);
            
            Console.WriteLine(result1);
            // burada number1 'in değeri hala 20 çünkü değet tipli değişkenlerde sadece değer gider. Burada fonksiyonun içindeki değişiklik number1'i etkilemez.
            Console.WriteLine(number1);

            int number3 = 10;
            int number4 = 40;
            var result2 = Add2(ref number3, number4);

            Console.WriteLine(result2);
            // Burada number3'ün değeri fonksiyondaki değer oldu çünkü biz bunu referans tipi olarak tanıttık.
            Console.WriteLine(number3);

            int number5;
            int number6 = 10;
            var result3 = Add3(out number5, number6);

            Console.WriteLine(result3);
            // Burada out ile ref benzer işleri yapar ancak out da number5'e fonksiyon içinde bir değer atamanız yeterlidir.
            Console.WriteLine(number5);

            int number7 = 2;
            int number8 = 3;
            int number9 = 10;
            var result4 = Carpma(number7, number8);
            //overloading
            var result5 = Carpma(number7, number8, number9);

            Console.WriteLine(result4);
            Console.WriteLine(result5);
            Console.WriteLine("---------------------");
            Console.WriteLine(AddYeni(2,3,4,5));
        }

        static int Add(int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Add2(ref int number3, int number4)
        {
            number3 = 100;
            return number3 + number4;
        }

        static int Add3(out int number5, int number6)
        {
            number5 = 20;
            return number5 + number6;
        }

        static int Carpma(int number7, int number8)
        {
            return number7 * number8;
        }

        static int Carpma(int number7, int number8, int number9)
        {
            return number7 * number8 * number9;
        }

        static int AddYeni(params int[] sayilar)
        {
            return sayilar.Sum();
        }
    }
}
