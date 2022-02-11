using BlogUygulaması.Business.Interfaces;
using BlogUygulaması.Business.Tools.JWTTool;
using BlogUygulaması.Dto.DTOs.AppUserDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogUygulaması.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
       private readonly IAppUserService _appUserService;
       private readonly IJwtService _jwtService;
        public AuthController(IAppUserService appUserService, IJwtService jwtService)
        {
            _appUserService = appUserService;
            _jwtService = jwtService;
        }
        [HttpPost]
        public async Task<IActionResult> SingIn(LogInDto logInDto)
        {
           var user= await _appUserService.CheckUserAsync(logInDto);
            if (user!=null)
            {
                return Created("", _jwtService.GenerateJwt(user));
            }
            return BadRequest("Kullanıcı Adı veya Şifre Hatalı");
        }
        [HttpGet("[action]")]
        [Authorize]
        public async Task<IActionResult> ActiveUser()
        {
         var user=  await _appUserService.FindByNameAsync(User.Identity.Name);
           
            return Ok(new AppUserDto { Name = user.Name, SurName = user.SurName });
        }
    }
}
