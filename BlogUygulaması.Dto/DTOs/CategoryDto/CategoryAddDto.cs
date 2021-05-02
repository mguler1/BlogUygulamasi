using BlogUygulaması.Dto.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogUygulaması.Dto.DTOs.CategoryDto
{
   public class CategoryAddDto:IDto
    {
        public string Name { get; set; }
    }
}
