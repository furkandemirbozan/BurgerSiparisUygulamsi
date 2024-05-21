using Siparis_DAL.Abstract;
using Siparis_DAL.Concrete.EfCore;
using Siparis_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis_DAL.Concrete.EfCore
{
    public class EfCoreProductDal : EfCoreGenericRepository<Product, AppDbContext>, IProductDal
    {
        //Kategori id ye göre ürünleri filtreleyip döndüm
        public List<Product> GetProductsByCategory(int categoryId)
        {
            using (AppDbContext context = new AppDbContext())
            {
                //CategoryId ' si , Parametreden gelen categoryId değerine eşit olan Productları döndür
                return context.Products.Where(x => x.CategoryId == categoryId).ToList();
            }
        }
    }
}
