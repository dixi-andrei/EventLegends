using EventLegends.Models.DTOs;
using EventLegends.Services.RatingService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace EventLegends.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingsController : ControllerBase
    {
        private readonly IRatingService _ratingService;

        public RatingsController(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRatings()
        {
            var ratings = await _ratingService.GetAllRatings();
            return Ok(ratings);
        }

        [HttpGet("{ratingId}")]
        public async Task<IActionResult> GetRatingById([FromRoute] Guid ratingId)
        {
            var rating = await _ratingService.GetRatingById(ratingId);

            if (rating == null)
            {
                return NotFound();
            }

            return Ok(rating);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRating([FromBody] RatingDto ratingDto)
        {
            await _ratingService.CreateRating(ratingDto);
            return Ok();
        }

        [HttpPut("{ratingId}")]
        public async Task<IActionResult> UpdateRating([FromRoute] Guid ratingId, [FromBody] RatingDto ratingDto)
        {
            await _ratingService.UpdateRating(ratingId, ratingDto);
            return Ok();
        }

        [HttpDelete("{ratingId}")]
        public async Task<IActionResult> DeleteRating([FromRoute] Guid ratingId)
        {
            await _ratingService.DeleteRating(ratingId);
            return Ok();
        }
    }
}
