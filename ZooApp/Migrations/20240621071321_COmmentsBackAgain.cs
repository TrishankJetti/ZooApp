using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class COmmentsBackAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "98afd960-38ee-4c6f-b057-596d0f9e940a", "AQAAAAIAAYagAAAAENGDJrfJu9X0X6s3s4UU4vzwSSwlWmZuOXUCE7tE6hrMyT9gXKRy/ypn6ey4rIAHAg==", "9d808b0a-4556-4526-b626-9fd6995ef09a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62225784-cf8f-4a08-ab63-0306b0f11323", "AQAAAAIAAYagAAAAEAdCkfCjSp752Qw/G1L5GY/gOiM3UGHGQG65jo4luV+mnz3bGh4yhyskiCRVsr/BQQ==", "1c3791ea-5450-4a61-840c-83e54260d14d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a719f82-eef0-4c7f-9a8d-e32420ee4613", "AQAAAAIAAYagAAAAEIo2qJv6cH6hFdNKZvBYv9OYOnsTvDyiJYO9MJVvpbYX1UVpdHgW6JocZOsRjpYSLQ==", "f5e55bf1-0548-49e1-96d6-a7ee65be8a2b" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 22, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 6, 1, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 27, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 6, 6, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3113));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 24, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 6, 11, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 7, 1, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 7, 8, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 7, 16, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 21, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 31, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 19, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 20, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 18, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 17, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 16, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 15, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 14, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 13, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 12, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 11, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 10, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 9, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 8, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 7, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 6, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 5, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 4, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3399));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
