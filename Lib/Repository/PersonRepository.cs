using System;
using System.Collections.Generic;
using System.Globalization;
using HelloWorldConsoleApp.Domain;

namespace HelloWorldConsoleApp.Repository
{
    public class PersonRepository : IPersonRepository
    {
        public IEnumerable<Person> FindAll()
        {
            var persons = new List<Person>();
            for (int i = 0; i < 50; i++)
            {
                var id = Guid.NewGuid();
                persons.Add(
                    new Person()
                    {
                        Id = id,
                        Name = string.Format("Person {0}", id.ToString()),
                        CreatedDate = DateTime.Now
                    });
            }

            return persons;
        }
    }
}
