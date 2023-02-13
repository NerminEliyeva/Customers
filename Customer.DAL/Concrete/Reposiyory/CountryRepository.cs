using Customer.DAL.Abstract.Repository;
using Customer.DAL.Concrete.EntityFramework;
using Customer.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.DAL.Concrete.Reposiyory
{
    public class CountryRepository : BaseRepository<Countries>, ICountryRepository
    {
        public CountryRepository(CustomerDbContext customerDbContext) : base(customerDbContext)
        {
        }
    }
}
