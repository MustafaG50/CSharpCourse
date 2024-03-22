using Ödev.DersÖdev;

namespace Ödev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //16 bits
            short number0 = 234;
            Console.WriteLine($"Number0 is {number0}");
            //32 bits
            int number1 = 210;
            Console.WriteLine($"Number1 is {number1}");
            //64 bits
            long number2 = -12340;
            Console.WriteLine($"Number2 is {number2}");
            //8 bits
            byte number3 = 21;
            Console.WriteLine($"Number3 is {number3}");
            //8 bits
            bool condition = true;
            Console.WriteLine($"Condition is {condition}");
            //16 bits
            char character = 'A';
            Console.WriteLine($"Character is {character}");
            Console.WriteLine($"Character number is {(int)character}");
            //64 bits
            double number4 = 223;
            Console.WriteLine($"Number4 is {number4}");
            //128 bits
            decimal number5 = 10.5M;
            Console.WriteLine($"Number5 is {number5}");
            //32 bits
            float number6 = 11.8f;
            Console.WriteLine($"Number5 is {number6}");

            days days = days.Monday;
            Console.WriteLine(days);

            var days1 = (days)1;
            Console.WriteLine(days1);

            var number7 = 15;
            Console.WriteLine(number7);

            var name = "Mustafa";
            var character1 = 'P';
            //ÖdevÜslüSayı ödevÜslüSayı = new ÖdevÜslüSayı();
            

        }
        enum days
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
    }
}
