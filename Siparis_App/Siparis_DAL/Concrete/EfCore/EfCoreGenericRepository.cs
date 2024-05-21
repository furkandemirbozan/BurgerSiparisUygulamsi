using Microsoft.EntityFrameworkCore;
using Siparis_DAL.Abstract;
using Siparis_Entities.Abstract;
using Siparis_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis_DAL.Concrete.EfCore
{
    public class EfCoreGenericRepository<T, TContext> : IBaseRepository<T>
        where T : class
        where TContext : DbContext, new()
        //Koşullarım
    {

        public void Add(T entity)
        {
            // 'using' ifadesi ile TContext türünde bir context nesnesi oluşturuluyor.
            // Bu, 'context' nesnesinin 'using' bloğu sonunda otomatik olarak dispose edilmesini sağlar.
            using (TContext context = new TContext())
            {
                // Set<T> metodu, veritabanında T türündeki varlıkların yer aldığı DbSet'i döner. Add(entity) metodu, bu DbSet'e belirtilen 'entity' nesnesini ekler.
                context.Set<T>().Add(entity);
                context.SaveChanges();
            }

        }

        public void Delete(T entity)
        {
            using (TContext context = new TContext())
            {
                context.Set<T>().Remove(entity);
                context.SaveChanges();
            }
        }

        public List<T> GetAll()
        {
            using (TContext context = new TContext())
            {
                return context.Set<T>().ToList();
            }
        }

        public T GetById(int entityId)
        {
            using (TContext context = new TContext())
            {
                return context.Set<T>().Find(entityId);
            }

        }

        public void Update(T entity)
        {
            //TContexi yazmadım anlatmak için
            AppDbContext context = new AppDbContext();

            context.Set<T>().Update(entity);
            context.SaveChanges();

        }


    }
}
