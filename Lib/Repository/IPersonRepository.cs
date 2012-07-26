using HelloWorldConsoleApp.Repository;
using Lib.Domain;

namespace Lib.Repository
{
    public interface IPersonRepository : IReadRepository<Person>
    {

    }
}
