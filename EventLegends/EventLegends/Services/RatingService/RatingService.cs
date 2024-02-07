using AutoMapper;
using EventLegends.Models;
using EventLegends.Models.Base;
using EventLegends.Models.DTOs;
using EventLegends.Repositories.RatingRepository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventLegends.Services.RatingService
{
    public class RatingService : IRatingService
    {
        private readonly IRatingRepository _ratingRepository;
        private readonly IMapper _mapper;

        public RatingService(IRatingRepository ratingRepository, IMapper mapper)
        {
            _ratingRepository = ratingRepository;
            _mapper = mapper;
        }

        public async Task<List<RatingDto>> GetAllRatings()
        {
            var ratings = await _ratingRepository.GetAllAsync();
            return _mapper.Map<List<RatingDto>>(ratings);
        }

        public async Task<RatingDto> GetRatingById(Guid ratingId)
        {
            var rating = await _ratingRepository.FindByIdAsync(ratingId);
            return _mapper.Map<RatingDto>(rating);
        }

        public async Task CreateRating(RatingDto ratingDto)
        {
            var rating = _mapper.Map<Rating>(ratingDto);
            _ratingRepository.Create(rating);
            await _ratingRepository.SaveAsync();
        }

        public async Task UpdateRating(Guid ratingId, RatingDto ratingDto)
        {
            var existingRating = await _ratingRepository.FindByIdAsync(ratingId);
            if (existingRating == null)
            {
                throw new InvalidOperationException($"Rating-ul cu ID-ul {ratingId} nu există.");
            }

            _mapper.Map(ratingDto, existingRating);
            _ratingRepository.Update(existingRating);
            await _ratingRepository.SaveAsync();
        }

        public async Task DeleteRating(Guid ratingId)
        {
            var rating = await _ratingRepository.FindByIdAsync(ratingId);
            if (rating != null)
            {
                _ratingRepository.Delete(rating);
                await _ratingRepository.SaveAsync();
            }
        }
    }
}
