using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class displayingname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf559f82-3fac-40ab-bc5e-e15177269e56", "AQAAAAIAAYagAAAAEHfQ6Mz84K9jBy6ql6Fy/RvkJm7D7RmPN/rrOPZPm6wLaKyj2wQx5usuDfkJJkUKPA==", "b9380f4a-8d7f-4b5f-ac40-31bf73c1dcf5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12c42086-f84f-454e-b342-0940467e88b7", "AQAAAAIAAYagAAAAEItbxuhrS8RKsExmrirYrSxhiYk/hRVRFDmIYDP3pp4GUcJ54rX+D+BztiSSMo8Y6g==", "e504ab40-0f51-4ec2-94ea-f2a9d4888c53" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 4, 30, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 5, 10, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 5, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 5, 15, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 2, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 5, 20, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 6, 9, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 6, 16, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(194));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 6, 24, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 6, 29, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 9, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 28, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 29, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 27, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 26, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 25, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 24, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 23, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 22, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 21, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 20, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 19, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 18, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 17, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 16, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 15, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 14, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 13, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 5, 28, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 5, 29, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 5, 27, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 5, 26, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 5, 25, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 5, 24, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 5, 23, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 5, 22, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 5, 21, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 5, 20, 18, 32, 49, 807, DateTimeKind.Local).AddTicks(614));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72bbd5c0-275d-439e-bb86-4bd99e7aeb3d", "AQAAAAIAAYagAAAAELUyNYsFrUHPjCej4LtVm0OzK9ol/lIfhf0Bb0OQBQ7SVV/ywvZy2OtzBvTdZokskw==", "d3ae70d0-6e3e-40a3-a2e1-3df3643f53ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "414e24f7-e8c6-4741-a0e4-ee561527d13d", "AQAAAAIAAYagAAAAEOHHSeKYV7AHDFQk6cJNfjvNfiubbJYvOsHOCFE30ev3eqH74V+vHzGGyUM1fKDMlg==", "06efb07a-3803-4cb9-9f7e-0c3ce951ee9a" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 4, 30, 17, 53, 15, 648, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 5, 10, 17, 53, 15, 648, DateTimeKind.Local).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 5, 17, 53, 15, 648, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 5, 15, 17, 53, 15, 648, DateTimeKind.Local).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 2, 17, 53, 15, 648, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 5, 20, 17, 53, 15, 648, DateTimeKind.Local).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 6, 9, 17, 53, 15, 648, DateTimeKind.Local).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 6, 16, 17, 53, 15, 648, DateTimeKind.Local).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 6, 24, 17, 53, 15, 648, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 6, 29, 17, 53, 15, 648, DateTimeKind.Local).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 9, 17, 53, 15, 648, DateTimeKind.Local).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 28, 17, 53, 15, 649, DateTimeKind.Local).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 29, 17, 53, 15, 649, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 27, 17, 53, 15, 649, DateTimeKind.Local).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 26, 17, 53, 15, 649, DateTimeKind.Local).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 25, 17, 53, 15, 649, DateTimeKind.Local).AddTicks(1071));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 24, 17, 53, 15, 649, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 23, 17, 53, 15, 649, DateTimeKind.Local).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 22, 17, 53, 15, 649, DateTimeKind.Local).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 21, 17, 53, 15, 649, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 20, 17, 53, 15, 649, DateTimeKind.Local).AddTicks(1081));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 19, 17, 53, 15, 649, DateTimeKind.Local).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 18, 17, 53, 15, 649, DateTimeKind.Local).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 17, 17, 53, 15, 649, DateTimeKind.Local).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 16, 17, 53, 15, 649, DateTimeKind.Local).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 15, 17, 53, 15, 649, DateTimeKind.Local).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 14, 17, 53, 15, 649, DateTimeKind.Local).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 13, 17, 53, 15, 649, DateTimeKind.Local).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 5, 28, 17, 53, 15, 649, DateTimeKind.Local).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 5, 29, 17, 53, 15, 649, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 5, 27, 17, 53, 15, 649, DateTimeKind.Local).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 5, 26, 17, 53, 15, 649, DateTimeKind.Local).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 5, 25, 17, 53, 15, 649, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 5, 24, 17, 53, 15, 649, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 5, 23, 17, 53, 15, 649, DateTimeKind.Local).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 5, 22, 17, 53, 15, 649, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 5, 21, 17, 53, 15, 649, DateTimeKind.Local).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 5, 20, 17, 53, 15, 649, DateTimeKind.Local).AddTicks(4900));
        }
    }
}
