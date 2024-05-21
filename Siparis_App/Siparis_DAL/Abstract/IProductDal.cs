using Siparis_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis_DAL.Abstract
{
    public interface IProductDal:IBaseRepository<Product>
    {
        List<Product> GetProductsByCategory(int categoryId);
    }
}
