using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class IMageUpload : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enclosure",
                columns: table => new
                {
                    EnclosureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Habitat = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enclosure", x => x.EnclosureId);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    TicketPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageFileName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.EventId);
                });

            migrationBuilder.CreateTable(
                name: "Visitor",
                columns: table => new
                {
                    VisitorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitor", x => x.VisitorId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EnclosureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employee_Enclosure_EnclosureId",
                        column: x => x.EnclosureId,
                        principalTable: "Enclosure",
                        principalColumn: "EnclosureId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    TicketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitorId = table.Column<int>(type: "int", nullable: false),
                    DateOfPurchase = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.TicketId);
                    table.ForeignKey(
                        name: "FK_Ticket_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_Visitor_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "Visitor",
                        principalColumn: "VisitorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VisitorEventAttendance",
                columns: table => new
                {
                    VisitorEventAttendanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitorId = table.Column<int>(type: "int", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitorEventAttendance", x => x.VisitorEventAttendanceId);
                    table.ForeignKey(
                        name: "FK_VisitorEventAttendance_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VisitorEventAttendance_Visitor_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "Visitor",
                        principalColumn: "VisitorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VisitorLog",
                columns: table => new
                {
                    VisitorLogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitorId = table.Column<int>(type: "int", nullable: false),
                    DateVisited = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitorLog", x => x.VisitorLogId);
                    table.ForeignKey(
                        name: "FK_VisitorLog_Visitor_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "Visitor",
                        principalColumn: "VisitorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Animal",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Species = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Sex = table.Column<int>(type: "int", nullable: false),
                    Diet = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EnclosureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animal", x => x.AnimalId);
                    table.ForeignKey(
                        name: "FK_Animal_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Animal_Enclosure_EnclosureId",
                        column: x => x.EnclosureId,
                        principalTable: "Enclosure",
                        principalColumn: "EnclosureId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "AnimalEmployee",
                columns: table => new
                {
                    AnimalEmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalEmployee", x => x.AnimalEmployeeId);
                    table.ForeignKey(
                        name: "FK_AnimalEmployee_Animal_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animal",
                        principalColumn: "AnimalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalEmployee_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Enclosure",
                columns: new[] { "EnclosureId", "Capacity", "Habitat", "Name" },
                values: new object[,]
                {
                    { 1, 5, "Savannah", "Savannah Enclosure" },
                    { 2, 10, "Jungle", "Jungle Enclosure" },
                    { 3, 7, "Forest", "Forest Enclosure" },
                    { 4, 6, "River", "River Enclosure" },
                    { 5, 8, "Aviary", "Aviary Enclosure" },
                    { 6, 5, "Arctic", "Arctic Enclosure" }
                });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "EventId", "Date", "Description", "ImageFileName", "Name", "TicketPrice" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 9, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7041), "Guided safari tour through the zoo", "HI", "Zoo Safari", 25m },
                    { 2, new DateTime(2024, 6, 16, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7089), "Educational talk on wildlife conservation", "HI", "Wildlife Conservation Talk", 10m },
                    { 3, new DateTime(2024, 6, 24, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7095), "Experience the zoo after dark with special activities and tours", "HI", "Night at the Zoo", 30m },
                    { 4, new DateTime(2024, 6, 29, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7098), "Guided tour focusing on observing various bird species in the zoo", "HI", "Bird Watching Tour", 15m },
                    { 5, new DateTime(2024, 7, 9, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7100), "Learn about animal diets and behavior during feeding time", "HI", "Animal Feeding Demonstration", 20m }
                });

            migrationBuilder.InsertData(
                table: "Visitor",
                columns: new[] { "VisitorId", "Address", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "123 Main St", "alice@example.com", "Alice", "123-456-7890" },
                    { 2, "456 Elm St", "bob@example.com", "Bob", "987-654-3210" },
                    { 3, "789 Oak St", "eva@example.com", "Eva Martinez", "111-111-1111" },
                    { 4, "101 Pine St", "david@example.com", "David Brown", "222-222-2222" },
                    { 5, "456 Maple Ave", "sophia@example.com", "Sophia Garcia", "333-333-3333" },
                    { 6, "789 Elm St", "liam@example.com", "Liam Rodriguez", "444-444-4444" },
                    { 7, "123 Oak St", "olivia@example.com", "Olivia Hernandez", "555-555-5555" },
                    { 8, "789 Pine Ave", "lucas@example.com", "Lucas Martinez", "666-666-6666" },
                    { 9, "101 Maple St", "isabella@example.com", "Isabella Nguyen", "777-777-7777" },
                    { 10, "456 Oak Ave", "mia@example.com", "Mia Kim", "888-888-8888" },
                    { 11, "123 Maple Ave", "james@example.com", "James Smith", "999-999-9999" },
                    { 12, "789 Pine St", "charlotte@example.com", "Charlotte Johnson", "101-101-1010" },
                    { 13, "456 Elm St", "william@example.com", "William Brown", "202-202-2020" },
                    { 14, "123 Maple Ave", "amelia@example.com", "Amelia Davis", "303-303-3030" },
                    { 15, "789 Elm Ave", "benjamin@example.com", "Benjamin Wilson", "404-404-4040" },
                    { 16, "101 Oak St", "emma@example.com", "Emma Rodriguez", "505-505-5050" },
                    { 17, "456 Pine Ave", "alexander@example.com", "Alexander Garcia", "606-606-6060" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "EnclosureId", "HireDate", "Name", "Phone", "Role", "Salary" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 4, 30, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7210), "John Doe", "123-456-7890", 0, 50000m },
                    { 2, 2, new DateTime(2024, 5, 10, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7213), "Jane Smith", "987-654-3210", 1, 70000m },
                    { 3, 3, new DateTime(2024, 5, 5, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7216), "Michael Johnson", "111-222-3333", 0, 55000m },
                    { 4, 4, new DateTime(2024, 5, 15, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7218), "Emily Wilson", "444-555-6666", 1, 72000m },
                    { 5, 5, new DateTime(2024, 5, 2, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7220), "Christopher Lee", "777-888-9999", 0, 52000m },
                    { 6, 6, new DateTime(2024, 5, 20, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7222), "Jessica Brown", "999-888-7777", 1, 73000m }
                });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "TicketId", "DateOfPurchase", "EventId", "VisitorId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 28, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7369), 1, 1 },
                    { 2, new DateTime(2024, 5, 29, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7371), 2, 2 },
                    { 3, new DateTime(2024, 5, 27, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7373), 1, 3 },
                    { 4, new DateTime(2024, 5, 26, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7375), 2, 4 },
                    { 5, new DateTime(2024, 5, 25, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7376), 1, 5 },
                    { 6, new DateTime(2024, 5, 24, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7378), 2, 6 },
                    { 7, new DateTime(2024, 5, 23, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7380), 1, 7 },
                    { 8, new DateTime(2024, 5, 22, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7381), 2, 8 },
                    { 9, new DateTime(2024, 5, 21, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7383), 1, 9 },
                    { 10, new DateTime(2024, 5, 20, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7384), 2, 10 },
                    { 11, new DateTime(2024, 5, 19, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7386), 1, 11 },
                    { 12, new DateTime(2024, 5, 18, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7387), 2, 12 },
                    { 13, new DateTime(2024, 5, 17, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7389), 1, 13 },
                    { 14, new DateTime(2024, 5, 16, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7390), 2, 14 },
                    { 15, new DateTime(2024, 5, 15, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7392), 1, 15 },
                    { 16, new DateTime(2024, 5, 14, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7393), 2, 16 },
                    { 17, new DateTime(2024, 5, 13, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7395), 1, 17 }
                });

            migrationBuilder.InsertData(
                table: "VisitorEventAttendance",
                columns: new[] { "VisitorEventAttendanceId", "EventId", "VisitorId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 4, 4 },
                    { 5, 5, 5 },
                    { 6, 1, 6 },
                    { 7, 2, 7 },
                    { 8, 3, 8 },
                    { 9, 4, 9 },
                    { 10, 5, 10 },
                    { 11, 3, 11 },
                    { 12, 4, 12 },
                    { 13, 5, 13 },
                    { 14, 1, 14 },
                    { 15, 2, 15 },
                    { 16, 3, 16 },
                    { 17, 4, 17 }
                });

            migrationBuilder.InsertData(
                table: "VisitorLog",
                columns: new[] { "VisitorLogId", "Comments", "DateVisited", "VisitorId" },
                values: new object[,]
                {
                    { 1, "Enjoyed the zoo!", new DateTime(2024, 5, 28, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7478), 1 },
                    { 2, "Great experience!", new DateTime(2024, 5, 29, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7480), 2 },
                    { 3, "Had a wonderful time with family!", new DateTime(2024, 5, 27, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7482), 3 },
                    { 4, "Educational and fun!", new DateTime(2024, 5, 26, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7484), 4 },
                    { 5, "Loved the animal exhibits!", new DateTime(2024, 5, 25, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7485), 5 },
                    { 6, "Amazing zoo experience!", new DateTime(2024, 5, 24, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7487), 6 },
                    { 7, "Fantastic day out!", new DateTime(2024, 5, 23, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7488), 7 },
                    { 8, "Will visit again soon!", new DateTime(2024, 5, 22, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7490), 8 },
                    { 9, "Kids loved the animals!", new DateTime(2024, 5, 21, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7492), 9 },
                    { 10, "Highly recommended!", new DateTime(2024, 5, 20, 6, 6, 43, 878, DateTimeKind.Local).AddTicks(7493), 10 }
                });

            migrationBuilder.InsertData(
                table: "Animal",
                columns: new[] { "AnimalId", "Age", "Diet", "EmployeeId", "EnclosureId", "Name", "Sex", "Species" },
                values: new object[,]
                {
                    { 1, 5, 0, 1, 1, "Lion", 0, "Panthera leo" },
                    { 2, 10, 2, 2, 2, "Elephant", 1, "Loxodonta africana" },
                    { 3, 3, 1, 5, 5, "Parrot", 1, "Psittaciformes" },
                    { 4, 6, 0, 3, 1, "Tiger", 1, "Panthera tigris" },
                    { 5, 12, 1, 4, 2, "Gorilla", 0, "Gorilla gorilla" },
                    { 6, 5, 3, 5, 6, "Penguin", 0, "Aptenodytes forsteri" },
                    { 7, 4, 2, 6, 3, "Kangaroo", 1, "Macropus" },
                    { 8, 10, 0, 3, 4, "Crocodile", 0, "Crocodylus" },
                    { 9, 7, 2, 4, 1, "Zebra", 1, "Equus zebra" },
                    { 10, 9, 2, 5, 2, "Panda", 0, "Ailuropoda melanoleuca" },
                    { 11, 8, 2, 6, 3, "Giraffe", 1, "Giraffa" },
                    { 12, 4, 1, 3, 4, "Lemur", 0, "Lemur" },
                    { 13, 11, 0, 4, 6, "Polar Bear", 1, "Ursus maritimus" },
                    { 14, 6, 2, 5, 2, "Hippo", 0, "Hippopotamus" },
                    { 15, 5, 2, 6, 4, "Sloth", 1, "Bradypus" },
                    { 16, 8, 0, 3, 3, "Wolf", 0, "Canis lupus" }
                });

            migrationBuilder.InsertData(
                table: "AnimalEmployee",
                columns: new[] { "AnimalEmployeeId", "AnimalId", "EmployeeId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 5 },
                    { 4, 4, 3 },
                    { 5, 5, 4 },
                    { 6, 6, 5 },
                    { 7, 7, 6 },
                    { 8, 8, 3 },
                    { 9, 9, 4 },
                    { 10, 10, 5 },
                    { 11, 11, 6 },
                    { 12, 12, 3 },
                    { 13, 13, 4 },
                    { 14, 14, 5 },
                    { 15, 15, 6 },
                    { 16, 16, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animal_EmployeeId",
                table: "Animal",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Animal_EnclosureId",
                table: "Animal",
                column: "EnclosureId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalEmployee_AnimalId",
                table: "AnimalEmployee",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalEmployee_EmployeeId",
                table: "AnimalEmployee",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_EnclosureId",
                table: "Employee",
                column: "EnclosureId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_EventId",
                table: "Ticket",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_VisitorId",
                table: "Ticket",
                column: "VisitorId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorEventAttendance_EventId",
                table: "VisitorEventAttendance",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorEventAttendance_VisitorId",
                table: "VisitorEventAttendance",
                column: "VisitorId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorLog_VisitorId",
                table: "VisitorLog",
                column: "VisitorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalEmployee");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "VisitorEventAttendance");

            migrationBuilder.DropTable(
                name: "VisitorLog");

            migrationBuilder.DropTable(
                name: "Animal");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Visitor");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Enclosure");
        }
    }
}
