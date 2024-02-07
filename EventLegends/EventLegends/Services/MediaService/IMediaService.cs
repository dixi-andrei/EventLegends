using EventLegends.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventLegends.Services.MediaService
{
    public interface IMediaService
    {
        Task<List<MediaDto>> GetAllMedia();
        Task<MediaDto> GetMediaById(Guid mediaId);
        Task CreateMedia(MediaDto mediaDto);
        Task UpdateMedia(Guid mediaId, MediaDto mediaDto);
        Task DeleteMedia(Guid mediaId);
    }
}
