﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Models.Entities
{
    public class Customers
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerPosition { get; set; }
        public int CustomerCity { get; set; }
        public double CustomerSalary { get; set; }
        public int CustomerStatus { get; set; }

    }
}
