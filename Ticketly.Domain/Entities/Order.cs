﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketly.Domain.Entities
{
    public class Order
    {
        public int OrderId {  get; set; }
        public int UserId { get; set; }
        
        public User User { get; set; }
        public ICollection<Ticket> Tickets { get; set; }

    }
}
