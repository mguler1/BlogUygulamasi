using BlogUygulaması.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogUygulaması.Business.Tools.JWTTool
{
   public  interface IJwtService
    {
        JwtToken GenerateJwt(AppUser appUser);
    }
}
