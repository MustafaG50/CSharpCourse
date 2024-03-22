namespace Şart_Blokları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 10;
            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else if (number == 20)
            {
                Console.WriteLine("Number is 20");
            }
            else
            {
                Console.WriteLine("Number is not 10 and 20");
            }

            switch (number)
            {
                case 10:
                    Console.WriteLine("true");
                    break;
                case 20:
                    Console.WriteLine("false");
                    break;
                default:
                    Console.WriteLine("not");
                    break;
            }


        }
    }
}
