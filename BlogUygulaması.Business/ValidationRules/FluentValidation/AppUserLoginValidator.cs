using BlogUygulaması.Dto.DTOs.AppUserDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogUygulaması.Business.ValidationRules.FluentValidation
{
    public class AppUserLoginValidator:AbstractValidator<LogInDto>
    {
        public AppUserLoginValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adı Boş Geçilemz");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Kullanıcı Adı Boş Geçilemz");
        }
    }
}
