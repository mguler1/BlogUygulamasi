using BlogUygulaması.Dto.DTOs.AppUserDto;
using BlogUygulaması.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogUygulaması.Business.Interfaces
{
   public interface IAppUserService :IGenericService<AppUser>
    {
        Task<AppUser> CheckUserAsync(LogInDto logInDto );
        Task<AppUser> FindByNameAsync(string userName);

    }
}
