using System.Collections.Generic;
using HelloWorldConsoleApp.Domain;

namespace HelloWorldConsoleApp.Repository
{
    public interface IRepository<TENtity> where TENtity : IEntity
    {

    }

    public interface IReadRepository<TEntity> : IRepository<TEntity> where TEntity : IEntity
    {
        IEnumerable<TEntity> FindAll(); 
    }
}
