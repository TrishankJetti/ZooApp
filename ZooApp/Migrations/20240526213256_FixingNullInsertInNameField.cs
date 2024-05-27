using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class FixingNullInsertInNameField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Visitor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 4, 27, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 5, 7, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 2, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 5, 12, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 4, 29, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 5, 17, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 6, 6, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 6, 13, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 6, 21, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 6, 26, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 6, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 25, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 26, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 24, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 23, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9723));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 22, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 21, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9728));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 20, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9731));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 19, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9735));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 18, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9738));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 17, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9741));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 16, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 15, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 14, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 13, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 12, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9754));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 11, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 10, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 5, 25, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 5, 26, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 5, 24, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 5, 23, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 5, 22, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 5, 21, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 5, 20, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9961));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 5, 19, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9964));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 5, 18, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 5, 17, 9, 32, 54, 874, DateTimeKind.Local).AddTicks(9969));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Visitor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
