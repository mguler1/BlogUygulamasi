using BlogUygulaması.DataAccess.Concrete.EntityFrameworkCore.Context;
using BlogUygulaması.DataAccess.Interfaces;
using BlogUygulaması.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogUygulaması.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfCategoryRepository : EfGenericRepository<Category>, ICategoryDal
    {
        public async  Task<List<Category>> GetAllWithBlogsCountAsync()
        {
            using var context=   new BlogContext();
            return  await context.Categories.OrderByDescending(x=>x.Id).Include(x => x.categoryBlogs).ToListAsync();
        }
    }
}
