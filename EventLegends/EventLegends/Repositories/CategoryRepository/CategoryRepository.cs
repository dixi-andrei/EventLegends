using EventLegends.Data;
using EventLegends.Models;
using EventLegends.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace EventLegends.Repositories.CategoryRepository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
       
    }
}
