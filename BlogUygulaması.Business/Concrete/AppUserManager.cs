using BlogUygulaması.Business.Interfaces;
using BlogUygulaması.DataAccess.Interfaces;
using BlogUygulaması.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogUygulaması.Business.Concrete
{
    public class AppUserManager:GenericManager<AppUser>,IAppUserService
    {
       private readonly IGenericDal<AppUser> _genericDal;
        public AppUserManager(IGenericDal<AppUser> genericDal) :base(genericDal)
        {
            _genericDal = genericDal;
        }
    }
}
