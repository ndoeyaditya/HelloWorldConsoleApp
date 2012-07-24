using System;
using System.Linq;
using HelloWorldConsoleApp.Repository;

namespace HelloWorldConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world..");
            Console.WriteLine();

            var personRepo = RepositoryFactory.PersonRepository;
            var persons = personRepo.FindAll();

            foreach (var person in persons)
            {
                Console.WriteLine("Id: {0}", person.Id);
                Console.WriteLine("Name: {0}", person.Name);
                Console.WriteLine("Tanggal: {1}", person.DateOfBirth);
                Console.WriteLine();
            }

            Console.WriteLine("Total Person: {0} persons", persons.Count());
            Console.ReadLine();
        }
    }
}
