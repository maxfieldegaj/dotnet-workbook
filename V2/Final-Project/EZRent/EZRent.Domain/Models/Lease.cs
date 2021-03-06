﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EZRent.Domain.Models
{
    public class Lease
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public string TenantId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int LeaseTypeId { get; set; }

        // navigation
        public LeaseType Type { get; set; }
    }
}
