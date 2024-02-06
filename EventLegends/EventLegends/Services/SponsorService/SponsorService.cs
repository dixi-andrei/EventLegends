using AutoMapper;
using EventLegends.Models;
using EventLegends.Models.Base;
using EventLegends.Models.DTOs;
using EventLegends.Repositories.SponsorRepository;
using EventLegends.Services.SponsorService;

namespace EventLegends.Services.SponsorService
{
    public class SponsorService : ISponsorService
    {
        private readonly ISponsorRepository _sponsorRepository;
        private readonly IMapper _mapper;

        public SponsorService(ISponsorRepository sponsorRepository, IMapper mapper)
        {
            _sponsorRepository = sponsorRepository;
            _mapper = mapper;
        }

        public async Task<List<SponsorDTO>> GetAllSponsors()
        {
            var sponsors = await _sponsorRepository.GetAllAsync();
            return _mapper.Map<List<SponsorDTO>>(sponsors);
        }

        public async Task<SponsorDTO> GetSponsorById(Guid sponsorId)
        {
            var sponsor = await _sponsorRepository.FindByIdAsync(sponsorId);
            return _mapper.Map<SponsorDTO>(sponsor);
        }

        public async Task CreateSponsor(SponsorDTO sponsorDto)
        {
            var sponsor = _mapper.Map<Sponsor>(sponsorDto);
            _sponsorRepository.Create(sponsor);
            await _sponsorRepository.SaveAsync();
        }

        public async Task UpdateSponsor(Guid sponsorId, SponsorDTO sponsorDto)
        {
            var existingSponsor = await _sponsorRepository.FindByIdAsync(sponsorId);
            if (existingSponsor == null)
            {
                throw new InvalidOperationException($"Sponsorul cu ID-ul {sponsorId} nu există.");
            }

            _mapper.Map(sponsorDto, existingSponsor);
            _sponsorRepository.Update(existingSponsor);
            await _sponsorRepository.SaveAsync();
        }

        public async Task DeleteSponsor(Guid sponsorId)
        {
            var sponsor = await _sponsorRepository.FindByIdAsync(sponsorId);
            if (sponsor != null)
            {
                _sponsorRepository.Delete(sponsor);
                await _sponsorRepository.SaveAsync();
            }
        }
    }
}
