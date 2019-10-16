using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        void Add(T obj);
        void Update(T obj);
        void Delete(T obj);
        Task Save();
    }
}
