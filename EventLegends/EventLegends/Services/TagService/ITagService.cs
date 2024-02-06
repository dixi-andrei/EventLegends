using EventLegends.Models.DTOs;

namespace EventLegends.Services.TagService
{
    public interface ITagService
    {
        Task<List<TagDTO>> GetAllTags();
        Task<TagDTO> GetTagById(Guid tagId);
        Task CreateTag(TagDTO tagDto);
        Task UpdateTag(Guid tagId, TagDTO    tagDto);
        Task DeleteTag(Guid tagId);
    }
}
