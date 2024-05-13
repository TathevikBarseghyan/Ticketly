namespace Ticketly.Domain.Entities
{
    public class Event
    {
        public Event()
        {
            ArtistEvents = new HashSet<ArtistEvent>();
            Tickets = new HashSet<Ticket>();
            UserEvents = new HashSet<UserEvent>();
        }
        public int EventId { get; set; }
        public string EventName { get; set; }
        public DateTime DateTime { get; set; }
        public string? EventDescription { get; set; }
        public int VenueId { get; set; }
        public int CategoryId { get; set; }

        public Venue Venue { get; set; }
        public Category Category { get; set; }

        public ICollection<ArtistEvent> ArtistEvents { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
        public ICollection<Booking> Booking { get; set; }
        public ICollection<UserEvent> UserEvents { get; set; }
    }
}
