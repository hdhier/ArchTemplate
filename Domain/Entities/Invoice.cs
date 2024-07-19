using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Invoice
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid CustomerId { get; }

        // * Navigational properties * //

        public Customer Customer { get; set; }

        // * End of navigational properties * //
    }
}
