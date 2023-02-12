using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.DAL.Concrete.EntityFramework
{
    public class CustomersDbContext : DbContext
    {
        public CustomersDbContext(DbContextOptions<CustomersDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
    }
}
