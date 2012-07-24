namespace HelloWorldConsoleApp.Repository
{
    public class RepositoryFactory
    {
        private static IPersonRepository _personRepository;

        public static IPersonRepository PersonRepository
        {
            get
            {
                if (_personRepository == null)
                    _personRepository = new PersonRepository();

                return _personRepository;
            }
        }
    }
}
