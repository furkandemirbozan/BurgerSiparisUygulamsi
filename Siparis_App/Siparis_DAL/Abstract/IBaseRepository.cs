using Siparis_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis_DAL.Abstract
{
    public interface IBaseRepository<T>
    {
        List<T> GetAll();
        T GetById(int entityId);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
