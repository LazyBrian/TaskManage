using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DWZ.Repositories
{
    public interface IRepository<T>
    {
        bool Insert(T entity);

        bool Insert(IEnumerable<T> entities);

        bool Update(T entity);

        bool Delete(T entity);

        bool Delete(IEnumerable<T> entity);

        T GetById(object Id);

        List<T> GetAlls();

        List<T> GetMany();



    }
}
