                          using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fleet.NewFolder;
using Microsoft.EntityFrameworkCore;

namespace Fleet.Models
{
    public class CarContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        private const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=Fleet;Trusted_Connection=False;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);

        }

    }
}
