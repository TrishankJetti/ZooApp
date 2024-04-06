using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class sampledata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 1,
                columns: new[] { "EmployeeId", "Name", "Species" },
                values: new object[] { 1, "Simba", "Lion" });

            migrationBuilder.UpdateData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 2,
                columns: new[] { "EmployeeId", "Name", "Sex", "Species" },
                values: new object[] { 2, "Dumbo", 0, "Elephant" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "EnclosureId", "HireDate" },
                values: new object[] { 0, new DateTime(2024, 4, 7, 5, 56, 27, 658, DateTimeKind.Local).AddTicks(8803) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "EnclosureId", "HireDate" },
                values: new object[] { 0, new DateTime(2024, 4, 7, 5, 56, 27, 658, DateTimeKind.Local).AddTicks(8807) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 14, 5, 56, 27, 658, DateTimeKind.Local).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 4, 21, 5, 56, 27, 658, DateTimeKind.Local).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 5, 5, 56, 27, 658, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 6, 5, 56, 27, 658, DateTimeKind.Local).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 4, 5, 5, 56, 27, 658, DateTimeKind.Local).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 4, 6, 5, 56, 27, 658, DateTimeKind.Local).AddTicks(9646));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 1,
                columns: new[] { "EmployeeId", "Name", "Species" },
                values: new object[] { 0, "Lion", "Panthera leo" });

            migrationBuilder.UpdateData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 2,
                columns: new[] { "EmployeeId", "Name", "Sex", "Species" },
                values: new object[] { 0, "Elephant", 1, "Loxodonta africana" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "EnclosureId", "HireDate" },
                values: new object[] { 1, new DateTime(2024, 4, 6, 18, 4, 52, 106, DateTimeKind.Local).AddTicks(4212) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "EnclosureId", "HireDate" },
                values: new object[] { 2, new DateTime(2024, 4, 6, 18, 4, 52, 106, DateTimeKind.Local).AddTicks(4261) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 13, 18, 4, 52, 106, DateTimeKind.Local).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 4, 20, 18, 4, 52, 106, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 4, 18, 4, 52, 106, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 5, 18, 4, 52, 106, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 4, 4, 18, 4, 52, 106, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 4, 5, 18, 4, 52, 106, DateTimeKind.Local).AddTicks(4423));
        }
    }
}
