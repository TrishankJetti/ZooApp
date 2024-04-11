using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class dataadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Comments",
                table: "VisitorLog",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Event",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 3, 12, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 3, 22, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "Enclosure",
                keyColumn: "EnclosureId",
                keyValue: 1,
                column: "Name",
                value: "Savannah Enclosure");

            migrationBuilder.UpdateData(
                table: "Enclosure",
                keyColumn: "EnclosureId",
                keyValue: 2,
                column: "Name",
                value: "Jungle Enclosure");

            migrationBuilder.InsertData(
                table: "Enclosure",
                columns: new[] { "EnclosureId", "Capacity", "Habitat", "Name" },
                values: new object[,]
                {
                    { 3, 7, "Forest", "Forest Enclosure" },
                    { 4, 6, "River", "River Enclosure" },
                    { 5, 8, "Aviary", "Aviary Enclosure" },
                    { 6, 5, "Arctic", "Arctic Enclosure" }
                });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 21, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 4, 28, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2291));

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "EventId", "Date", "Description", "Name", "TicketPrice" },
                values: new object[,]
                {
                    { 3, new DateTime(2024, 5, 6, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2296), "Experience the zoo after dark with special activities and tours", "Night at the Zoo", 30m },
                    { 4, new DateTime(2024, 5, 11, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2298), "Guided tour focusing on observing various bird species in the zoo", "Bird Watching Tour", 15m },
                    { 5, new DateTime(2024, 5, 21, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2301), "Learn about animal diets and behavior during feeding time", "Animal Feeding Demonstration", 20m }
                });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 9, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2676));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 10, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2679));

            migrationBuilder.InsertData(
                table: "Visitor",
                columns: new[] { "VisitorId", "Address", "Email", "Name", "Phone" },
                values: new object[,]
                {
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

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 4, 9, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 4, 10, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "EnclosureId", "HireDate", "Name", "Phone", "Role", "Salary" },
                values: new object[,]
                {
                    { 3, 3, new DateTime(2024, 3, 17, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2457), "Michael Johnson", "111-222-3333", 0, 55000m },
                    { 4, 4, new DateTime(2024, 3, 27, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2460), "Emily Wilson", "444-555-6666", 1, 72000m },
                    { 5, 5, new DateTime(2024, 3, 14, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2463), "Christopher Lee", "777-888-9999", 0, 52000m },
                    { 6, 6, new DateTime(2024, 4, 1, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2466), "Jessica Brown", "999-888-7777", 1, 73000m }
                });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "TicketId", "DateOfPurchase", "EventId", "VisitorId" },
                values: new object[,]
                {
                    { 3, new DateTime(2024, 4, 8, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2681), 1, 3 },
                    { 4, new DateTime(2024, 4, 7, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2684), 2, 4 },
                    { 5, new DateTime(2024, 4, 6, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2686), 1, 5 },
                    { 6, new DateTime(2024, 4, 5, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2688), 2, 6 },
                    { 7, new DateTime(2024, 4, 4, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2690), 1, 7 },
                    { 8, new DateTime(2024, 4, 3, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2692), 2, 8 },
                    { 9, new DateTime(2024, 4, 2, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2695), 1, 9 },
                    { 10, new DateTime(2024, 4, 1, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2698), 2, 10 },
                    { 11, new DateTime(2024, 3, 31, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2700), 1, 11 },
                    { 12, new DateTime(2024, 3, 30, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2702), 2, 12 },
                    { 13, new DateTime(2024, 3, 29, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2705), 1, 13 },
                    { 14, new DateTime(2024, 3, 28, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2707), 2, 14 },
                    { 15, new DateTime(2024, 3, 27, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2709), 1, 15 },
                    { 16, new DateTime(2024, 3, 26, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2711), 2, 16 },
                    { 17, new DateTime(2024, 3, 25, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2713), 1, 17 }
                });

            migrationBuilder.InsertData(
                table: "VisitorEventAttendance",
                columns: new[] { "VisitorEventAttendanceId", "EventId", "VisitorId" },
                values: new object[,]
                {
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
                    { 3, "Had a wonderful time with family!", new DateTime(2024, 4, 8, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2834), 3 },
                    { 4, "Educational and fun!", new DateTime(2024, 4, 7, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2836), 4 },
                    { 5, "Loved the animal exhibits!", new DateTime(2024, 4, 6, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2839), 5 },
                    { 6, "Amazing zoo experience!", new DateTime(2024, 4, 5, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2841), 6 },
                    { 7, "Fantastic day out!", new DateTime(2024, 4, 4, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2843), 7 },
                    { 8, "Will visit again soon!", new DateTime(2024, 4, 3, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2846), 8 },
                    { 9, "Kids loved the animals!", new DateTime(2024, 4, 2, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2848), 9 },
                    { 10, "Highly recommended!", new DateTime(2024, 4, 1, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2851), 10 }
                });

            migrationBuilder.InsertData(
                table: "Animal",
                columns: new[] { "AnimalId", "Age", "Diet", "EmployeeId", "EnclosureId", "Name", "Sex", "Species" },
                values: new object[,]
                {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnimalEmployee",
                keyColumn: "AnimalEmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AnimalEmployee",
                keyColumn: "AnimalEmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AnimalEmployee",
                keyColumn: "AnimalEmployeeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AnimalEmployee",
                keyColumn: "AnimalEmployeeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AnimalEmployee",
                keyColumn: "AnimalEmployeeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AnimalEmployee",
                keyColumn: "AnimalEmployeeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AnimalEmployee",
                keyColumn: "AnimalEmployeeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AnimalEmployee",
                keyColumn: "AnimalEmployeeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AnimalEmployee",
                keyColumn: "AnimalEmployeeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AnimalEmployee",
                keyColumn: "AnimalEmployeeId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AnimalEmployee",
                keyColumn: "AnimalEmployeeId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AnimalEmployee",
                keyColumn: "AnimalEmployeeId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AnimalEmployee",
                keyColumn: "AnimalEmployeeId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AnimalEmployee",
                keyColumn: "AnimalEmployeeId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "VisitorEventAttendance",
                keyColumn: "VisitorEventAttendanceId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VisitorEventAttendance",
                keyColumn: "VisitorEventAttendanceId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VisitorEventAttendance",
                keyColumn: "VisitorEventAttendanceId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VisitorEventAttendance",
                keyColumn: "VisitorEventAttendanceId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "VisitorEventAttendance",
                keyColumn: "VisitorEventAttendanceId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "VisitorEventAttendance",
                keyColumn: "VisitorEventAttendanceId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "VisitorEventAttendance",
                keyColumn: "VisitorEventAttendanceId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "VisitorEventAttendance",
                keyColumn: "VisitorEventAttendanceId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "VisitorEventAttendance",
                keyColumn: "VisitorEventAttendanceId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "VisitorEventAttendance",
                keyColumn: "VisitorEventAttendanceId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "VisitorEventAttendance",
                keyColumn: "VisitorEventAttendanceId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "VisitorEventAttendance",
                keyColumn: "VisitorEventAttendanceId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "VisitorEventAttendance",
                keyColumn: "VisitorEventAttendanceId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "VisitorEventAttendance",
                keyColumn: "VisitorEventAttendanceId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "VisitorEventAttendance",
                keyColumn: "VisitorEventAttendanceId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Enclosure",
                keyColumn: "EnclosureId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enclosure",
                keyColumn: "EnclosureId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enclosure",
                keyColumn: "EnclosureId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enclosure",
                keyColumn: "EnclosureId",
                keyValue: 6);

            migrationBuilder.AlterColumn<string>(
                name: "Comments",
                table: "VisitorLog",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Event",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 3, 8, 8, 41, 58, 729, DateTimeKind.Local).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 3, 18, 8, 41, 58, 729, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "Enclosure",
                keyColumn: "EnclosureId",
                keyValue: 1,
                column: "Name",
                value: "Lion Enclosure");

            migrationBuilder.UpdateData(
                table: "Enclosure",
                keyColumn: "EnclosureId",
                keyValue: 2,
                column: "Name",
                value: "Elephant Enclosure");

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 17, 8, 41, 58, 729, DateTimeKind.Local).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 4, 24, 8, 41, 58, 729, DateTimeKind.Local).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 5, 8, 41, 58, 729, DateTimeKind.Local).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 6, 8, 41, 58, 729, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 4, 5, 8, 41, 58, 729, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 4, 6, 8, 41, 58, 729, DateTimeKind.Local).AddTicks(1068));
        }
    }
}
