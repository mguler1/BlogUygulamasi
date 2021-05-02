using AutoMapper;
using BlogUygulaması.Api.Models;
using BlogUygulaması.Business.Interfaces;
using BlogUygulaması.Dto.DTOs.BlogDto;
using BlogUygulaması.Entities.Concrete;
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
    public class BlogsController : ControllerBase
    {
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;
        public BlogsController(IBlogService blogService, IMapper mapper)
        {
            _blogService = blogService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_mapper.Map<List<BlogListDto>>(await _blogService.GetAllSortedByPostedTimeAsync()));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(_mapper.Map<BlogListDto>(await _blogService.FindById(id)));
        }
        [HttpPost]
        public async Task<IActionResult> Create(BlogAddModel blogAddModel)
        {
            await _blogService.AddAsync(_mapper.Map<Blog>(blogAddModel));
            return Created("", blogAddModel);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, BlogUpdateModel blogUpdateModel)
        {
            if (id != blogUpdateModel.Id)
            {
                return BadRequest("Geçersiz Id");
                await _blogService.UpdateAsync(_mapper.Map<Blog>(blogUpdateModel));
            }
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _blogService.RemoveAsync(new Blog { Id = id });
            return NoContent();
        }
    }
}
