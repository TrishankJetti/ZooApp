using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class initialREgistration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 4, 1, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 4, 11, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 4, 6, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 4, 16, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 4, 3, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 4, 21, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 5, 11, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 5, 18, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 5, 26, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 5, 31, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 6, 10, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 29, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 30, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(962));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 28, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 27, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 26, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 25, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 24, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 23, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 22, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 21, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 20, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 19, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 18, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 17, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 16, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 15, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 14, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 4, 29, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 4, 30, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 4, 28, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 4, 27, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 4, 26, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 4, 25, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 4, 24, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 4, 23, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(1081));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 4, 22, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 4, 21, 22, 9, 48, 474, DateTimeKind.Local).AddTicks(1084));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 3, 17, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2457));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 3, 27, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 3, 14, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 4, 1, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2466));

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

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 5, 6, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 5, 11, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 5, 21, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2301));

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

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 8, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 7, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 6, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 5, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 4, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 3, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 2, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 4, 1, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 3, 31, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 3, 30, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 3, 29, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 3, 28, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 3, 27, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 3, 26, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 3, 25, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2713));

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

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 4, 8, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 4, 7, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2836));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 4, 6, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 4, 5, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 4, 4, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 4, 3, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 4, 2, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2848));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 4, 1, 18, 42, 56, 62, DateTimeKind.Local).AddTicks(2851));
        }
    }
}
