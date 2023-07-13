using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp;
using Volo.Abp.Domain.Services;

namespace Test.Categories
{
    public class CategoryManager : DomainService, ICategoryManager
    {
        //abpnin domain servisi
        private readonly IRepository<Category, int> _categoryRepository;//repostory katmanı database ile bağlantı için gerekli metotları içinde barındırır.
        public CategoryManager(IRepository<Category, int> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }//bunu dependency enjection yaptık

        public async Task<bool> CategoryAdd(Category category)
        {
            try
            {
                await _categoryRepository.InsertAsync(category);
                return true;
            }
            catch (System.Exception)
            {

                throw new UserFriendlyException("Kategori eklerken hata oldu");
            }
        }

        public async Task<bool> CategoryUpdate(Category category)
        {
            try
            {
                var updateCategory = await _categoryRepository.FirstOrDefaultAsync(x => x.Id == category.Id);
                updateCategory.Name = category.Name;
                updateCategory.Image = category.Image;
                await _categoryRepository.UpdateAsync(updateCategory);
                return true;
            }
            catch (System.Exception)
            {

                throw new UserFriendlyException("Güncellerken hata oldu");
            }
        }

        public async Task<bool> DeleteCategory(int id)
        {
            try
            {
                await _categoryRepository.DeleteAsync(id);
                return true;
            }
            catch (System.Exception)
            {
                throw new UserFriendlyException("Kategori silinirken hata oldu");
            }
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            try
            {
                return await _categoryRepository.GetListAsync();
            }
            catch (System.Exception)
            {

                throw new UserFriendlyException("Kategoriler listelenirken bir hata oldu");
            }
        }

        public async Task<Category> GetCategoryById(int id)
        {
            try
            {
                return await _categoryRepository.FirstOrDefaultAsync(x => x.Id == id);
            }
            catch (System.Exception)
            {

                throw new UserFriendlyException($"{id} 'li kategori bulunamadı");
            }
        }
    }
}
