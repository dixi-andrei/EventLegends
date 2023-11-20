namespace EventLegends.Models
{
    public class Review
    {
        public int ReviewId { get; set; }   
        public string Comment{ get; set; }

        //Relatie Many-to-One
        public int EventId { get; set; }
        public Event Event { get; set; }

        Review() { }

        public Review(int reviewId,string comment,Event Event){
            ReviewId = reviewId;
            Comment = comment;
            this.Event = Event;
        }
    }
}
