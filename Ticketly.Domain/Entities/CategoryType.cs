using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketly.Domain.Entities
{
    public class CategoryType
    {
        public int TypeId { get; set; }
        public string TypeName { get; set; }

        public ICollection<CategoryTypeAssociation> CategoryTypeAssociations { get; set; }
    }
}
