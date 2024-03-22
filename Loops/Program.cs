namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoops();
            //WhileLoop();
            //Bir kere çalıştıktan sonra şarta bakar.
            //DoWhileLoop();
            //ForeachMethod();
            Console.WriteLine(IsPrimeNumber(Convert.ToInt32(Console.ReadLine())));

        }
        private static bool IsPrimeNumber(int number)
        {

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0 && i!=1 )
                {
                    return false;
                }
                
            }
            return true;
        }

        private static void ForeachMethod()
        {
            string[] students = { "Mustafa", "Hamdiye", "Emirhan" };
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }

        private static void DoWhileLoop()
        {
            do
            {
                Console.WriteLine("Çalıştı!!");
            } while (false);
        }

        private static void WhileLoop()
        {
            while (true)
            {

            }
        }

        private static void ForLoops()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
