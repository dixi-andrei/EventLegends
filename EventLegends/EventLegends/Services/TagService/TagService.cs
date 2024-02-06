using AutoMapper;
using EventLegends.Models.Base;
using EventLegends.Models.DTOs;
using EventLegends.Repositories.TagRepository;
using EventLegends.Services.TagService;

namespace EventLegends.Services.TagsService
{
    public class TagService : ITagService
    {
        private readonly ITagRepository _tagRepository;
        private readonly IMapper _mapper;

        public TagService(ITagRepository tagRepository, IMapper mapper)
        {
            _tagRepository = tagRepository;
            _mapper = mapper;
        }

        public async Task<List<TagDTO>> GetAllTags()
        {
            var tags = await _tagRepository.GetAllAsync();
            return _mapper.Map<List<TagDTO>>(tags);
        }

        public async Task<TagDTO> GetTagById(Guid tagId)
        {
            var tag = await _tagRepository.FindByIdAsync(tagId);
            return _mapper.Map<TagDTO>(tag);
        }

        public async Task CreateTag(TagDTO tagDto)
        {
            var tag = _mapper.Map<Tag>(tagDto);
            _tagRepository.Create(tag);
            await _tagRepository.SaveAsync();
        }

        public async Task UpdateTag(Guid tagId, TagDTO tagDto)
        {
            var existingTag = await _tagRepository.FindByIdAsync(tagId);
            if (existingTag == null)
            {
                throw new InvalidOperationException($"Eticheta cu ID-ul {tagId} nu există.");
            }

            _mapper.Map(tagDto, existingTag);
            _tagRepository.Update(existingTag);
            await _tagRepository.SaveAsync();
        }

        public async Task DeleteTag(Guid tagId)
        {
            var tag = await _tagRepository.FindByIdAsync(tagId);
            if (tag != null)
            {
                _tagRepository.Delete(tag);
                await _tagRepository.SaveAsync();
            }
        }
    }

}
