using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CarRentalWebApiReDesign.Domain.Context
{
    public class CarRentalContext:DbContext
    {
        public CarRentalContext(DbContextOptions<CarRentalContext> options) : base(options)
        {

        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Color> Colors { get; set; }

    }
}
