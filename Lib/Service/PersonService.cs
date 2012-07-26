using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelloWorldConsoleApp.Repository;
using Lib.Domain;
using Lib.Repository;

namespace HelloWorldConsoleApp.Service
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService()
        {
            _personRepository = RepositoryFactory.PersonRepository;
        }

        public IEnumerable<Person> FindAll()
        {
            return _personRepository.FindAll();
        }
    }
}
