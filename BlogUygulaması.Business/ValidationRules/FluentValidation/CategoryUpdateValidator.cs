using BlogUygulaması.Dto.DTOs.CategoryDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogUygulaması.Business.ValidationRules.FluentValidation
{
   public  class CategoryUpdateValidator: AbstractValidator<CategoryUpdateDto>
    {
        public CategoryUpdateValidator()
        {
            RuleFor(x => x.Id).InclusiveBetween(0, int.MaxValue).WithMessage("Kategori Boş Geçilemez");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kategori Adı Boş Geçilemez ");
        }
    }
}
