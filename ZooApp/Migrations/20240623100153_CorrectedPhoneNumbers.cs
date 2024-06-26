using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class CorrectedPhoneNumbers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "078ff8ed-a0ea-480b-adb4-1dd840015d8d", "AQAAAAIAAYagAAAAEPb51jUT39ue1031cUEW58A8aN7g9i1Z5Vt9lG12tD9qs4RwQ8A4/lwpM4nVMCk9OQ==", "a8c07529-4515-4b14-8e1b-e0bdf4d29aff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2dac9825-4936-464a-9cc8-b14cc9633eb1", "AQAAAAIAAYagAAAAEEPSFd9ILqz17CLaXaq5t6Kfy4Y0cUAAoBicoHrFHLA50FM8ps5tAxbx52csVZpepg==", "95cf02c4-344d-4b43-8500-0e663c9d673e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d6d5106-9e9d-423a-8d23-25ac82a1c278", "AQAAAAIAAYagAAAAEEpU7Lzy815HQno5cA1FGe12hg8Fm44OhojCS5KqT7l6MB3StqZ+/FXYYLWIguaATA==", "225aa0a8-06b0-4648-b04e-092844133844" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 24, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 6, 3, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 29, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 6, 8, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 26, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 6, 13, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 9, 20, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 11, 2, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 9, 21, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 1, 19, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 9, 29, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 21, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 22, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 20, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 19, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6057));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 18, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 17, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 16, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 15, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 14, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 13, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 12, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 11, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 10, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 9, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 8, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 7, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 6, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 1,
                column: "Phone",
                value: "+64-123-4567");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 2,
                column: "Phone",
                value: "+64-987-6543");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 3,
                column: "Phone",
                value: "+64-111-1111");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 4,
                column: "Phone",
                value: "+64-222-2222");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 5,
                column: "Phone",
                value: "+64-333-3333");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 6,
                column: "Phone",
                value: "+64-444-4444");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 7,
                column: "Phone",
                value: "+64-555-5555");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 8,
                column: "Phone",
                value: "+64-666-6666");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 9,
                column: "Phone",
                value: "+64-777-7777");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 10,
                column: "Phone",
                value: "+64-888-8888");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 11,
                column: "Phone",
                value: "+64-999-9999");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 12,
                column: "Phone",
                value: "+64-101-1010");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 13,
                column: "Phone",
                value: "+64-202-2020");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 14,
                column: "Phone",
                value: "+64-303-3030");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 15,
                column: "Phone",
                value: "+64-404-4040");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 16,
                column: "Phone",
                value: "+64-505-5050");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 17,
                column: "Phone",
                value: "+64-606-6060");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 18,
                column: "Phone",
                value: "+64-707-7070");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 19,
                column: "Phone",
                value: "+64-808-8080");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 20,
                column: "Phone",
                value: "+64-909-9090");

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 18, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 20, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 22, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 21, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 19, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6337));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f741f43d-fa15-443e-b63f-8395dfba3c83", "AQAAAAIAAYagAAAAEG7MuBaYu6O6ek9cvwjjIdzun2AaTyVOPYmWRXv924+8m27R37v3VVSq+d8QMRlmUA==", "346185fc-5c8f-4ac1-a20b-ff6c742d31f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae341b53-8b3b-4975-9c76-27b95df062b3", "AQAAAAIAAYagAAAAEAHfJHRWFGaLyYXypOu1AV9xKggV/lw2bqos+6z8h6clyyQwXrDZlMPciE6sfR6kug==", "9428628e-b66a-446d-a48d-46f3308fe8f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40921ecf-ceb9-4a32-851a-3c0c7791426b", "AQAAAAIAAYagAAAAEFJHvUWbyBk9rK2ESr2yvtxpkP/+6rNSjwLv8kGFi8NGs0GkLM9NNvje5SSXUCDqHw==", "c2dc445d-b0da-4312-88af-140adf7bbd35" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 24, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 6, 3, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 29, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 6, 8, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 26, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 6, 13, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 9, 20, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 11, 2, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 9, 21, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 1, 19, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 9, 29, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 21, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 22, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 20, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 19, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 18, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 17, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 16, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 15, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 14, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 13, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 12, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 11, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 10, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 9, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 8, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 7, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 6, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 1,
                column: "Phone",
                value: "123-456-7890");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 2,
                column: "Phone",
                value: "987-654-3210");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 3,
                column: "Phone",
                value: "111-111-1111");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 4,
                column: "Phone",
                value: "222-222-2222");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 5,
                column: "Phone",
                value: "333-333-3333");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 6,
                column: "Phone",
                value: "444-444-4444");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 7,
                column: "Phone",
                value: "555-555-5555");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 8,
                column: "Phone",
                value: "666-666-6666");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 9,
                column: "Phone",
                value: "777-777-7777");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 10,
                column: "Phone",
                value: "888-888-8888");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 11,
                column: "Phone",
                value: "999-999-9999");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 12,
                column: "Phone",
                value: "101-101-1010");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 13,
                column: "Phone",
                value: "202-202-2020");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 14,
                column: "Phone",
                value: "303-303-3030");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 15,
                column: "Phone",
                value: "404-404-4040");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 16,
                column: "Phone",
                value: "505-505-5050");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 17,
                column: "Phone",
                value: "606-606-6060");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 18,
                column: "Phone",
                value: "707-707-7070");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 19,
                column: "Phone",
                value: "808-808-8080");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 20,
                column: "Phone",
                value: "909-909-9090");

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 18, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 20, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 22, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 21, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 19, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4800));
        }
    }
}
