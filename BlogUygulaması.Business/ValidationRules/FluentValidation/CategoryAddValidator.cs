using BlogUygulaması.Dto.DTOs.CategoryDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogUygulaması.Business.ValidationRules.FluentValidation
{
   public  class CategoryAddValidator: AbstractValidator<CategoryAddDto>
    {
        public CategoryAddValidator()
        {
            RuleForEach(x => x.Name).NotEmpty().WithMessage("Kategori Adı Boş Geçilemez");
        }
    }
}
