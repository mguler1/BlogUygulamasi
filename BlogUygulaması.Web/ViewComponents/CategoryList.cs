using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogUygulaması.Web.ApiServices.Interfaces;
using Microsoft.AspNetCore.Mvc;

    namespace BlogUygulaması.Web.ViewComponents
{ 
    
    public class CategoryList : ViewComponent
    {
        private readonly ICategoryApiService _categoryApiService;
        public CategoryList(ICategoryApiService categoryApiService)
        {
            _categoryApiService = categoryApiService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_categoryApiService.GetAllAsync().Result);
        }
    }
}