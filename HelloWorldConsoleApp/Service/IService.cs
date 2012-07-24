using System.Collections.Generic;
using HelloWorldConsoleApp.Domain;

namespace HelloWorldConsoleApp.Service
{
    public interface IService<TEntity> where TEntity : IEntity
    {
        IEnumerable<TEntity> FindAll();
    }
}
