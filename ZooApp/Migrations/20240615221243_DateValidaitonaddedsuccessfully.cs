using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class DateValidaitonaddedsuccessfully : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93c2cb72-69ed-46c4-ab27-5cc420deae3d", "AQAAAAIAAYagAAAAEKyGnPhwA/x5KXZMpKguQFIe2z4l6GDhsVvfjhH9t1l+PT33PWDIf8jZQZPWQN0sXA==", "e3a2165b-ec32-47ad-b9ef-c08025180754" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c340593-a62f-4aca-bc76-fac5ba2e3087", "AQAAAAIAAYagAAAAEFRPc3VZMV6WmKarZMah/7vikrLp+Xld7OJ6sKg0uzU1vjj9heS31YIiabvYIyYIlQ==", "141ac672-4179-4ab0-bc4c-27077a583c61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89aa0fe2-4428-4f35-b891-e9aa96b37c70", "AQAAAAIAAYagAAAAEN7DhoozivSJ1iSjUq4XjMTU20lAziAPJxlmQ2hBjZj2oId8kXPk65xqJHPEwdL/8g==", "4a8ce79c-3652-47d1-a440-0cc2d8db285f" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 17, 10, 12, 41, 382, DateTimeKind.Local).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 5, 27, 10, 12, 41, 382, DateTimeKind.Local).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 22, 10, 12, 41, 382, DateTimeKind.Local).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 6, 1, 10, 12, 41, 382, DateTimeKind.Local).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 19, 10, 12, 41, 382, DateTimeKind.Local).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 6, 6, 10, 12, 41, 382, DateTimeKind.Local).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 6, 26, 10, 12, 41, 382, DateTimeKind.Local).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 7, 3, 10, 12, 41, 382, DateTimeKind.Local).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 7, 11, 10, 12, 41, 382, DateTimeKind.Local).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 16, 10, 12, 41, 382, DateTimeKind.Local).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 26, 10, 12, 41, 382, DateTimeKind.Local).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 14, 10, 12, 41, 382, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 15, 10, 12, 41, 382, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 13, 10, 12, 41, 382, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 12, 10, 12, 41, 382, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 11, 10, 12, 41, 382, DateTimeKind.Local).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 10, 10, 12, 41, 382, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 9, 10, 12, 41, 382, DateTimeKind.Local).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 8, 10, 12, 41, 382, DateTimeKind.Local).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 7, 10, 12, 41, 382, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 6, 10, 12, 41, 382, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 5, 10, 12, 41, 382, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 4, 10, 12, 41, 382, DateTimeKind.Local).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 3, 10, 12, 41, 382, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 2, 10, 12, 41, 382, DateTimeKind.Local).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 1, 10, 12, 41, 382, DateTimeKind.Local).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 31, 10, 12, 41, 382, DateTimeKind.Local).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 30, 10, 12, 41, 382, DateTimeKind.Local).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 6, 14, 10, 12, 41, 382, DateTimeKind.Local).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 6, 15, 10, 12, 41, 383, DateTimeKind.Local).AddTicks(24));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 6, 13, 10, 12, 41, 383, DateTimeKind.Local).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 6, 12, 10, 12, 41, 383, DateTimeKind.Local).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 6, 11, 10, 12, 41, 383, DateTimeKind.Local).AddTicks(112));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 6, 10, 10, 12, 41, 383, DateTimeKind.Local).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 6, 9, 10, 12, 41, 383, DateTimeKind.Local).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 6, 8, 10, 12, 41, 383, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 6, 7, 10, 12, 41, 383, DateTimeKind.Local).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 6, 6, 10, 12, 41, 383, DateTimeKind.Local).AddTicks(141));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "363222d3-3db1-44bf-9c2b-4719ed74336b", "AQAAAAIAAYagAAAAECJaINIbjNO6tCjunpibZmRERFbCY2auu0Oe0vqUy34rMVJN8/3nAZ8sH34nqSWWVg==", "2b116b80-6677-4b74-b998-b139e3f6b93a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2df8e25-8689-4f63-b778-baeb271917c2", "AQAAAAIAAYagAAAAEOH3B9IyUje83K7UpDpdaaZnjBkOqFVePjcrG8OxIsMW43XyMKQc2r1vDHgwAPh2UQ==", "f2f325a1-67f4-4c10-9176-37294e296546" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca2e0497-4c15-4425-b68a-1695a6c9a065", "AQAAAAIAAYagAAAAEO3QuaKyr1psD96AbcAZWhWwloAU9T/NPPXOaPDxZ1CGHK/rmmsIQT8mr7FO5tyCzg==", "890e8946-fee9-4df7-b61e-3908bc457efd" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 16, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 5, 26, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 21, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 5, 31, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 18, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 6, 5, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 6, 25, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 7, 2, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 7, 10, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 15, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 25, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 13, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 14, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 12, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 11, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 10, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 9, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 8, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 7, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 6, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 5, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 4, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 3, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 2, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 1, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 31, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 30, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 29, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 6, 13, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 6, 14, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 6, 12, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 6, 11, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 6, 10, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 6, 9, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 6, 8, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 6, 7, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 6, 6, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 6, 5, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4944));
        }
    }
}
