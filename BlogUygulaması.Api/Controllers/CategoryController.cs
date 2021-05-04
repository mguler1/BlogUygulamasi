using AutoMapper;
using BlogUygulaması.Business.Interfaces;
using BlogUygulaması.Dto.DTOs.CategoryDto;
using BlogUygulaması.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogUygulaması.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;
        public CategoryController(IMapper mapper, ICategoryService categoryService)
        {
            _mapper = mapper;
            categoryService = _categoryService;
        }
        public async Task<IActionResult> GetAll()
        {
            return Ok(_mapper.Map<List<CategoryListDto>>(await _categoryService.GetAllSortedByIdAsync()));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(_mapper.Map<CategoryListDto>(await _categoryService.FindByIdAsync(id)));
        }
        [HttpPost]
        public async Task<IActionResult> Create(CategoryAddDto categoryAddDto)
        {
          await  _categoryService.AddAsync(_mapper.Map<Category> (categoryAddDto));
            return Created("", categoryAddDto);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id ,CategoryUpdateDto categoryUpdateDto)
        {
            if (id!=categoryUpdateDto.Id)
                return BadRequest("Geçersiz Id");
            await _categoryService.UpdateAsync(_mapper.Map<Category>(categoryUpdateDto));
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _categoryService.RemoveAsync(new Category { Id = id });
            return NoContent();
        }
    }
}