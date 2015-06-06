using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DWZ.Repositories
{
    public class Repository<T> : IRepository<T>
    {
        public bool Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Insert(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public bool Update(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(IEnumerable<T> entity)
        {
            throw new NotImplementedException();
        }

        public T GetById(object Id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAlls()
        {
            throw new NotImplementedException();
        }

        public List<T> GetMany()
        {
            throw new NotImplementedException();
        }
    }
}
