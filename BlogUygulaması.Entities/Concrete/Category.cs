using BlogUygulaması.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogUygulaması.Entities.Concrete
{
   public class Category:ITable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CategoryBlog> categoryBlogs { get; set; }
    }
}
