using System.Collections.Generic;

namespace StarlineTest.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity>
        where TEntity : class
    {
        void Add(TEntity obj);

        void Update(TEntity obj);

        void Remove(TEntity obj);

        void Dispose();

        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();
    }
}
