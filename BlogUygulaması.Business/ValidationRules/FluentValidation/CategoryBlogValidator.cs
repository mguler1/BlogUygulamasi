using BlogUygulaması.Dto.DTOs.CategoryBlogDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogUygulaması.Business.ValidationRules.FluentValidation
{
   public  class CategoryBlogValidator: AbstractValidator<CategoryBlogDto>
    {
        public CategoryBlogValidator()
        {
            RuleFor(x => x.BlogId).InclusiveBetween(0,int.MaxValue).WithMessage("BlogId Boş Geçilemez");
            RuleFor(x => x.CategoryId).InclusiveBetween(0,int.MaxValue).WithMessage("CategoryId Boş Geçilemez");
        }
    }
}
