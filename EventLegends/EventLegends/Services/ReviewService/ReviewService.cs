using AutoMapper;
using EventLegends.Models;
using EventLegends.Models.DTOs;
using EventLegends.Repositories.ReviewRepository;

namespace EventLegends.Services.ReviewService
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly Mapper _mapper;

        public ReviewService(IReviewRepository reviewRepository, Mapper mapper)
        {
            this._reviewRepository = reviewRepository;
            _mapper = mapper;
        }

        public async Task CreateReview(ReviewDto review)
        {
            var reviewentity = _mapper.Map<Review>(review);
            _reviewRepository.Update(reviewentity);
            await _reviewRepository.SaveAsync();
        }

        public async Task DeleteReview(Guid id)
        {
            var review = await _reviewRepository.FindByIdAsync(id);
            if(review != null)
            {
                _reviewRepository.Delete(review);
                await _reviewRepository.SaveAsync();
            }
        }

        public async Task<List<ReviewDto>> GetAllReviews()
        {
            var reviews = await _reviewRepository.GetAllAsync();
            return _mapper.Map<List<ReviewDto>>(reviews);
        }

        public async Task<ReviewDto> GetReviewById(Guid id)
        {
            var review = await _reviewRepository.FindByIdAsync(id);
            return _mapper.Map<ReviewDto>(review);
        }

        public async Task UpdateReview(Guid id, ReviewDto review)
        {
            var existingreview = await _reviewRepository.FindByIdAsync(id);
            if(existingreview == null) {
                throw new InvalidOperationException($"Review-ul cu id {id} nu exista!");
            }

            _mapper.Map(existingreview, review);
            _reviewRepository.Update(existingreview);
            await _reviewRepository.SaveAsync();
        }
    }
}
