using System.Collections;
using System.Collections.Generic;

namespace StarlineTest.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity>
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
