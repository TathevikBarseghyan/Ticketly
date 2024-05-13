namespace Ticketly.Domain.Entities
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public int SeatNumber { get; set; }
        public decimal Price { get; set; }
        public bool IsBooked { get; set; }
        public int EventId { get; set; }
        public int BookingId { get; set; }
        public int OrderId { get; set; }

        public Event Event { get; set; }
        public Booking Booking { get; set; }
        public Order Order { get; set; }
    }
}
