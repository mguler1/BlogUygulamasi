using System;
using System.Collections.Generic;
using System.Text;
using BlogUygulaması.Entities.Concrete;
namespace BlogUygulaması.Dto.DTOs.CategoryDto
{
   public class CategoryWithBlogsCountDto
    {
        public int BlogsCount { get; set; }
        public Category Category { get; set; }
    }
}
