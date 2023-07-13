using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;

namespace Test.Categories
{
    public interface ICategoryManager : IDomainService
    {
        //ınetface olmaadan dependency enjection yapamayız kurala bağlı kalmak için
        Task<IEnumerable<Category>> GetCategories(); //IEnumerable liste gibi ama soyut class liste geriye dner üzerinde oynama yapabilirsin daha performanslı
        Task<bool> DeleteCategory(int id);
        Task<Category> GetCategoryById(int id);
        Task<bool> CategoryAdd(Category category);
        Task<bool> CategoryUpdate(Category category);
    }
}
