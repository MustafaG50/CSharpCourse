using System.Runtime;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3]
            {
                new Person {FirstName="Mustafa"},
                new Costumer {FirstName="Ömer"},
                new Student {FirstName="Emirhan"}
            };

            foreach (var person in people)
            {
                Console.WriteLine(person.FirstName);
            }

        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Costumer : Person
    {
        public string City { get; set; }
    }
    class Student : Person 
    {
        public string Departmant { get; set; }
    }
}
