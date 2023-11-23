using EventLegends.Models.Base;

namespace EventLegends.Models
{
    public class Review : BaseEntity
    {
        public string Comment{ get; set; }

        //Relatie Many-to-One
        public Guid EventId { get; set; }
        public Event Event { get; set; }

        /*
        Review() { 
           
        }

        public Review(int reviewId,string comment,Event Event){
            ReviewId = reviewId;
            Comment = comment;
            this.Event = Event;
        }
        */
    }
}
