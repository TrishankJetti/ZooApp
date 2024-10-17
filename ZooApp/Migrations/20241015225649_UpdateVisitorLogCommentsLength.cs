using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateVisitorLogCommentsLength : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2228865e-3d42-4d15-9391-9527aefc2a64", "AQAAAAIAAYagAAAAEDea4iFJkeJGB0vD5O2GSQq5rcEbPkDSeLj3vU55MIVaXhCZYsQG8phEar9DGjyDVw==", "29243150-8055-4ac4-9b74-db971ddc806c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "283dbd73-142a-4c6d-9d7c-8600c6bd7f9e", "AQAAAAIAAYagAAAAEK0dGwMw9XpeutfT/mhK9dFCxL3xRZ5yBAw2Njr45n0FSXX4F8PKd9WiRrynuhEXsw==", "324b00f4-b882-466b-9653-629f0dda1e30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43e74005-99d9-4c62-91bc-8fbc9e55f299", "AQAAAAIAAYagAAAAEIb8SjyPqclFCSw79h19thSX1i2aGbXO1cnKo0xcIH/vdyxHVy53IQ5KCav7HmUHSA==", "ae395d87-c316-4a1d-be00-05c81ec2eda3" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 9, 16, 11, 56, 47, 610, DateTimeKind.Local).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 9, 26, 11, 56, 47, 610, DateTimeKind.Local).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 9, 21, 11, 56, 47, 610, DateTimeKind.Local).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 10, 1, 11, 56, 47, 610, DateTimeKind.Local).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 9, 18, 11, 56, 47, 610, DateTimeKind.Local).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 10, 6, 11, 56, 47, 610, DateTimeKind.Local).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 1, 13, 11, 56, 47, 610, DateTimeKind.Local).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 2, 25, 11, 56, 47, 610, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2025, 1, 14, 11, 56, 47, 610, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 5, 14, 11, 56, 47, 610, DateTimeKind.Local).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2025, 1, 22, 11, 56, 47, 610, DateTimeKind.Local).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 10, 14, 11, 56, 47, 610, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 10, 15, 11, 56, 47, 610, DateTimeKind.Local).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 10, 13, 11, 56, 47, 610, DateTimeKind.Local).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 10, 12, 11, 56, 47, 610, DateTimeKind.Local).AddTicks(6033));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 10, 11, 11, 56, 47, 610, DateTimeKind.Local).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 10, 10, 11, 56, 47, 610, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 10, 9, 11, 56, 47, 610, DateTimeKind.Local).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 10, 8, 11, 56, 47, 610, DateTimeKind.Local).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 10, 7, 11, 56, 47, 610, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 10, 6, 11, 56, 47, 611, DateTimeKind.Local).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 10, 5, 11, 56, 47, 611, DateTimeKind.Local).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 10, 4, 11, 56, 47, 611, DateTimeKind.Local).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 10, 3, 11, 56, 47, 611, DateTimeKind.Local).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 10, 2, 11, 56, 47, 611, DateTimeKind.Local).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 10, 1, 11, 56, 47, 611, DateTimeKind.Local).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 9, 30, 11, 56, 47, 611, DateTimeKind.Local).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 9, 29, 11, 56, 47, 611, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 10, 9, 11, 56, 47, 611, DateTimeKind.Local).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 10, 11, 11, 56, 47, 611, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 10, 13, 11, 56, 47, 611, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 10, 15, 11, 56, 47, 611, DateTimeKind.Local).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 10, 14, 11, 56, 47, 611, DateTimeKind.Local).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 10, 12, 11, 56, 47, 611, DateTimeKind.Local).AddTicks(3568));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5e7b666-05c6-4251-9168-c1be743c1354", "AQAAAAIAAYagAAAAEAKVPHJq5ZarMVkelw1N66TGSDmTqwCPIs1hQ+zYabPGZ6bnsf8vPirn3MBFx3J8Tg==", "8fea3dbc-e4b2-467f-bc27-1536bb04c467" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a25e4a0-6557-4b06-9194-1f3cce6772a5", "AQAAAAIAAYagAAAAEDfxUKIlA9pjaQKlYaIL3xF9w4NGvejqcysmPtWEFf3yVaxDRkp4hokh+b6cvnnJYA==", "a11f634e-90fd-4c28-9c09-192673ddc07a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2399b791-a622-43b6-9284-2b157c19752c", "AQAAAAIAAYagAAAAEMvw2eP4+zhLg3q0h6Vs026oFHE6BvTAy6dmrPHyIMFC+HtOTYiMRQAzH3TSZUDsSQ==", "050d0d57-125d-4e7a-a8b4-a213c41fcb18" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 6, 9, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 6, 19, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 6, 14, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 6, 24, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 6, 11, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 6, 29, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 10, 6, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 11, 18, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 10, 7, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 2, 4, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1631));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 10, 15, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1633));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 7, 7, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 7, 8, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 7, 6, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1946));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 7, 5, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 7, 4, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 7, 3, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 7, 2, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 7, 1, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1958));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 30, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 29, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 28, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 27, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 26, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 25, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 24, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 23, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 22, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1979));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 7, 2, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 7, 4, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 7, 6, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 7, 8, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 7, 7, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 7, 5, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(2122));
        }
    }
}
