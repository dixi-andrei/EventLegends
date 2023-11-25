using EventLegends.Models.DTOs;

namespace EventLegends.Services.NotificationService
{
    public interface INotificationService
    {
        Task<List<NotificationDto>> GetAllNotifications();
        Task<NotificationDto> GetNotificationById(Guid notificationId);
        Task CreateNotification(NotificationDto notificationDto);
        Task UpdateNotification(Guid notificationId, NotificationDto notificationDto);
        Task DeleteNotification(Guid notificationId);
    }
}
