using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Task_22.Models
{
    public class PhoneBookV1Context : DbContext
    {
        public DbSet<Contact> PhoneBook { get; set; }

        private const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=PhoneBook;Trusted_Connection=False;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);

        }
    }
}
