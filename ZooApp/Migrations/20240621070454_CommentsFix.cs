using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class CommentsFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EditedBy",
                table: "VisitorLog",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "VisitorLog",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ddd718a6-a4a7-4821-a2bc-91a2fa303717", "AQAAAAIAAYagAAAAEM2vEiqeMFvjCHzXf52/QExkDI6072nctbANCJQqzU5Z0Sr+trifTfcf9XUf8lWkmQ==", "e37f5d29-617f-4a76-a8b2-6ffb94759432" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d21e3353-f3bf-47f2-8dec-33361460ffc2", "AQAAAAIAAYagAAAAEBgLFleEl08Y99wQh0R9oCI78xeRLj6X7SEZAgH9TB+8fbv8mX4DvpzyUmR8qkXSEg==", "f0b46166-07ac-46ef-b7a1-6828440f16ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48105f97-08db-4e6f-adc4-51a96b6879d5", "AQAAAAIAAYagAAAAEMc8ZHNl6orndwsp5f2s7+9c6A23n9MIWIpM+mF5YqWYsdG3vBCEkNLv7jhr81O84w==", "52b9f23b-c6af-4e38-90a9-b2e56faf9f90" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 22, 19, 4, 53, 286, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 6, 1, 19, 4, 53, 286, DateTimeKind.Local).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 27, 19, 4, 53, 286, DateTimeKind.Local).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 6, 6, 19, 4, 53, 286, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 24, 19, 4, 53, 286, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 6, 11, 19, 4, 53, 286, DateTimeKind.Local).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 7, 1, 19, 4, 53, 286, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 7, 8, 19, 4, 53, 286, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 7, 16, 19, 4, 53, 286, DateTimeKind.Local).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 21, 19, 4, 53, 286, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 31, 19, 4, 53, 286, DateTimeKind.Local).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 19, 19, 4, 53, 286, DateTimeKind.Local).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 20, 19, 4, 53, 286, DateTimeKind.Local).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 18, 19, 4, 53, 286, DateTimeKind.Local).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 17, 19, 4, 53, 286, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 16, 19, 4, 53, 286, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 15, 19, 4, 53, 286, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 14, 19, 4, 53, 286, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 13, 19, 4, 53, 286, DateTimeKind.Local).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 12, 19, 4, 53, 286, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 11, 19, 4, 53, 286, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 10, 19, 4, 53, 286, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 9, 19, 4, 53, 286, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 8, 19, 4, 53, 286, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 7, 19, 4, 53, 286, DateTimeKind.Local).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 6, 19, 4, 53, 286, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 5, 19, 4, 53, 286, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 4, 19, 4, 53, 286, DateTimeKind.Local).AddTicks(8393));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EditedBy",
                table: "VisitorLog");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "VisitorLog");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc67e710-5417-4bbb-ae70-c819ef3783d7", "AQAAAAIAAYagAAAAEAh3hBdMYwfCYUmPLfLrY3zZvnqIOtx/JXAsNvufuFg7r4i+liCul2BJQOvI0nCb7Q==", "29add110-654c-4f47-ad49-8edaf69f5577" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "910e9b71-a53e-48aa-ab74-c2aa9a05e5c7", "AQAAAAIAAYagAAAAEAnV2avHkDj0RAct/Xcyi1iT0zpJC5cAZimK/DzcooUxawxSZwgQwpULWVLIC+I+ng==", "9030908a-163a-4003-ac39-f1bace0a8004" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6057a52e-21cb-4a76-b33b-9b4853b16482", "AQAAAAIAAYagAAAAEISEmuniHAiFZx0r0j27q+eUFJNMLvqjnOizyCS+ZKzmpt49N5tJpX3EYVcLmnJnoA==", "352b5d5a-d5d7-4b25-bb4c-346a7f2c17b7" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 21, 20, 2, 13, 796, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 5, 31, 20, 2, 13, 796, DateTimeKind.Local).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 26, 20, 2, 13, 796, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 6, 5, 20, 2, 13, 796, DateTimeKind.Local).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 23, 20, 2, 13, 796, DateTimeKind.Local).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 6, 10, 20, 2, 13, 796, DateTimeKind.Local).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 6, 30, 20, 2, 13, 796, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 7, 7, 20, 2, 13, 796, DateTimeKind.Local).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 7, 15, 20, 2, 13, 796, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 20, 20, 2, 13, 796, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 30, 20, 2, 13, 796, DateTimeKind.Local).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 18, 20, 2, 13, 796, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 19, 20, 2, 13, 796, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 17, 20, 2, 13, 796, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 16, 20, 2, 13, 796, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 15, 20, 2, 13, 796, DateTimeKind.Local).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 14, 20, 2, 13, 796, DateTimeKind.Local).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 13, 20, 2, 13, 796, DateTimeKind.Local).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 12, 20, 2, 13, 796, DateTimeKind.Local).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 11, 20, 2, 13, 796, DateTimeKind.Local).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 10, 20, 2, 13, 796, DateTimeKind.Local).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 9, 20, 2, 13, 796, DateTimeKind.Local).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 8, 20, 2, 13, 796, DateTimeKind.Local).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 7, 20, 2, 13, 796, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 6, 20, 2, 13, 796, DateTimeKind.Local).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 5, 20, 2, 13, 796, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 4, 20, 2, 13, 796, DateTimeKind.Local).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 3, 20, 2, 13, 796, DateTimeKind.Local).AddTicks(6489));
        }
    }
}
