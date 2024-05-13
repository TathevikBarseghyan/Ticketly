namespace Ticketly.Domain.Entities
{
    public class Booking
    {
        public Booking()
        {
            Tickets = new HashSet<Ticket>();
            UserBookings = new HashSet<UserBooking>();
        }
        public int BookingId { get; set; }
        public DateTime BookingDate { get; set; }
        public int EventId { get; set; }

        public Event Event { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
        public ICollection<UserBooking> UserBookings { get; set; }

    }
}
