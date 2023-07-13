using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Categories.Dtos;
using Volo.Abp.Application.Services;

namespace Test.Categories
{
    public class CategoryAppService : ApplicationService, ICategoryAppService
    {
        private readonly ICategoryManager _categoryManager;
        public CategoryAppService(ICategoryManager categoryManager)//ctor
        {
            _categoryManager = categoryManager;
        }
        public async Task<bool> CategoryAdd(CategoryAddDto category)
        {
            var value = ObjectMapper.Map<CategoryAddDto, Category>(category);//Map kaynak istiyor kaynak dto hedef istiyor hedef category ve dönüştüreceği modeli istiyor onu içeri yazıyorum.
            return await _categoryManager.CategoryAdd(value);
        }

        public async Task<bool> CategoryUpdate(CategoryDto category)
        {
            return await _categoryManager.CategoryUpdate(ObjectMapper.Map<CategoryDto, Category>(category));
        }

        public async Task<bool> DeleteCategory(int id)
        {
            return await _categoryManager.DeleteCategory(id);
        }

        public async Task<List<CategoryDto>> GetCategories()
        {
            var categoryList = await _categoryManager.GetCategories();
            return ObjectMapper.Map<List<Category>, List<CategoryDto>>(categoryList.ToList());
        }

        public async Task<CategoryDto> GetCategoryById(int id)
        {
            var category = await _categoryManager.GetCategoryById(id);
            return ObjectMapper.Map<Category, CategoryDto>(category);

        }
    }
}
