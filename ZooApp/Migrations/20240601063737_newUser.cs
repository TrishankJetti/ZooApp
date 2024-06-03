using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class newUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9e2787f-a2aa-4ec9-8365-56e51f53f3c1", "AQAAAAIAAYagAAAAEKd0P3xpiXactNtE2ZX3AQ20jDkCWM+4Oa42Jr5lPyMjazFMoOx9PnC9nbnt4+KLEQ==", "cc1ae232-226e-4db1-a34c-669171640a75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95e76fc5-a94d-4637-8d25-48e636070e28", "AQAAAAIAAYagAAAAEOANka9yTEfSrE0ESZVou7ZN6+Cspv1HJJzQM+2iWgIUXlYjJUgfMsvc2kgCNKO08w==", "166c3693-f8de-4b67-9e7c-27b47e5e3127" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3", 0, 0, "ff7dea1b-6d4d-41a4-b778-bb587f9b5799", "employee2@example.com", true, "Christopher", "Lee", false, null, "EMPLOYEE2@EXAMPLE.COM", "employee2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJrPQlq4jtLmhPwKBckgKw87w4bgcgNyG7YenOoyJMmxjgrlXaRbwPhBSl3c4qcLqQ==", null, false, "b2c0ade0-2e62-4c40-b387-c2dbb15587f1", false, "employee2@example.com" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 2, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 5, 12, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 7, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 5, 17, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 4, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 5, 22, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 6, 11, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 6, 18, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 6, 26, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 1, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 11, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 30, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 31, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 29, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 28, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 27, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 26, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 25, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 24, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 23, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 22, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 21, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 20, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 19, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 18, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 17, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 16, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 15, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 5, 30, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 5, 31, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 5, 29, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 5, 28, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 5, 27, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 5, 26, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 5, 25, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 5, 24, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 5, 23, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 5, 22, 18, 37, 37, 301, DateTimeKind.Local).AddTicks(6868));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2", "3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65576027-7cc3-4e3b-a56d-064ca3f699b5", "AQAAAAIAAYagAAAAECANGAZw4vXkSccRltMgU+EPkgCpZjdWmpYq+W3kRzmkZVT2kN9+6LYjRChBtpDWvg==", "ee5a4999-ad23-41e7-87e3-f67b23ce1806" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30abb827-239f-46a1-961f-0391e865f3c1", "AQAAAAIAAYagAAAAEFD9IGwDWyvowTffSSdXbgB4Jlh75CzY8TS8Oirr22+R35T6bKpGg0MNgsyDX3++Rw==", "19440d1c-ca44-47e4-88bb-1e2d857d3fe2" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 2, 17, 59, 16, 640, DateTimeKind.Local).AddTicks(1394));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 5, 12, 17, 59, 16, 640, DateTimeKind.Local).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 7, 17, 59, 16, 640, DateTimeKind.Local).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 5, 17, 17, 59, 16, 640, DateTimeKind.Local).AddTicks(1586));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 4, 17, 59, 16, 640, DateTimeKind.Local).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 5, 22, 17, 59, 16, 640, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 6, 11, 17, 59, 16, 622, DateTimeKind.Local).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 6, 18, 17, 59, 16, 622, DateTimeKind.Local).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 6, 26, 17, 59, 16, 622, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 1, 17, 59, 16, 622, DateTimeKind.Local).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 11, 17, 59, 16, 622, DateTimeKind.Local).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 30, 17, 59, 16, 640, DateTimeKind.Local).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 31, 17, 59, 16, 640, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 29, 17, 59, 16, 640, DateTimeKind.Local).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 28, 17, 59, 16, 640, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 27, 17, 59, 16, 640, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 26, 17, 59, 16, 640, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 25, 17, 59, 16, 640, DateTimeKind.Local).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 24, 17, 59, 16, 640, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 23, 17, 59, 16, 640, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 22, 17, 59, 16, 640, DateTimeKind.Local).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 21, 17, 59, 16, 640, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 20, 17, 59, 16, 640, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 19, 17, 59, 16, 640, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 18, 17, 59, 16, 640, DateTimeKind.Local).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 17, 17, 59, 16, 640, DateTimeKind.Local).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 16, 17, 59, 16, 640, DateTimeKind.Local).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 15, 17, 59, 16, 640, DateTimeKind.Local).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 5, 30, 17, 59, 16, 640, DateTimeKind.Local).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 5, 31, 17, 59, 16, 640, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 5, 29, 17, 59, 16, 640, DateTimeKind.Local).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 5, 28, 17, 59, 16, 640, DateTimeKind.Local).AddTicks(5283));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 5, 27, 17, 59, 16, 640, DateTimeKind.Local).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 5, 26, 17, 59, 16, 640, DateTimeKind.Local).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 5, 25, 17, 59, 16, 640, DateTimeKind.Local).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 5, 24, 17, 59, 16, 640, DateTimeKind.Local).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 5, 23, 17, 59, 16, 640, DateTimeKind.Local).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 5, 22, 17, 59, 16, 640, DateTimeKind.Local).AddTicks(5323));
        }
    }
}
