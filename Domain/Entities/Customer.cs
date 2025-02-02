﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        // * Navigational properties * //

        public ICollection<Invoice> Invoices { get; set; }

        // * End of navigational properties * //
    }
}
