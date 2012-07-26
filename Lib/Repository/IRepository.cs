using System.Collections.Generic;
using Lib.Domain;

namespace Lib.Repository
{
    public interface IRepository<TENtity> where TENtity : IEntity
    {

    }

    public interface IReadRepository<TEntity> : IRepository<TEntity> where TEntity : IEntity
    {
        IEnumerable<TEntity> FindAll(); 
    }
}
