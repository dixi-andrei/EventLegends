using EventLegends.Data;
using EventLegends.Models.Base;
using EventLegends.Repositories.GenericRepository;

namespace EventLegends.Repositories.TagRepository
{
    public class TagRepository : GenericRepository<Tag>, ITagRepository
    {
        public TagRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
}
