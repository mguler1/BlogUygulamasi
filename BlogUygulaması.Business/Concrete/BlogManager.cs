using BlogUygulaması.Business.Interfaces;
using BlogUygulaması.DataAccess.Interfaces;
using BlogUygulaması.Dto.DTOs.CategoryBlogDtos;
using BlogUygulaması.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogUygulaması.Business.Concrete
{
    public class BlogManager:GenericManager<Blog>,IBlogService
    {
     private readonly   IGenericDal<Blog> _genericDal;
     private readonly   IGenericDal<CategoryBlog> _categoryBlogService;
        private readonly IBlogDal _blogDal;
        public BlogManager(IGenericDal<Blog> genericDal, IGenericDal<CategoryBlog> categoryBlogService, IBlogDal blogDal) :base(genericDal)
        {
            _genericDal = genericDal;
            _categoryBlogService = categoryBlogService;
            _blogDal = blogDal;
        }

        public async Task AddToCategoryAsync(CategoryBlogDto categoryBlogDto)
        {
            var control = await _categoryBlogService.GetAsync(x => x.CategoryId == categoryBlogDto.CategoryId && x.BlogId == categoryBlogDto.BlogId);
            if (control==null)
            {
            await _categoryBlogService.AddAsync(new CategoryBlog
            {
                BlogId = categoryBlogDto.BlogId,
                CategoryId=categoryBlogDto.CategoryId
            });
            }
        }

        public async Task<List<Blog>> GetAllByCategoryIdAsync(int categoryId)
        {
            return await _blogDal.GetAllByCategoryIdAsync(categoryId);
        }

        public async Task<List<Blog>> GetAllSortedByPostedTimeAsync()
        {
          return  await _genericDal.GetAllAsync(x=>x.ReleaseTime);
            
        }

        public async Task RemoveFromCategoryAsync(CategoryBlogDto categoryBlogDto)
        {
          var deletedcategoryBlog= await  _categoryBlogService.GetAsync(x => x.CategoryId == categoryBlogDto.CategoryId && x.BlogId == categoryBlogDto.BlogId);
            if (deletedcategoryBlog!=null)
            {
                await _categoryBlogService.RemoveAsync(deletedcategoryBlog);
            }
           
        }
    }
}
