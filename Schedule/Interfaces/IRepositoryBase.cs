using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule.Interfaces
{
    public interface IRepositoryBase<T>
    {
        void Add(T obj);
        void Update(T obj);
        void Delete(T obj);
        Task<bool> Save();
        T GetById(int Id);

        T GetWithCondition(Func<T,bool> predicate);
        List<T> GetAll(Func<T,bool> predicate = null);
    }
}
