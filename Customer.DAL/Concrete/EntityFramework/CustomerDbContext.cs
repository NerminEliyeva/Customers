using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customer.Models.Entities;

namespace Customer.DAL.Concrete.EntityFramework
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Customers> Customers { get; set; }       
        public DbSet<Countries> Countries { get; set; }
    }
}
