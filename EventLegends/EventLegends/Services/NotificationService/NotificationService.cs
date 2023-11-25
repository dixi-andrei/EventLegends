using AutoMapper;
using EventLegends.Models;
using EventLegends.Models.DTOs;
using EventLegends.Repositories.NotificationRepository;

namespace EventLegends.Services.NotificationService
{
    public class NotificationService : INotificationService
    {
        private readonly INotificationRepository _notificationRepository;
        private readonly Mapper _mapper;

        public NotificationService(NotificationRepository notificationRepository, Mapper mapper)
        {
            _notificationRepository = notificationRepository;
            _mapper = mapper;
        }

        public async Task CreateNotification(NotificationDto notificationDto)
        {
            var notificationEntity = _mapper.Map<Notification>(notificationDto);
            _notificationRepository.Create(notificationEntity);
            await _notificationRepository.SaveAsync();
        }

        public async Task DeleteNotification(Guid notificationId)
        {
            var notification = await _notificationRepository.FindByIdAsync(notificationId);
            if(notification != null)
            {
                _notificationRepository.Delete(notification);
                await _notificationRepository.SaveAsync();
            }
        }

        public async Task<List<NotificationDto>> GetAllNotifications()
        {
            var notifications = await _notificationRepository.GetAllAsync();
            return _mapper.Map<List<NotificationDto>>(notifications); 
        }

        public async Task<NotificationDto> GetNotificationById(Guid notificationId)
        {
            var notification = await _notificationRepository.FindByIdAsync(notificationId);
            return _mapper.Map<NotificationDto>(notification);
        }

        public async Task UpdateNotification(Guid notificationId, NotificationDto notificationDto)
        {
            var existingNotification = await _notificationRepository.FindByIdAsync(notificationId);
            if (existingNotification == null)
            {

                throw new InvalidOperationException($"Notificarea cu id-ul {notificationId} nu exista");
            }

            _mapper.Map(notificationDto, existingNotification);
            _notificationRepository.Update(existingNotification);
            await _notificationRepository.SaveAsync();
        }
    }
}
