using BlogUygulaması.Business.Interfaces;
using BlogUygulaması.DataAccess.Interfaces;
using BlogUygulaması.Dto.DTOs.AppUserDto;
using BlogUygulaması.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogUygulaması.Business.Concrete
{
    public class AppUserManager:GenericManager<AppUser>,IAppUserService
    {
       private readonly IGenericDal<AppUser> _genericDal;
        public AppUserManager(IGenericDal<AppUser> genericDal) :base(genericDal)
        {
            _genericDal = genericDal;
        }

        public async Task<AppUser> CheckUserAsync(LogInDto logInDto)
        {
            return await _genericDal.GetAsync(x => x.UserName == logInDto.UserName && x.Password == logInDto.Password);
        }

        public async  Task<AppUser> FindByNameAsync(string userName)
        {
            return await _genericDal.GetAsync(x => x.UserName == userName );
           
        }
    }
}
