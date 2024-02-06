using EventLegends.Models.DTOs;
using EventLegends.Services.TagService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace EventLegends.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        private readonly ITagService _tagService;

        public TagsController(ITagService tagService)
        {
            _tagService = tagService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTags()
        {
            var tags = await _tagService.GetAllTags();
            return Ok(tags);
        }

        [HttpGet("{tagId}")]
        public async Task<IActionResult> GetTagById([FromRoute] Guid tagId)
        {
            var tag = await _tagService.GetTagById(tagId);

            if (tag == null)
            {
                return NotFound();
            }

            return Ok(tag);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTag([FromBody] TagDTO tagDto)
        {
            await _tagService.CreateTag(tagDto);
            return Ok();
        }

        [HttpPut("{tagId}")]
        public async Task<IActionResult> UpdateTag([FromRoute] Guid tagId, [FromBody] TagDTO tagDto)
        {
            await _tagService.UpdateTag(tagId, tagDto);
            return Ok();
        }

        [HttpDelete("{tagId}")]
        public async Task<IActionResult> DeleteTag([FromRoute] Guid tagId)
        {
            await _tagService.DeleteTag(tagId);
            return Ok();
        }
    }
}

