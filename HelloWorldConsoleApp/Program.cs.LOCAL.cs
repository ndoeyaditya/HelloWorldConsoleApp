using System;
using System.Linq;
using HelloWorldConsoleApp.Service;

namespace HelloWorldConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world..");
            Console.WriteLine();

            var personService = new PersonService();
            var persons = personService.FindAll();

            foreach (var person in persons)
            {
                Console.WriteLine("Id: {0}", person.Id);
                Console.WriteLine("Name: {0}", person.Name);
                Console.WriteLine("Created: {0}", person.CreatedDate.ToString("MMMM dd, yyyy"));
                Console.WriteLine();
            }

            Console.WriteLine("Total Person: {0} persons", persons.Count());
            Console.ReadLine();
        }
    }
}
