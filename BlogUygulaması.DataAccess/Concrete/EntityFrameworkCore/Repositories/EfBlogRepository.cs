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
    public class EfBlogRepository : EfGenericRepository<Blog>, IBlogDal
    {
    
        public async Task<List<Blog>> GetAllByCategoryIdAsync(int categoryId)
        {
            using var context = new BlogContext();
            return await context.Blogs.Join(context.CategoryBlogs, b => b.Id, cb => cb.BlogId,
                    (blog, categoryBlog) => new
                    {
                        blog = blog,
                        categoryBlog = categoryBlog
                    }).Where(x => x.categoryBlog.CategoryId == categoryId).Select(x => new Blog
                    {
                        AppUser = x.blog.AppUser,
                        AppUserId = x.blog.AppUserId,
                        CategoryBlogs = x.blog.CategoryBlogs,
                        Comments = x.blog.Comments,
                        Description = x.blog.Description,
                        Id = x.blog.Id,
                        ImagePath = x.blog.ImagePath,
                        ReleaseTime = x.blog.ReleaseTime,
                        ShortDescription = x.blog.ShortDescription,
                        Title = x.blog.Title
                    }).ToListAsync();
        }
    }
}
