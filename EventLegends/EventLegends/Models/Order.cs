namespace EventLegends.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public int OrderTotalPrice { get; set; }

        //Relatie Many-to-One
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }

        public Order() { }

        public Order(int orderId, int quantity, int orderTotalPrice, Ticket ticket)
        {
            OrderId = orderId;
            Quantity = quantity;
            OrderTotalPrice = orderTotalPrice;
            Ticket = ticket;
        }
    }
}
