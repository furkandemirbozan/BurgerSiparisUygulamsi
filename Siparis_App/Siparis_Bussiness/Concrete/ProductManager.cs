using Siparis_Bussiness.Abstract;
using Siparis_DAL.Concrete.EfCore;
using Siparis_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis_Bussiness.Concrete
{
    public class ProductManager : IProductService
    {
        EfCoreProductDal _productDal=new EfCoreProductDal();
        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public Product GetById(int productId)
        {
            return _productDal.GetById(productId);
        }

        //Belirli bir ürüne ait category leri çekmek 
        public List<Product> GetProductsByCategory(int categoryId)
        {
            
            return _productDal.GetProductsByCategory(categoryId);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
