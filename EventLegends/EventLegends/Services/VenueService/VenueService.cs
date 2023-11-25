using AutoMapper;
using EventLegends.Models.DTOs;
using EventLegends.Models;
using EventLegends.Repositories.VenueRepository;

namespace EventLegends.Services.VenueService
{
    public class VenueService : IVenueService
    {
        private readonly IVenueRepository _venueRepository;
        private readonly IMapper _mapper;

        public VenueService(IVenueRepository venueRepository, IMapper mapper)
        {
            _venueRepository = venueRepository;
            _mapper = mapper;
        }

        public async Task<List<VenueDto>> GetAllVenues()
        {
            var venueList = await _venueRepository.GetAllAsync();
            return _mapper.Map<List<VenueDto>>(venueList);
        }

        public async Task<VenueDto> GetVenueById(Guid venueId)
        {
            var venue = await _venueRepository.FindByIdAsync(venueId);
            return _mapper.Map<VenueDto>(venue);
        }

        public async Task CreateVenue(VenueDto venueDto)
        {
            var venueEntity = _mapper.Map<Venue>(venueDto);
            _venueRepository.Create(venueEntity);
            await _venueRepository.SaveAsync();
        }

        public async Task UpdateVenue(Guid venueId, VenueDto venueDto)
        {
            var existingVenue = await _venueRepository.FindByIdAsync(venueId);
            if (existingVenue == null)
            {
                throw new InvalidOperationException($"Venue-ul cu id-ul {venueId} nu exista!");
            }

            _mapper.Map(venueDto, existingVenue);
            _venueRepository.Update(existingVenue);
            await _venueRepository.SaveAsync();
        }

        public async Task DeleteVenue(Guid venueId)
        {
            var venueToDelete = await _venueRepository.FindByIdAsync(venueId);
            if (venueToDelete != null)
            {
                _venueRepository.Delete(venueToDelete);
                await _venueRepository.SaveAsync();
            }
        }
    }
}
