namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Mustafa";
            students[1] = "Emirhan";
            students[2] = "Hamdiye";
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            string[,] citys = new string[5, 3];
            citys[0, 0] = "İstanbul";
            citys[0, 1] = "Kocaeli";
            citys[0, 2] = "Bursa";
            citys[1, 0] = "İzmir";
            citys[1, 1] = "Manisa";
            citys[1, 2] = "Muğla";
            citys[2, 0] = "Adana";
            citys[2, 1] = "Antalya";
            citys[2, 2] = "Mersin";
            citys[3, 0] = "Nevşehir";
            citys[3, 1] = "Ankara";
            citys[3, 2] = "Kayseri";
            citys[4, 0] = "Kars";
            citys[4, 1] = "Van";
            citys[4, 2] = "Muş";
            //foreach (var city in citys)
            //{
            //    Console.WriteLine(city);
            //}
            for (int i = 0; i <= citys.GetUpperBound(0); i++)
            {
                Console.WriteLine("****************");
                for (int j = 0; j <= citys.GetUpperBound(1); j++)
                {
                    Console.WriteLine(citys[i, j]);
                }

            }
        }
    }
}
