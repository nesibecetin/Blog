﻿using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface CategoryService
    {
        void Add(Category category);
        Category GetById(int id);
        List<Category> GetAll();
        void Update(Category category);
        void Delete(Category category);
    }
}
