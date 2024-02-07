using EventLegends.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventLegends.Services.RatingService
{
    public interface IRatingService
    {
        Task<List<RatingDto>> GetAllRatings();
        Task<RatingDto> GetRatingById(Guid ratingId);
        Task CreateRating(RatingDto ratingDto);
        Task UpdateRating(Guid ratingId, RatingDto ratingDto);
        Task DeleteRating(Guid ratingId);
    }
}
