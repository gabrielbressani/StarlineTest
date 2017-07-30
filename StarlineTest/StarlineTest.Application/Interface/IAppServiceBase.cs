using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarlineTest.Application.Interface
{
    public interface IAppServiceBase<TEntity>
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
