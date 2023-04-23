using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Models.Request
{
    public class CustomerAndCity
    {
        public CustomerDto CustomerDto { get; set; }
        public string CityName { get; set; }
    }
}
