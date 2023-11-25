using EventLegends.Models.DTOs;
using EventLegends.Services.ReviewService;
using Microsoft.AspNetCore.Mvc;

namespace EventLegends.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly IReviewService _reviewService;

        public ReviewsController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllReviews()
        {
            var reviews = await _reviewService.GetAllReviews();
            return Ok(reviews);
        }

        [HttpGet("{reviewId}")]
        public async Task<IActionResult> GetReviewById([FromRoute] Guid reviewId)
        {
            var review = await _reviewService.GetReviewById(reviewId);

            if (review == null)
            {
                return NotFound();
            }

            return Ok(review);
        }

        [HttpPost]
        public async Task<IActionResult> CreateReview([FromBody] ReviewDto reviewDto)
        {
            await _reviewService.CreateReview(reviewDto);
            return Ok();
        }

        [HttpPut("{reviewId}")]
        public async Task<IActionResult> UpdateReview([FromRoute] Guid reviewId, [FromBody] ReviewDto reviewDto)
        {
            await _reviewService.UpdateReview(reviewId, reviewDto);
            return Ok();
        }

        [HttpDelete("{reviewId}")]
        public async Task<IActionResult> DeleteReview([FromRoute] Guid reviewId)
        {
            await _reviewService.DeleteReview(reviewId);
            return Ok();
        }
    }

}
