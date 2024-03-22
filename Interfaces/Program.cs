namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //CostumerManager costumerManager = new CostumerManager();
            //costumerManager.Add(new SqlServerCostumerDal());

            ICostumerDal[] costumerDals = new ICostumerDal[3]
            {
                new OracleServerCostumerDal(),
                new SqlServerCostumerDal(),
                new MySqlServerCostumerDal()
            };

            foreach (var costumerDal in costumerDals)
            {
                costumerDal.Add();
            }

        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Costumer costumer = new Costumer
            {
                Id = 1,
                FirstName = "Mustafa",
                LastName = "Genç",
                Address = "Nevşehir"
            };

            Student student = new Student
            {
                Id = 2,
                FirstName = "Ömer",
                LastName = "Züngür",
                Departmant = "Computer Science"
            };
            manager.Add(costumer);
            manager.Add(student);
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Costumer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
