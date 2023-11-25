using AutoMapper;
using EventLegends.Models;
using EventLegends.Models.DTOs;
using EventLegends.Repositories.CategoryRepository;

namespace EventLegends.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }


        public async Task<List<CategoryDto>> GetAllCategories()
        {
            var categories = await _categoryRepository.GetAllAsync();
            return _mapper.Map<List<CategoryDto>>(categories);
        }

        public async Task<CategoryDto> GetCategoryById(Guid categoryId)
        {
            var category = await _categoryRepository.FindByIdAsync(categoryId);
            return _mapper.Map<CategoryDto>(category);
        }

        public async Task CreateCategory(CategoryDto categoryDto)
        {
            var category = _mapper.Map<Category>(categoryDto);
            _categoryRepository.Create(category);
            await _categoryRepository.SaveAsync();
        }

        public async Task UpdateCategory(Guid categoryId, CategoryDto categoryDto)
        {
            var existingCategory = await _categoryRepository.FindByIdAsync(categoryId);
            if (existingCategory == null)
            {
                throw new InvalidOperationException($"Categoria cu ID-ul {categoryId} nu există.");
            }

            _mapper.Map(categoryDto, existingCategory);
            _categoryRepository.Update(existingCategory);
            await _categoryRepository.SaveAsync();
        }

        public async Task DeleteCategory(Guid categoryId)
        {
            var category = await _categoryRepository.FindByIdAsync(categoryId);
            if (category != null)
            {
                _categoryRepository.Delete(category);
                await _categoryRepository.SaveAsync();
            }
        }
    }
}
