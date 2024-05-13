namespace Ticketly.Domain.Entities
{
    public class Venue
    {
        public Venue()
        {
            Events =  new HashSet<Event>();
        }
        public int VenueId { get; set; }
        public string VenueName { get; set; }
        public string VenueAddress { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}
