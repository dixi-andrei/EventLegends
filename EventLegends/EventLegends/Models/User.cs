namespace EventLegends.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        //Relatie One-to-Many
        public List<EventParticipant> EventParticipants { get; set; } 

        //Relatie One-to-Many
        public List<Notification> Notifications { get; set; }

        public User()
        {
            Notifications = new List<Notification>();
            EventParticipants = new List<EventParticipant> { };
        }
        public User(int UserId,string Username,string Email) :this()
        {
            this.UserId = UserId;
            this.Username = Username;
            this.Email = Email;
        }

        public void AddNotifications(Notification Notification)
        {
           this.Notifications.Add(Notification);
        }

        public void AddEventParticipants(EventParticipant EventParticipant)
        {
            this.EventParticipants.Add(EventParticipant);
        }

    }
}
