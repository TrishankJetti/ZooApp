using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class allownulls1 : Migration
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
                values: new object[] { "d366ac41-144d-4faf-8202-aed2f3620b64", "AQAAAAIAAYagAAAAEG8XsPvB2+oOzIeqrVqZZ24CUS+0/zhiKIla8gPA5w16hBVfNiYrYVKbch2dL8p4nw==", "274c19a5-1f87-4808-bc63-09ff41a20801" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90485a49-5c80-41f0-88c9-6bda4432f98f", "AQAAAAIAAYagAAAAEGK7VBWoafGGlN/fk9BGb7bYazoHhLQMNUmsrz5vZqVpjbbUJJIfkgPY4O5lWXYypg==", "a63f0893-a012-4172-a4cc-816fc793599e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dcd75ed0-695e-4c33-968e-24007deea45c", "AQAAAAIAAYagAAAAEPDR0yhZMlsQ1k2br/ZCC82SI4BbBaU46r33UcqwVxKlIlHuyLL/g09HLPLrv9EUrA==", "51906ab7-f1b0-47ba-b4b9-828384032afc" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 16, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 5, 26, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 21, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 5, 31, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 18, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 6, 5, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 6, 25, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 7, 2, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 7, 10, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 15, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 25, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 13, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 14, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 12, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 11, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 10, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 9, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 8, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 7, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 6, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 5, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 4, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 3, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 2, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 1, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 31, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 30, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 29, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 6, 13, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 6, 14, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 6, 12, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 6, 11, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 6, 10, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 6, 9, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 6, 8, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 6, 7, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 6, 6, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 6, 5, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6647));
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
    }
}
