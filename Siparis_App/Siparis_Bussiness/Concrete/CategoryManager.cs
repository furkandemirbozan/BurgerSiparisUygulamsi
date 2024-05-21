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
    //Gneric repository Kullanmadım bilerek kullanılmamış olsun diye
    public class CategoryManager : ICategoryService
    {
        EFCoreCategoryDal _categoryDal=new EFCoreCategoryDal();
        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category GetById(int categoryId)
        {
            return _categoryDal.GetById(categoryId);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
