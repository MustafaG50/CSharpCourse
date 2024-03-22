namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CostumerManager costumerManager = new CostumerManager();
            costumerManager.Add();
            costumerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Costumer costumer = new Costumer();
            costumer.FirstName = "Mustafa";
            costumer.LastName = "Genç";
            costumer.Id = 1;
            costumer.City = "Nevşehir";

            Costumer costumer1 = new Costumer
            {
                FirstName = "Emirhan",
                LastName = "Genç",
                Id = 2,
                City = "Nevşehir"
            };

            Console.WriteLine(costumer1.FirstName);

        }
    }
}
