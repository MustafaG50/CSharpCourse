namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "My name is Mustafa.";
            //Boşluklar dahil bütün karakterleri sayar.
            var result = sentence.Length;
            var result2 =sentence.Clone();
            sentence = "My name is Jack.";
            Console.WriteLine(result);
            Console.WriteLine(result2);
            
            bool result3= sentence.EndsWith(".");
            Console.WriteLine(result3);
            
            bool result4= sentence.StartsWith("M");
            bool result5 = sentence.StartsWith("Myname");
            bool result6 = sentence.StartsWith("My name");
            Console.WriteLine(result4);
            Console.WriteLine(result5);
            Console.WriteLine(result6);

            var result7 = sentence.IndexOf("Jack");
            Console.WriteLine(result7);

            var result8 = sentence.LastIndexOf("a");
            var result9 = sentence.IndexOf("a");
            Console.WriteLine(result8);
            Console.WriteLine(result9);

            var result10 = sentence.Insert(0,"Hello, ");
            Console.WriteLine(result10);

            var result11 = sentence.Substring(0,5);
            Console.WriteLine(result11);

            var result12 = sentence.ToLower();
            Console.WriteLine(result12);

            var result13 = sentence.ToUpper();
            Console.WriteLine(result13);

            var result14 = sentence.Replace(" ","-");
            Console.WriteLine(result14);

            var result15 = sentence.Remove(0,5);
            Console.WriteLine(result15);


        }

        private static void Intro()
        {
            string city = "İstanbul";
            string city2 = "Ankara";
            Console.WriteLine(city);
            Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"{city} {city2}");
            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
