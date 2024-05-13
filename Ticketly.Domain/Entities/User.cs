namespace Ticketly.Domain.Entities
{
    public class User
    {
        public User()
        {
            UserBookings = new HashSet<UserBooking>(); 
            Orders = new HashSet<Order>();
            UserEvents =  new HashSet<UserEvent>();
        }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICollection<UserBooking> UserBookings { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<UserEvent> UserEvents { get; set; }

    }
}
