using System;
using System.Collections.Generic;
using System.Text;

namespace ShowerQ.Shared.Models.Entities
{
    class Tenant
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public Gender Gender { get; set; }

        public string Room { get; set; }
    }
}
