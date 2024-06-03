using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class AgeAddedNewUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { 67, "b6cf821e-e9b8-4ad0-9d08-34017027ad87", "AQAAAAIAAYagAAAAEOMSx5Lx32/Rluz0gYFR1gpr13vdJdT5z/jEY8vstUXHSPWZslwU2oBpDlnCCczZlA==", "05064542-d6a8-4a5b-9d56-7d5b1ff877d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { 50, "eea20c2e-82d4-46db-9a56-b273b6193083", "AQAAAAIAAYagAAAAEHQp3aVNSU2svjboeId97z9HF7dgqRgOiu9HnLbNvYgCvRO3Dq4nunx0z/sNz6O7lA==", "1848f713-34f0-4e18-97f1-f03af2832231" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { 34, "f2777944-cf34-4c08-a903-411cdf8f713c", "AQAAAAIAAYagAAAAEOBPGAEqr/9tNuPo2t9+FRGq2lS0UqF/g3uktMjcx3mmlkD+MfPyDiY/mw6tZZr6bQ==", "c037bb9f-47c6-416b-b8b2-f78a8e8ea75a" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 2, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 5, 12, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 7, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 5, 17, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(582));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 4, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 5, 22, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 6, 11, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 6, 18, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 6, 26, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 1, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 11, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 30, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 31, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 29, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 28, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 27, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 26, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 25, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 24, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 23, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 22, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 21, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 20, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 19, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 18, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 17, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 16, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 15, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 5, 30, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 5, 31, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 5, 29, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 5, 28, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 5, 27, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 5, 26, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 5, 25, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 5, 24, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 5, 23, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 5, 22, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(934));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { 0, "c9e2787f-a2aa-4ec9-8365-56e51f53f3c1", "AQAAAAIAAYagAAAAEKd0P3xpiXactNtE2ZX3AQ20jDkCWM+4Oa42Jr5lPyMjazFMoOx9PnC9nbnt4+KLEQ==", "cc1ae232-226e-4db1-a34c-669171640a75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { 0, "95e76fc5-a94d-4637-8d25-48e636070e28", "AQAAAAIAAYagAAAAEOANka9yTEfSrE0ESZVou7ZN6+Cspv1HJJzQM+2iWgIUXlYjJUgfMsvc2kgCNKO08w==", "166c3693-f8de-4b67-9e7c-27b47e5e3127" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { 0, "ff7dea1b-6d4d-41a4-b778-bb587f9b5799", "AQAAAAIAAYagAAAAEJrPQlq4jtLmhPwKBckgKw87w4bgcgNyG7YenOoyJMmxjgrlXaRbwPhBSl3c4qcLqQ==", "b2c0ade0-2e62-4c40-b387-c2dbb15587f1" });

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
        }
    }
}
