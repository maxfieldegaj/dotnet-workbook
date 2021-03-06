﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EZRent.Domain.Models
{
    public class Property
    {
        public int Id { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required, DataType(DataType.PostalCode)]
        public string Zipcode { get; set; }

        [Required]
        public int PropertyTypeId { get; set; }

        [Required]
        public string LandlordId { get; set; }
        public string CurrentTenantId { get; set; }

        public string Image { get; set; }
        // navigation
        public PropertyType Type { get; set; }


    }
}
