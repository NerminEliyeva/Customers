using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Models.Request
{
    public class UpdatedCustomers
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerPosition { get; set; }
        public int CustomerCity { get; set; }
        public double CustomerSalary { get; set; }
    }
}
