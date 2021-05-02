using BlogUygulaması.Business.Interfaces;
using BlogUygulaması.DataAccess.Interfaces;
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
        public BlogManager(IGenericDal<Blog> genericDal):base(genericDal)
        {
            _genericDal = genericDal;
        }

        public async Task<List<Blog>> GetAllSortedByPostedTimeAsync()
        {
          return  await _genericDal.GetAllAsync(x=>x.ReleaseTime);
            
        }
    }
}
