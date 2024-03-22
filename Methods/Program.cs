using System.ComponentModel;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Bir sayı giriniz :");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //Add(number1);
            //Add(number1,number2);
            int number1 = 20;
            int number2 = 100;
            int number3;
            Console.WriteLine(Add(ref number1, number2));
            Console.WriteLine(Add2(out number3, number2));
            Console.WriteLine(Add3(1, 2, 3, 4, 5, 6, 7, 8));
        }

        static void Add(int a, int b = 50)
        {
            int sonuç = a + b;
            Console.WriteLine($"{sonuç}");
            Console.WriteLine("Added!");
        }
        static int Add(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        static int Add2(out int number3, int number2)
        {
            number3 = 20;
            return number3 + number2;
        }
        static int Add3(int number, params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
