﻿using BlogUygulaması.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogUygulaması.Business.Interfaces
{
    public interface ICategoryService :IGenericService<Category>
    {
        Task<List<Category>> GetAllSortedByIdAsync();
        Task<List<Category>> GetWithCategoryBlogsAsync();
    }
}
