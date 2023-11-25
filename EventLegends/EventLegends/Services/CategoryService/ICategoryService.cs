using EventLegends.Models.DTOs;

namespace EventLegends.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<CategoryDto>> GetAllCategories();
        Task<CategoryDto> GetCategoryById(Guid categoryId);
        Task CreateCategory(CategoryDto categoryDto);
        Task UpdateCategory(Guid categoryId, CategoryDto categoryDto);
        Task DeleteCategory(Guid categoryId);
    }
}
