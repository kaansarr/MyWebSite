using Microsoft.EntityFrameworkCore;
using MyWebSite.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSite.DAL.Contexts
{
    public class SqlContext:DbContext
    {
        public SqlContext(DbContextOptions<SqlContext>options):base(options)
        {

        }
        
        public DbSet<Hakkimda> Hakkimda { get; set; }  
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Yeteneklerim> Yeteneklerim { get; set; }
        public DbSet<Egitim> Egitimlerim { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>().HasData(new Admin { ID = 1, Name = "Kaan", Surname = "Sar", Username = "kaan", Password = "5a30387b10e5dbe5571db7af5a87410e" });



        }

    }
}
