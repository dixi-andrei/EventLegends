using EventLegends.Data;
using EventLegends.Models;

namespace EventLegends.Helpers.Seeders
{
    public class CategoriesSeeder
    {
        public readonly AppDbContext appDbContext;

        public CategoriesSeeder(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public void SeedInitialCategories()
        {
            if (!appDbContext.Categories.Any())
            {
                var categories1 = new Category
                {
                    CategoryType = "Concert"
                };

                appDbContext.Categories.Add(categories1);
                
                appDbContext.SaveChanges();
            }
        }

    }
}
