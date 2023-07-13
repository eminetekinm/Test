using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Test.Categories.Dtos;
using Volo.Abp.Application.Services;

namespace Test.Categories
{
    public interface ICategoryAppService : IApplicationService
    {
        Task<List<CategoryDto>> GetCategories();
        Task<bool> DeleteCategory(int id);
        Task<CategoryDto> GetCategoryById(int id);
        Task<bool> CategoryAdd(CategoryAddDto category);
        Task<bool> CategoryUpdate(CategoryDto category);
    }
}
