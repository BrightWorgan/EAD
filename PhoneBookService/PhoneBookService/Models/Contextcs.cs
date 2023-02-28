using System;
using Microsoft.EntityFrameworkCore;

namespace PhoneBookService.Models
{
    public class Contextcs : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        private const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=Contacts;Trusted_Connection=False;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);

        }
    }
}
