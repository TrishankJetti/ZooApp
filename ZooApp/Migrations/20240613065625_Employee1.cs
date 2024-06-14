using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class Employee1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageFileName",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8278be1-f0cb-470f-81e4-09385a755e90", "AQAAAAIAAYagAAAAEIWt21UvQa7+s7rhiVOb2tUH6thZOWfKgCw6mwu4xuWWeRlQ2pJWRcWIM16j+gDTxw==", "cc1608cd-a32c-4b4b-bd9b-4f4b21be2b1f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "889d2d62-7fad-4c38-87b1-50cb08f8ed74", "AQAAAAIAAYagAAAAEGzi6O3IQTwelMdX3yTvLmqUBhpvvTt0fRqXcV11Umf+LzV6CbCcOBRFZaaxTCqhpg==", "92702df1-792b-4a93-83b2-39d78530c933" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f262ff6-677b-470a-a3a6-f65417b0b1fc", "AQAAAAIAAYagAAAAEGhG9j/70fYg8u0cLh2VvTyeXfEgkdTd7TZFJCMllChLpIZwzLNFAFzPEnVBhpKJ2Q==", "a5eade5f-7361-4552-af2a-cd6bda23856f" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 14, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 5, 24, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 19, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 5, 29, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 16, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 6, 3, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(2716));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 6, 23, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 6, 30, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 7, 8, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 13, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 23, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 11, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 12, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 10, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 9, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 8, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 7, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 6, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 5, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 4, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 3, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(3006));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 2, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 1, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 31, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(3011));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 30, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(3013));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 29, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(3015));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 28, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 27, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(3018));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 6, 11, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 6, 12, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 6, 10, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 6, 9, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(3142));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 6, 8, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 6, 7, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 6, 6, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 6, 5, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 6, 4, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 6, 3, 18, 56, 24, 907, DateTimeKind.Local).AddTicks(3153));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageFileName",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab87e87b-68c1-4864-8ae8-0e4c0325dd3e", "AQAAAAIAAYagAAAAEMuZbzTqj/CQPz1EuctsVBV+DMTHuKSPdoWfp/CunGmHi9fkhgUI+14kA7/QUzx6vg==", "e55b89e3-3ede-4291-9750-b6ab6794f163" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1db28e58-80a6-4969-9e53-2a2ecafa9b6c", "AQAAAAIAAYagAAAAEAWgfA7XdVFDWNvtgWeM5qoVwDUibfJvZk22/hl5WBqaUeKGU+kYbW+10sq4EWkJ3Q==", "6daecf11-854c-4363-a01b-599a3515e09a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e8eef38-9639-448e-a516-9084f4140271", "AQAAAAIAAYagAAAAEDVLiuopefEAHL/vZOfjzH6gZQ2yAvAhemi1tc8xoJf65sG7kLZvBQqNhqJxKelJDQ==", "417e56b0-f7bf-4961-9674-fcebb6d93a16" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 14, 18, 34, 28, 903, DateTimeKind.Local).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 5, 24, 18, 34, 28, 903, DateTimeKind.Local).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 19, 18, 34, 28, 903, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 5, 29, 18, 34, 28, 903, DateTimeKind.Local).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 16, 18, 34, 28, 903, DateTimeKind.Local).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 6, 3, 18, 34, 28, 903, DateTimeKind.Local).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 6, 23, 18, 34, 28, 902, DateTimeKind.Local).AddTicks(9903));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 6, 30, 18, 34, 28, 902, DateTimeKind.Local).AddTicks(9961));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 7, 8, 18, 34, 28, 902, DateTimeKind.Local).AddTicks(9964));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 13, 18, 34, 28, 902, DateTimeKind.Local).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 23, 18, 34, 28, 902, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 11, 18, 34, 28, 903, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 12, 18, 34, 28, 903, DateTimeKind.Local).AddTicks(244));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 10, 18, 34, 28, 903, DateTimeKind.Local).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 9, 18, 34, 28, 903, DateTimeKind.Local).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 8, 18, 34, 28, 903, DateTimeKind.Local).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 7, 18, 34, 28, 903, DateTimeKind.Local).AddTicks(252));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 6, 18, 34, 28, 903, DateTimeKind.Local).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 5, 18, 34, 28, 903, DateTimeKind.Local).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 4, 18, 34, 28, 903, DateTimeKind.Local).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 3, 18, 34, 28, 903, DateTimeKind.Local).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 2, 18, 34, 28, 903, DateTimeKind.Local).AddTicks(262));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 1, 18, 34, 28, 903, DateTimeKind.Local).AddTicks(264));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 31, 18, 34, 28, 903, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 30, 18, 34, 28, 903, DateTimeKind.Local).AddTicks(267));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 29, 18, 34, 28, 903, DateTimeKind.Local).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 28, 18, 34, 28, 903, DateTimeKind.Local).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 27, 18, 34, 28, 903, DateTimeKind.Local).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 6, 11, 18, 34, 28, 903, DateTimeKind.Local).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 6, 12, 18, 34, 28, 903, DateTimeKind.Local).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 6, 10, 18, 34, 28, 903, DateTimeKind.Local).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 6, 9, 18, 34, 28, 903, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 6, 8, 18, 34, 28, 903, DateTimeKind.Local).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 6, 7, 18, 34, 28, 903, DateTimeKind.Local).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 6, 6, 18, 34, 28, 903, DateTimeKind.Local).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 6, 5, 18, 34, 28, 903, DateTimeKind.Local).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 6, 4, 18, 34, 28, 903, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 6, 3, 18, 34, 28, 903, DateTimeKind.Local).AddTicks(399));
        }
    }
}
