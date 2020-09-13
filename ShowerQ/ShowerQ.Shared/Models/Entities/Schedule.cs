using System;
using System.Collections.Generic;
using System.Text;

namespace ShowerQ.Shared.Models.Entities
{
    class Schedule
    {
        public int Id { get; set; }

        public IEnumerable<Interval> Intervals { get; set; }

        public int TenantsPerInterval { get; set; }
    }
}
