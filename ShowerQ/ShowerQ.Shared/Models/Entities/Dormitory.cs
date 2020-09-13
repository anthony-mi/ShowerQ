using System;
using System.Collections.Generic;
using System.Text;

namespace ShowerQ.Shared.Models.Entities
{
    class Dormitory
    {
        public int Id { get; set; }
        
        public City City { get; set; }

        public University University { get; set; }

        public IEnumerable<Tenant> Tenants { get; set; }

        public Schedule Schedule { get; set; }
    }
}
