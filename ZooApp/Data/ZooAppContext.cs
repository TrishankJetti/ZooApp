using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZooApp.Models;

namespace ZooApp.data
{

    public class ZooAppContext : DbContext
    {

        public ZooAppContext(DbContextOptions<ZooAppContext> options)
            : base(options)
        {
        }


        public DbSet<ZooApp.Models.Event> Event { get; set; } = default!;

        public DbSet<ZooApp.Models.Animal> Animal { get; set; } = default!;

        public DbSet<ZooApp.Models.Employee> Employee { get; set; } = default!;

        public DbSet<ZooApp.Models.Enclosure> Enclosure { get; set; } = default!;

        public DbSet<ZooApp.Models.Visitor> Visitor { get; set; } = default!;

   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>().ToTable("Animal");
            modelBuilder.Entity<Event>().ToTable("Event");
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Enclosure>().ToTable("Enclosure");
            modelBuilder.Entity<Visitor>().ToTable("Visitor");
            
    
        }
  }
}
