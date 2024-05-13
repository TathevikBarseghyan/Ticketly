using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketly.Domain.Entities
{
    public class ArtistEvent
    {
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
    }
}
