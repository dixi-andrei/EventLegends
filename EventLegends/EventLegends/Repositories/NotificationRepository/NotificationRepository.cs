using EventLegends.Data;
using EventLegends.Models;
using EventLegends.Repositories.GenericRepository;

namespace EventLegends.Repositories.NotificationRepository
{
    public class NotificationRepository : GenericRepository<Notification>, INotificationRepository
    {
        public NotificationRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
