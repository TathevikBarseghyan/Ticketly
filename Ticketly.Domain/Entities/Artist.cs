namespace Ticketly.Domain.Entities
{
    public class Artist
    {
        public Artist()
        {
            ArtistEvents = new HashSet<ArtistEvent>();    
        }
        public int ArtistId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Description { get; set; }

        public ICollection<ArtistEvent> ArtistEvents {  get; set; }  
    }
}
