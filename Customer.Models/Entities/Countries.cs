using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Models.Entities
{
    public class Countries
    {
        [Key]
        public int CountryId { get; set; }
        public string CountryName { get; set; }
    }
}
