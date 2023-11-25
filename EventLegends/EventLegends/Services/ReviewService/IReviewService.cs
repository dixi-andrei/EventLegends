using EventLegends.Models.DTOs;

namespace EventLegends.Services.ReviewService
{
    public interface IReviewService
    {
        Task<List<ReviewDto>> GetAllReviews();
        Task<ReviewDto> GetReviewById(Guid id);
        Task CreateReview(ReviewDto review);
        Task UpdateReview(Guid id,ReviewDto review);
        Task DeleteReview(Guid id);
    }
}
