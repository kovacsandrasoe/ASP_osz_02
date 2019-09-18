using CarShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Data
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> opt)
            :base(opt)
        {

        }

        public DbSet<Car> CarSQLTable { get; set; }
    }
}
