using System;
using System.Collections.Generic;
using System.Text;
using BlogUygulaması.Entities.Concrete;
namespace BlogUygulaması.Dto.DTOs.CategoryDto
{
   public class CategoryWithBlogsCountDto
    {
        public int BlogsCount { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
