using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class identity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 4, 10, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 4, 20, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 4, 15, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 4, 25, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 4, 12, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 4, 30, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 5, 20, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 5, 27, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(3205));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 6, 4, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 6, 9, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 6, 19, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 8, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 9, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 7, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 6, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 5, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 4, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 3, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 2, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 1, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 30, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 29, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 28, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 27, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 26, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 25, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 24, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 23, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 5, 8, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 5, 9, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 5, 7, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 5, 6, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 5, 5, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 5, 4, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 5, 3, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 5, 2, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 5, 1, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 4, 30, 11, 5, 48, 794, DateTimeKind.Local).AddTicks(4157));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 4, 7, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 4, 17, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 4, 12, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 4, 22, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 4, 9, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 4, 27, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 5, 17, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 5, 24, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 6, 1, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 6, 6, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1404));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 6, 16, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1406));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 5, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 6, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 4, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 3, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 2, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 1, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 30, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1714));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 29, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 28, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 27, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 26, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 25, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 24, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 23, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 22, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 21, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 20, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 5, 5, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 5, 6, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1861));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 5, 4, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 5, 3, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 5, 2, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 5, 1, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 4, 30, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 4, 29, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 4, 28, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 4, 27, 21, 22, 9, 55, DateTimeKind.Local).AddTicks(1874));
        }
    }
}
