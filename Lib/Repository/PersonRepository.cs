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
                persons.Add(
                    new Person()
                    {
                        Id = i + 1,
                        Name = string.Format("Person {0}", (i + 1).ToString(CultureInfo.InvariantCulture)),
                        CreatedDate = DateTime.Now
                    });
            }

            return persons;
        }
    }
}
