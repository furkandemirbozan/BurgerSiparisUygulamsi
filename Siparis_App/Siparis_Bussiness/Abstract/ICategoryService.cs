﻿using Siparis_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis_Bussiness.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int categoryId);
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
    }
}
