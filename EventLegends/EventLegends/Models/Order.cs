using EventLegends.Models.Base;

namespace EventLegends.Models
{
    public class Order : BaseEntity
    {
        public int Quantity { get; set; }
        public int OrderTotalPrice { get; set; }

        //Relatie Many-to-One
        public Guid TicketId { get; set; }
        public Ticket Ticket { get; set; }

        /*
        public Order() { }

        public Order(int orderId, int quantity, int orderTotalPrice)//,Ticket ticket
        {
            OrderId = orderId;
            Quantity = quantity;
            OrderTotalPrice = orderTotalPrice;
            //Ticket = ticket;
        }
        */
    }
}
