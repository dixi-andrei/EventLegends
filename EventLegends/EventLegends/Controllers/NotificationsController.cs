using EventLegends.Models.DTOs;
using EventLegends.Services.NotificationService;
using Microsoft.AspNetCore.Mvc;

namespace EventLegends.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : Controller
    {
        private readonly INotificationService notificationService;

        public NotificationsController(INotificationService notificationService)
        {
            this.notificationService = notificationService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllNotifications()
        {
            var notifications = await notificationService.GetAllNotifications();
            return Ok(notifications);
        }

        [HttpGet("{notificationId}")]
        public async Task<IActionResult> GetNotificationById([FromRoute] Guid id)
        {
            var notification = await notificationService.GetNotificationById(id);
            if (notification == null)
            {
                return NotFound();
            }
            return Ok(notification);
        }

        [HttpPost]
        public async Task<IActionResult> CreateNotification([FromBody]NotificationDto notification)
        {
            await notificationService.CreateNotification(notification);
            return Ok();
        }

        [HttpPut("{notificationId}")]
        public async Task<IActionResult> UpdateNotification([FromRoute]Guid id,[FromBody]NotificationDto notificationDto)
        {
            await notificationService.UpdateNotification(id, notificationDto);
            return Ok();
        }

        [HttpDelete("{notificationId}")]
        public async Task<IActionResult> DeleteNotification([FromRoute] Guid id)
        {
            await notificationService.DeleteNotification(id);
            return Ok();
        }
    }
}
