using AutoMapper;
using EventLegends.Models;
using EventLegends.Models.DTOs;
using EventLegends.Repositories.MediaRepository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventLegends.Services.MediaService
{
    public class MediaService : IMediaService
    {
        private readonly IMediaRepository _mediaRepository;
        private readonly IMapper _mapper;

        public MediaService(IMediaRepository mediaRepository, IMapper mapper)
        {
            _mediaRepository = mediaRepository;
            _mapper = mapper;
        }

        public async Task<List<MediaDto>> GetAllMedia()
        {
            var mediaList = await _mediaRepository.GetAllAsync();
            return _mapper.Map<List<MediaDto>>(mediaList);
        }

        public async Task<MediaDto> GetMediaById(Guid mediaId)
        {
            var media = await _mediaRepository.FindByIdAsync(mediaId);
            return _mapper.Map<MediaDto>(media);
        }

        public async Task CreateMedia(MediaDto mediaDto)
        {
            var media = _mapper.Map<Media>(mediaDto);
            _mediaRepository.Create(media);
            await _mediaRepository.SaveAsync();
        }

        public async Task UpdateMedia(Guid mediaId, MediaDto mediaDto)
        {
            var existingMedia = await _mediaRepository.FindByIdAsync(mediaId);
            if (existingMedia == null)
            {
                throw new InvalidOperationException($"Media cu ID-ul {mediaId} nu există.");
            }

            _mapper.Map(mediaDto, existingMedia);
            _mediaRepository.Update(existingMedia);
            await _mediaRepository.SaveAsync();
        }

        public async Task DeleteMedia(Guid mediaId)
        {
            var media = await _mediaRepository.FindByIdAsync(mediaId);
            if (media != null)
            {
                _mediaRepository.Delete(media);
                await _mediaRepository.SaveAsync();
            }
        }
    }
}
