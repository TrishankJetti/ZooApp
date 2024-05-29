﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ZooApp.Data;
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
               new Event { EventId = 1, Name = "Zoo Safari", Date = DateTime.Now.AddDays(10), Description = "Guided safari tour through the zoo", TicketPrice = 25m, ImageFileName = "HI" },
        new Event { EventId = 2, Name = "Wildlife Conservation Talk", Date = DateTime.Now.AddDays(17), Description = "Educational talk on wildlife conservation", TicketPrice = 10m, ImageFileName = "HI" },
        new Event { EventId = 3, Name = "Night at the Zoo", Date = DateTime.Now.AddDays(25), Description = "Experience the zoo after dark with special activities and tours", TicketPrice = 30m, ImageFileName = "HI"},
        new Event { EventId = 4, Name = "Bird Watching Tour", Date = DateTime.Now.AddDays(30), Description = "Guided tour focusing on observing various bird species in the zoo", TicketPrice = 15m, ImageFileName = "HI" },
        new Event { EventId = 5, Name = "Animal Feeding Demonstration", Date = DateTime.Now.AddDays(40), Description = "Learn about animal diets and behavior during feeding time", TicketPrice = 20m, ImageFileName = "HI" }


               );

            // Seeding data for the Employee table
            modelBuilder.Entity<Employee>().HasData(
                  new Employee { EmployeeId = 1, Name = "John Doe", Role = RoleType.Zookeeper, Phone = "123-456-7890", Salary = 50000m, HireDate = DateTime.Now.AddDays(-30), EnclosureId = 1 }, 
                new Employee { EmployeeId = 2, Name = "Jane Smith", Role = RoleType.Veterinarian, Phone = "987-654-3210", Salary = 70000m, HireDate = DateTime.Now.AddDays(-20), EnclosureId = 2 }, 
                new Employee { EmployeeId = 3, Name = "Michael Johnson", Role = RoleType.Zookeeper, Phone = "111-222-3333", Salary = 55000m, HireDate = DateTime.Now.AddDays(-25), EnclosureId = 3 }, 
                new Employee { EmployeeId = 4, Name = "Emily Wilson", Role = RoleType.Veterinarian, Phone = "444-555-6666", Salary = 72000m, HireDate = DateTime.Now.AddDays(-15), EnclosureId = 4 }, 
                new Employee { EmployeeId = 5, Name = "Christopher Lee", Role = RoleType.Zookeeper, Phone = "777-888-9999", Salary = 52000m, HireDate = DateTime.Now.AddDays(-28), EnclosureId = 5 }, 
                new Employee { EmployeeId = 6, Name = "Jessica Brown", Role = RoleType.Veterinarian, Phone = "999-888-7777", Salary = 73000m, HireDate = DateTime.Now.AddDays(-10), EnclosureId = 6 }


            );

            // Seeding data for the Enclosure table
            modelBuilder.Entity<Enclosure>().HasData(
          new Enclosure { EnclosureId = 1, Name = "Savannah Enclosure", Habitat = "Savannah", Capacity = 5 }, 
          new Enclosure { EnclosureId = 2, Name = "Jungle Enclosure", Habitat = "Jungle", Capacity = 10 }, 
          new Enclosure { EnclosureId = 3, Name = "Forest Enclosure", Habitat = "Forest", Capacity = 7 }, 
          new Enclosure { EnclosureId = 4, Name = "River Enclosure", Habitat = "River", Capacity = 6 },
          new Enclosure { EnclosureId = 5, Name = "Aviary Enclosure", Habitat = "Aviary", Capacity = 8 }, 
          new Enclosure { EnclosureId = 6, Name = "Arctic Enclosure", Habitat = "Arctic", Capacity = 5 } 
);

            // Seeding data for the Visitor table
            modelBuilder.Entity<Visitor>().HasData(
                new Visitor { VisitorId = 1, Name = "Alice", Email = "alice@example.com", Phone = "123-456-7890", Address = "123 Main St" },
                new Visitor { VisitorId = 2, Name = "Bob", Email = "bob@example.com", Phone = "987-654-3210", Address = "456 Elm St" },
                  new Visitor { VisitorId = 3, Name = "Eva Martinez", Email = "eva@example.com", Phone = "111-111-1111", Address = "789 Oak St" },
                    new Visitor { VisitorId = 4, Name = "David Brown", Email = "david@example.com", Phone = "222-222-2222", Address = "101 Pine St" },
                    new Visitor { VisitorId = 5, Name = "Sophia Garcia", Email = "sophia@example.com", Phone = "333-333-3333", Address = "456 Maple Ave" },
                    new Visitor { VisitorId = 6, Name = "Liam Rodriguez", Email = "liam@example.com", Phone = "444-444-4444", Address = "789 Elm St" },
                    new Visitor { VisitorId = 7, Name = "Olivia Hernandez", Email = "olivia@example.com", Phone = "555-555-5555", Address = "123 Oak St" },
                    new Visitor { VisitorId = 8, Name = "Lucas Martinez", Email = "lucas@example.com", Phone = "666-666-6666", Address = "789 Pine Ave" },
                    new Visitor { VisitorId = 9, Name = "Isabella Nguyen", Email = "isabella@example.com", Phone = "777-777-7777", Address = "101 Maple St" },
                    new Visitor { VisitorId = 10, Name = "Mia Kim", Email = "mia@example.com", Phone = "888-888-8888", Address = "456 Oak Ave" },
                    new Visitor { VisitorId = 11, Name = "James Smith", Email = "james@example.com", Phone = "999-999-9999", Address = "123 Maple Ave" },
                    new Visitor { VisitorId = 12, Name = "Charlotte Johnson", Email = "charlotte@example.com", Phone = "101-101-1010", Address = "789 Pine St" },
                    new Visitor { VisitorId = 13, Name = "William Brown", Email = "william@example.com", Phone = "202-202-2020", Address = "456 Elm St" },
                    new Visitor { VisitorId = 14, Name = "Amelia Davis", Email = "amelia@example.com", Phone = "303-303-3030", Address = "123 Maple Ave" },
                    new Visitor { VisitorId = 15, Name = "Benjamin Wilson", Email = "benjamin@example.com", Phone = "404-404-4040", Address = "789 Elm Ave" },
                    new Visitor { VisitorId = 16, Name = "Emma Rodriguez", Email = "emma@example.com", Phone = "505-505-5050", Address = "101 Oak St" },
                    new Visitor { VisitorId = 17, Name = "Alexander Garcia", Email = "alexander@example.com", Phone = "606-606-6060", Address = "456 Pine Ave" }
       
            );

            // Seeding data for the Animal table
            modelBuilder.Entity<Animal>().HasData(
                new Animal { AnimalId = 1, Name = "Lion", Species = "Panthera leo", Age = 5, Sex = Sex.Male, Diet = DietType.Carnivore, EmployeeId = 1, EnclosureId = 1 },
                new Animal { AnimalId = 2, Name = "Elephant", Species = "Loxodonta africana", Age = 10, Sex = Sex.Female, Diet = DietType.Herbivore, EmployeeId = 2, EnclosureId = 2 },
                 new Animal { AnimalId = 3, Name = "Parrot", Species = "Psittaciformes", Age = 3, Sex = Sex.Female, Diet = DietType.Omnivore, EmployeeId = 5, EnclosureId = 5 },
                new Animal { AnimalId = 4, Name = "Tiger", Species = "Panthera tigris", Age = 6, Sex = Sex.Female, Diet = DietType.Carnivore, EmployeeId = 3, EnclosureId = 1 },
                new Animal { AnimalId = 5, Name = "Gorilla", Species = "Gorilla gorilla", Age = 12, Sex = Sex.Male, Diet = DietType.Omnivore, EmployeeId = 4, EnclosureId = 2 },
                new Animal { AnimalId = 6, Name = "Penguin", Species = "Aptenodytes forsteri", Age = 5, Sex = Sex.Male, Diet = DietType.Pescatarian, EmployeeId = 5, EnclosureId = 6 },
                new Animal { AnimalId = 7, Name = "Kangaroo", Species = "Macropus", Age = 4, Sex = Sex.Female, Diet = DietType.Herbivore, EmployeeId = 6, EnclosureId = 3 },
                new Animal { AnimalId = 8, Name = "Crocodile", Species = "Crocodylus", Age = 10, Sex = Sex.Male, Diet = DietType.Carnivore, EmployeeId = 3, EnclosureId = 4 },
                new Animal { AnimalId = 9, Name = "Zebra", Species = "Equus zebra", Age = 7, Sex = Sex.Female, Diet = DietType.Herbivore, EmployeeId = 4, EnclosureId = 1 },
                new Animal { AnimalId = 10, Name = "Panda", Species = "Ailuropoda melanoleuca", Age = 9, Sex = Sex.Male, Diet = DietType.Herbivore, EmployeeId = 5, EnclosureId = 2 },
                new Animal { AnimalId = 11, Name = "Giraffe", Species = "Giraffa", Age = 8, Sex = Sex.Female, Diet = DietType.Herbivore, EmployeeId = 6, EnclosureId = 3 },
                new Animal { AnimalId = 12, Name = "Lemur", Species = "Lemur", Age = 4, Sex = Sex.Male, Diet = DietType.Omnivore, EmployeeId = 3, EnclosureId = 4 },
                new Animal { AnimalId = 13, Name = "Polar Bear", Species = "Ursus maritimus", Age = 11, Sex = Sex.Female, Diet = DietType.Carnivore, EmployeeId = 4, EnclosureId = 6 },
                new Animal { AnimalId = 14, Name = "Hippo", Species = "Hippopotamus", Age = 6, Sex = Sex.Male, Diet = DietType.Herbivore, EmployeeId = 5, EnclosureId = 2 },
                new Animal { AnimalId = 15, Name = "Sloth", Species = "Bradypus", Age = 5, Sex = Sex.Female, Diet = DietType.Herbivore, EmployeeId = 6, EnclosureId = 4 },
                new Animal { AnimalId = 16, Name = "Wolf", Species = "Canis lupus", Age = 8, Sex = Sex.Male, Diet = DietType.Carnivore, EmployeeId = 3, EnclosureId = 3 }

            );

            // Seeding data for the Ticket table
            modelBuilder.Entity<Ticket>().HasData(
             new Ticket { TicketId = 1, DateOfPurchase = DateTime.Now.AddDays(-2), EventId = 1, VisitorId = 1 },
             new Ticket { TicketId = 2, DateOfPurchase = DateTime.Now.AddDays(-1), EventId = 2, VisitorId = 2 },
             new Ticket { TicketId = 3, DateOfPurchase = DateTime.Now.AddDays(-3), EventId = 1, VisitorId = 3 },
             new Ticket { TicketId = 4, DateOfPurchase = DateTime.Now.AddDays(-4), EventId = 2, VisitorId = 4 },
             new Ticket { TicketId = 5, DateOfPurchase = DateTime.Now.AddDays(-5), EventId = 1, VisitorId = 5 },
             new Ticket { TicketId = 6, DateOfPurchase = DateTime.Now.AddDays(-6), EventId = 2, VisitorId = 6 },
             new Ticket { TicketId = 7, DateOfPurchase = DateTime.Now.AddDays(-7), EventId = 1, VisitorId = 7 },
             new Ticket { TicketId = 8, DateOfPurchase = DateTime.Now.AddDays(-8), EventId = 2, VisitorId = 8 },
             new Ticket { TicketId = 9, DateOfPurchase = DateTime.Now.AddDays(-9), EventId = 1, VisitorId = 9 },
             new Ticket { TicketId = 10, DateOfPurchase = DateTime.Now.AddDays(-10), EventId = 2, VisitorId = 10 },
             new Ticket { TicketId = 11, DateOfPurchase = DateTime.Now.AddDays(-11), EventId = 1, VisitorId = 11 },
             new Ticket { TicketId = 12, DateOfPurchase = DateTime.Now.AddDays(-12), EventId = 2, VisitorId = 12 },
             new Ticket { TicketId = 13, DateOfPurchase = DateTime.Now.AddDays(-13), EventId = 1, VisitorId = 13 },
             new Ticket { TicketId = 14, DateOfPurchase = DateTime.Now.AddDays(-14), EventId = 2, VisitorId = 14 },
             new Ticket { TicketId = 15, DateOfPurchase = DateTime.Now.AddDays(-15), EventId = 1, VisitorId = 15 },
             new Ticket { TicketId = 16, DateOfPurchase = DateTime.Now.AddDays(-16), EventId = 2, VisitorId = 16 },
             new Ticket { TicketId = 17, DateOfPurchase = DateTime.Now.AddDays(-17), EventId = 1, VisitorId = 17 }
 );


            // Seeding data for the AnimalEmployee table (junction table)
            modelBuilder.Entity<AnimalEmployee>().HasData(
      
            new AnimalEmployee { AnimalEmployeeId = 1, AnimalId = 1, EmployeeId = 1 },
            new AnimalEmployee { AnimalEmployeeId = 2, AnimalId = 2, EmployeeId = 2 },
            new AnimalEmployee { AnimalEmployeeId = 3, AnimalId = 3, EmployeeId = 5 },
            new AnimalEmployee { AnimalEmployeeId = 4, AnimalId = 4, EmployeeId = 3 },
            new AnimalEmployee { AnimalEmployeeId = 5, AnimalId = 5, EmployeeId = 4 },
            new AnimalEmployee { AnimalEmployeeId = 6, AnimalId = 6, EmployeeId = 5 },
            new AnimalEmployee { AnimalEmployeeId = 7, AnimalId = 7, EmployeeId = 6 },
            new AnimalEmployee { AnimalEmployeeId = 8, AnimalId = 8, EmployeeId = 3 },
            new AnimalEmployee { AnimalEmployeeId = 9, AnimalId = 9, EmployeeId = 4 },
            new AnimalEmployee { AnimalEmployeeId = 10, AnimalId = 10, EmployeeId = 5 },
            new AnimalEmployee { AnimalEmployeeId = 11, AnimalId = 11, EmployeeId = 6 },
            new AnimalEmployee { AnimalEmployeeId = 12, AnimalId = 12, EmployeeId = 3 },
            new AnimalEmployee { AnimalEmployeeId = 13, AnimalId = 13, EmployeeId = 4 },
            new AnimalEmployee { AnimalEmployeeId = 14, AnimalId = 14, EmployeeId = 5 },
            new AnimalEmployee { AnimalEmployeeId = 15, AnimalId = 15, EmployeeId = 6 },
            new AnimalEmployee { AnimalEmployeeId = 16, AnimalId = 16, EmployeeId = 3 }


            );

            // Seeding data for the VisitorAttendance table (junction table)
            modelBuilder.Entity<VisitorEventAttendance>().HasData(
                new VisitorEventAttendance { VisitorEventAttendanceId=1, VisitorId = 1, EventId = 1 },
              new VisitorEventAttendance { VisitorEventAttendanceId=2, VisitorId = 2, EventId = 2 },
               new VisitorEventAttendance { VisitorEventAttendanceId = 3, VisitorId = 3, EventId = 3 },
                new VisitorEventAttendance { VisitorEventAttendanceId = 4, VisitorId = 4, EventId = 4 },
                new VisitorEventAttendance { VisitorEventAttendanceId = 5, VisitorId = 5, EventId = 5 },
                new VisitorEventAttendance { VisitorEventAttendanceId = 6, VisitorId = 6, EventId = 1 },
                new VisitorEventAttendance { VisitorEventAttendanceId = 7, VisitorId = 7, EventId = 2 },
                new VisitorEventAttendance { VisitorEventAttendanceId = 8, VisitorId = 8, EventId = 3 },
                new VisitorEventAttendance { VisitorEventAttendanceId = 9, VisitorId = 9, EventId = 4 },
                new VisitorEventAttendance { VisitorEventAttendanceId = 10, VisitorId = 10, EventId = 5 },
                new VisitorEventAttendance { VisitorEventAttendanceId = 11, VisitorId = 11, EventId = 3 },
                new VisitorEventAttendance { VisitorEventAttendanceId = 12, VisitorId = 12, EventId = 4 },
                new VisitorEventAttendance { VisitorEventAttendanceId = 13, VisitorId = 13, EventId = 5 },
                new VisitorEventAttendance { VisitorEventAttendanceId = 14, VisitorId = 14, EventId = 1 },
                new VisitorEventAttendance { VisitorEventAttendanceId = 15, VisitorId = 15, EventId = 2 },
                new VisitorEventAttendance { VisitorEventAttendanceId = 16, VisitorId = 16, EventId = 3 },
                new VisitorEventAttendance { VisitorEventAttendanceId = 17, VisitorId = 17, EventId = 4 }

            );


            // Seeding data for the VisitorLog table
            modelBuilder.Entity<VisitorLog>().HasData(
    new VisitorLog { VisitorLogId = 1, VisitorId = 1, DateVisited = DateTime.Now.AddDays(-2), Comments = "Enjoyed the zoo!" },
    new VisitorLog { VisitorLogId = 2, VisitorId = 2, DateVisited = DateTime.Now.AddDays(-1), Comments = "Great experience!" },
    new VisitorLog { VisitorLogId = 3, VisitorId = 3, DateVisited = DateTime.Now.AddDays(-3), Comments = "Had a wonderful time with family!" },
    new VisitorLog { VisitorLogId = 4, VisitorId = 4, DateVisited = DateTime.Now.AddDays(-4), Comments = "Educational and fun!" },
    new VisitorLog { VisitorLogId = 5, VisitorId = 5, DateVisited = DateTime.Now.AddDays(-5), Comments = "Loved the animal exhibits!" },
    new VisitorLog { VisitorLogId = 6, VisitorId = 6, DateVisited = DateTime.Now.AddDays(-6), Comments = "Amazing zoo experience!" },
    new VisitorLog { VisitorLogId = 7, VisitorId = 7, DateVisited = DateTime.Now.AddDays(-7), Comments = "Fantastic day out!" },
    new VisitorLog { VisitorLogId = 8, VisitorId = 8, DateVisited = DateTime.Now.AddDays(-8), Comments = "Will visit again soon!" },
    new VisitorLog { VisitorLogId = 9, VisitorId = 9, DateVisited = DateTime.Now.AddDays(-9), Comments = "Kids loved the animals!" },
    new VisitorLog { VisitorLogId = 10, VisitorId = 10, DateVisited = DateTime.Now.AddDays(-10), Comments = "Highly recommended!" }
);

        }


    }

}
