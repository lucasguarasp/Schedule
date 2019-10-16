using Schedule.Interfaces;
using Schedule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule.BL
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected ApplicationDbContext _context;
        public RepositoryBase(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(T obj)
        {
            _context.Set<T>().Add(obj);
        }

        public void Delete(T obj)
        {
            _context.Set<T>().Remove(obj);
        }

        public void Update(T obj)
        {
            _context.Set<T>().Update(obj);
        }
        public Task Save()
        {
            return _context.SaveChangesAsync();
        }
    }
}
