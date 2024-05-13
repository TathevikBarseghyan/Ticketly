using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketly.Domain.Entities
{
    public class UserBooking
    {
        public int BookingId { get; set; }
        public Booking Booking { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
