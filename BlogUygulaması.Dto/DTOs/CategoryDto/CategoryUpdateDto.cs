using BlogUygulaması.Dto.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogUygulaması.Dto.DTOs.CategoryDto
{
  public class CategoryUpdateDto :IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
