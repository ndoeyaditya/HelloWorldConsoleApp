using System.Collections.Generic;
using Lib.Domain;

namespace HelloWorldConsoleApp.Service
{
    public interface IService<TEntity> where TEntity : IEntity
    {
        IEnumerable<TEntity> FindAll();
    }
}
