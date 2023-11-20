namespace EventLegends.Models
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public string Content { get; set; }
        public DateTime NotificationTime { get; set; }

        //Relatie Many-to-One
        public int UserId { get; set; }
        public User User { get; set; }

        public Notification() { }
        public Notification(int notificationId, string content, DateTime notificationTime,User user)
        {
            NotificationId = notificationId;
            Content = content;
            NotificationTime = notificationTime;
            User = user;
        }
    }
}
