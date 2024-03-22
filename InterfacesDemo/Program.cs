namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Worker(),
                new Manager(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }
        }
    }

    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Manager Eat!");
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            Console.WriteLine("Manager Work!");
        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Worker Eat!");
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            Console.WriteLine("Worker Work!");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot Work!");
        }
    }
}
