using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class allownulls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "3c91dd4f-1509-41fa-910e-bc1762f6bf54", "AQAAAAIAAYagAAAAEEHDZXtUA0YSjwm7TeZEMYPH0SX75w2W9b2ERhlGX0xE2mVD1987xbDh7zfxhsGjDA==", "53b459b0-4292-47a2-b816-302f2aa3ad81" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6e9b759-a2ba-4b54-9bcd-9d2007af2153", "AQAAAAIAAYagAAAAEGobqvGxa9iXejslxZFMAObXY4pAbHccUKZyZAqlAIr2XRD7YTp3OQh0v2mltBZdtQ==", "239d8c90-4d29-4035-a053-149d2d71a5dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7caa5b24-218c-4b6c-bbd2-a46b5b9dc000", "AQAAAAIAAYagAAAAEDiJDkppVhgDHgUaTCmT4qzhDAuyrAx5C4tqQl6lGhfEu76FgWgWRc7/swatpl2DJw==", "db7520c5-c6d5-4c5f-a165-8db72a0f0f23" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 16, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 5, 26, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 21, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 5, 31, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 18, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 6, 5, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 6, 25, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 7, 2, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 7, 10, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 15, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 25, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 13, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 14, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 12, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 11, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 10, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 9, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 8, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 7, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 6, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 5, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 4, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 3, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 2, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 1, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 31, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 30, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 29, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 6, 13, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 6, 14, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 6, 12, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 6, 11, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 6, 10, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 6, 9, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 6, 8, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 6, 7, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 6, 6, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 6, 5, 9, 19, 36, 337, DateTimeKind.Local).AddTicks(8465));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
