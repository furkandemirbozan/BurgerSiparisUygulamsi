using Siparis_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis_Bussiness.Abstract
{
    public interface IProductService
    {
        //Belirli bir ürüne ait category leri çekmek 
        List<Product> GetProductsByCategory(int categoryId);
        List<Product> GetAll();
        Product GetById(int productId);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
