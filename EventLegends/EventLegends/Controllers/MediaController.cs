using EventLegends.Models.DTOs;
using EventLegends.Services.MediaService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace EventLegends.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaController : ControllerBase
    {
        private readonly IMediaService _mediaService;

        public MediaController(IMediaService mediaService)
        {
            _mediaService = mediaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMedia()
        {
            var mediaList = await _mediaService.GetAllMedia();
            return Ok(mediaList);
        }

        [HttpGet("{mediaId}")]
        public async Task<IActionResult> GetMediaById([FromRoute] Guid mediaId)
        {
            var media = await _mediaService.GetMediaById(mediaId);

            if (media == null)
            {
                return NotFound();
            }

            return Ok(media);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMedia([FromBody] MediaDto mediaDto)
        {
            await _mediaService.CreateMedia(mediaDto);
            return Ok();
        }

        [HttpPut("{mediaId}")]
        public async Task<IActionResult> UpdateMedia([FromRoute] Guid mediaId, [FromBody] MediaDto mediaDto)
        {
            await _mediaService.UpdateMedia(mediaId, mediaDto);
            return Ok();
        }

        [HttpDelete("{mediaId}")]
        public async Task<IActionResult> DeleteMedia([FromRoute] Guid mediaId)
        {
            await _mediaService.DeleteMedia(mediaId);
            return Ok();
        }
    }
}
