using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ZooApp.Models;

namespace ZooApp.data
{

    public class ZooAppContext : IdentityDbContext<IdentityUser>
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

        public DbSet<ZooApp.Models.Ticket> Ticket { get; set; } = default!;

        public DbSet<VisitorEventAttendance> VisitorEventAttendances { get; set; }

        public DbSet<ZooApp.Models.VisitorLog> VisitorLogs { get; set; } = default!;

        public DbSet<ZooApp.Models.AnimalEmployee> AnimalEmployee { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });
            });

            modelBuilder.Entity<Animal>().ToTable("Animal");
            modelBuilder.Entity<Event>().ToTable("Event");
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Enclosure>().ToTable("Enclosure");
            modelBuilder.Entity<Visitor>().ToTable("Visitor");
            modelBuilder.Entity<AnimalEmployee>().ToTable("AnimalEmployee");
            modelBuilder.Entity<VisitorLog>().ToTable("VisitorLog");
            modelBuilder.Entity<VisitorEventAttendance>().ToTable("VisitorEventAttendance");
            modelBuilder.Entity<Ticket>().ToTable("Ticket");

            // Seeding data for the Event table
            modelBuilder.Entity<Event>().HasData(
                new Event { EventId = 1, Name = "Zoo Safari", Date = DateTime.Now.AddDays(10), Description = "Guided safari tour through the zoo", TicketPrice = 25m },
                new Event { EventId = 2, Name = "Wildlife Conservation Talk", Date = DateTime.Now.AddDays(17), Description = "Educational talk on wildlife conservation", TicketPrice = 10m }
            );

            // Seeding data for the Employee table
            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmployeeId = 1, Name = "John Doe", Role = RoleType.Zookeeper, Phone = "123-456-7890", Salary = 50000m, HireDate = DateTime.Now.AddDays(-30), EnclosureId = 1 },
                new Employee { EmployeeId = 2, Name = "Jane Smith", Role = RoleType.Veterinarian, Phone = "987-654-3210", Salary = 70000m, HireDate = DateTime.Now.AddDays(-20), EnclosureId = 2 }
            
            );

            // Seeding data for the Enclosure table
            modelBuilder.Entity<Enclosure>().HasData(
                new Enclosure { EnclosureId = 1, Name = "Lion Enclosure", Habitat = "Savannah", Capacity = 5 },
                new Enclosure { EnclosureId = 2, Name = "Elephant Enclosure", Habitat = "Jungle", Capacity = 10 }
           
            );

            // Seeding data for the Visitor table
            modelBuilder.Entity<Visitor>().HasData(
                new Visitor { VisitorId = 1, Name = "Alice", Email = "alice@example.com", Phone = "123-456-7890", Address = "123 Main St" },
                new Visitor { VisitorId = 2, Name = "Bob", Email = "bob@example.com", Phone = "987-654-3210", Address = "456 Elm St" }
       
            );

            // Seeding data for the Animal table
            modelBuilder.Entity<Animal>().HasData(
                new Animal { AnimalId = 1, Name = "Lion", Species = "Panthera leo", Age = 5, Sex = Sex.Male, Diet = DietType.Carnivore, EmployeeId = 1, EnclosureId = 1 },
                new Animal { AnimalId = 2, Name = "Elephant", Species = "Loxodonta africana", Age = 10, Sex = Sex.Female, Diet = DietType.Herbivore, EmployeeId = 2, EnclosureId = 2 }
          
            );

            // Seeding data for the Ticket table
            modelBuilder.Entity<Ticket>().HasData(
                new Ticket { TicketId = 1, DateOfPurchase = DateTime.Now.AddDays(-2), EventId = 1, VisitorId = 1 },
                new Ticket { TicketId = 2, DateOfPurchase = DateTime.Now.AddDays(-1), EventId = 2, VisitorId = 2 }
         
            );

            // Seeding data for the AnimalEmployee table (junction table)
            modelBuilder.Entity<AnimalEmployee>().HasData(
                new AnimalEmployee { AnimalEmployeeId = 1, AnimalId = 1, EmployeeId = 1 },
                new AnimalEmployee { AnimalEmployeeId = 2, AnimalId = 2, EmployeeId = 2 }
         
            );

            // Seeding data for the VisitorAttendance table (junction table)
            modelBuilder.Entity<VisitorEventAttendance>().HasData(
                new VisitorEventAttendance { VisitorEventAttendanceId=1, VisitorId = 1, EventId = 1 },
              new VisitorEventAttendance { VisitorEventAttendanceId=2, VisitorId = 2, EventId = 2 }
          
            );

            
            // Seeding data for the VisitorLog table
            modelBuilder.Entity<VisitorLog>().HasData(
                new VisitorLog { VisitorLogId = 1, VisitorId = 1, DateVisited = DateTime.Now.AddDays(-2), Comments = "Enjoyed the zoo!" },
                new VisitorLog { VisitorLogId = 2, VisitorId = 2, DateVisited = DateTime.Now.AddDays(-1), Comments = "Great experience!" }
        
            );
        }


    }

}
