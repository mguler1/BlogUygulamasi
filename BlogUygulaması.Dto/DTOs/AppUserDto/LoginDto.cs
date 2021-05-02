using BlogUygulaması.Dto.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogUygulaması.Dto.DTOs.AppUserDto
{
   public class LoginDto:IDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
