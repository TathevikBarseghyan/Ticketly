using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketly.Domain.Entities
{
    public class CategoryTypeAssociation
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int TypeId { get; set; }
        public CategoryType CategoryType { get; set; }
    }
}
