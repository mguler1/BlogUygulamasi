using BlogUygulaması.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogUygulaması.Web.ApiServices.Interfaces
{
   public interface ICategoryApiService
    {
        Task<List<CategoryListModel>> GetAllAsync();
    }
}
