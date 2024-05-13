using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketly.Domain.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public int EventId { get; set; }
        public Event Event { get; set; }
        public ICollection<CategoryTypeAssociation> CategoryTypeAssociations {  get; set; } 

    }
}
