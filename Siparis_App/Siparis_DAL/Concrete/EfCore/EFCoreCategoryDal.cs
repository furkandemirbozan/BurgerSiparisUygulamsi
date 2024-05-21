using Siparis_DAL.Abstract;
using Siparis_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis_DAL.Concrete.EfCore
{
    public class EFCoreCategoryDal :EfCoreGenericRepository<Category,AppDbContext>,ICategoryDal
    {
    }
}
