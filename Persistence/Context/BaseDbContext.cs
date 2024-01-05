using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RentACarCleanArcitecture.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Persistence.Context
{
    public class BaseDbContext : DbContext
    {

        public BaseDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions) 
        { 
            Configuration = configuration; 
            Database.EnsureCreated(); 
        }

        protected IConfiguration Configuration { get; set; }


        public DbSet<Brand> Brands { get; set; }
    }
}
