using EventLegends.Models.DTOs;
using EventLegends.Repositories.CategoryRepository;

namespace EventLegends.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<List<CategoryDto>> GetAllCategories()
        {
            var categories = await _categoryRepository.GetAllAsync();
            return categories.Select(category => MapToCategoryDto(category)).ToList();
        }

        public async Task<CategoryDto> GetCategoryById(Guid categoryId)
        {
            var category = await _categoryRepository.FindByIdAsync(categoryId);
            return category != null ? MapToCategoryDto(category) : null;
        }

        public async Task CreateCategory(CategoryDto categoryDto)
        {
            var category = MapToCategory(categoryDto);
            _categoryRepository.Create(category);
            await _categoryRepository.SaveAsync();
        }

        public async Task UpdateCategory(CategoryDto categoryDto)
        {
            var existingCategory = await _categoryRepository.FindByIdAsync(categoryDto.Id);

            if (existingCategory != null)
            {
                

                _categoryRepository.Update(existingCategory);
                await _categoryRepository.SaveAsync();
            }
        }

        public async Task DeleteCategory(Guid categoryId)
        {
            var categoryToDelete = await _categoryRepository.FindByIdAsync(categoryId);

            if (categoryToDelete != null)
            {
                _categoryRepository.Delete(categoryToDelete);
                await _categoryRepository.SaveAsync();
            }
        }
    }
}
