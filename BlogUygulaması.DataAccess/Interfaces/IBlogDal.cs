using BlogUygulaması.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogUygulaması.DataAccess.Interfaces
{
   public interface IBlogDal:IGenericDal<Blog>
    {
        Task<List<Blog>> GetAllByCategoryIdAsync(int categoryId);
    }
}
