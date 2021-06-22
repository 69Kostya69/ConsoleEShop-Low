using System;
using System.Collections.Generic;

namespace EShop.Data.Interfaces
{
    public interface IRepository<T> where T: class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        void Create(T item);
        void Update(T item);
        void Remove(int id);
        IEnumerable<T> Find(Func<T, Boolean> predicate);
    }
}
