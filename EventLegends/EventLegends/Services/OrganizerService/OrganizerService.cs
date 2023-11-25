using AutoMapper;
using EventLegends.Models;
using EventLegends.Models.DTOs;
using EventLegends.Repositories.OrganizerRepository;
using System.Runtime.InteropServices;

namespace EventLegends.Services.OrganizerService
{
    public class OrganizerService : IOrganizerService
    {
        private readonly IOrganizerRepository _organizerRepository;
        private readonly Mapper _mapper;

        public OrganizerService(IOrganizerRepository organizerRepository, Mapper mapper)
        {
            _organizerRepository = organizerRepository;
            _mapper = mapper;
        }

        public async Task CreateOrganizer(OrganizerDto organizer)
        {
            var organizerEntity = _mapper.Map<Organizer>(organizer);
            _organizerRepository.Create(organizerEntity);
            await _organizerRepository.SaveAsync();
        }

        public async Task DeleteOrganizer(Guid id)
        {
            var organizer = await _organizerRepository.FindByIdAsync(id);
            if (organizer != null)
            {
                _organizerRepository.Delete(organizer);
                await _organizerRepository.SaveAsync();
            }
        }

        public async Task<List<OrganizerDto>> GetAllOrganizers()
        {
            var organizers = await _organizerRepository.GetAllAsync();
            return _mapper.Map<List<OrganizerDto>>(organizers);
        }

        public async Task<OrganizerDto> GetOrganizerById(Guid id)
        {
            var organizer = await _organizerRepository.FindByIdAsync(id);
            return _mapper.Map<OrganizerDto>(organizer);
        }

        public async Task UpdateOrganizer(Guid id, OrganizerDto organizer)
        {
            var existingorganizer = await _organizerRepository.FindByIdAsync(id);
            if (existingorganizer == null)
            {
                throw new InvalidOperationException($"Organizer-ul cu id {id} nu exista");

            }
            
            _mapper.Map(organizer, existingorganizer);

            _organizerRepository.Update(existingorganizer);
            await _organizerRepository.SaveAsync();

        }
    }
}
