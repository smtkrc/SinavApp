using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinavProje.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-5OBCDS9\\SQLEXPRESS; database=Coresinav; integrated security=true;");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Sorular> Sorulars { get; set; }
        public DbSet<SorularDetay> SoruDetays { get; set; }
    }
}
