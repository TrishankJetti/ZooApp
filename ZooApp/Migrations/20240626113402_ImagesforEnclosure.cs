using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class ImagesforEnclosure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageFileName",
                table: "Enclosure",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07a47c43-1947-4382-93c2-de08186d0cfb", "AQAAAAIAAYagAAAAEBG977AUab4JxcNF4xCVVMuUXOBo7ycygskQx/mr2TS71LHI3qsF1RnVlReaE6axdA==", "6d24e9fd-32e2-46c7-9f5f-b6fc02e01a4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "837c8889-eb3b-4c00-ad2a-58ab2b407492", "AQAAAAIAAYagAAAAELYxm3wutd8YhCy4Ryym6HvZqXWufBI2CjW/358H3WCgA0FRHdXMNwYS48kQ7HZtsQ==", "44404b72-f6a0-45e6-aabc-5a80f978fc7d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3bf71e78-2554-4d08-98fb-c1be0566084e", "AQAAAAIAAYagAAAAELqg9Ph7SVj4aeHim35nMWbfwI0aoB2EhWhD1RgnFgwS3iP+Hzx9IU0ArS+kug+kVQ==", "c3b82911-933a-4cdf-82f3-403415bdb556" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 27, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 6, 6, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 6, 1, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 6, 11, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 29, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 6, 16, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "Enclosure",
                keyColumn: "EnclosureId",
                keyValue: 1,
                column: "ImageFileName",
                value: "Savannah.jpg");

            migrationBuilder.UpdateData(
                table: "Enclosure",
                keyColumn: "EnclosureId",
                keyValue: 2,
                column: "ImageFileName",
                value: "Jungle.jpg");

            migrationBuilder.UpdateData(
                table: "Enclosure",
                keyColumn: "EnclosureId",
                keyValue: 3,
                column: "ImageFileName",
                value: "Forest.jpg");

            migrationBuilder.UpdateData(
                table: "Enclosure",
                keyColumn: "EnclosureId",
                keyValue: 4,
                column: "ImageFileName",
                value: "River.jpg");

            migrationBuilder.UpdateData(
                table: "Enclosure",
                keyColumn: "EnclosureId",
                keyValue: 5,
                column: "ImageFileName",
                value: "Aviary.jpg");

            migrationBuilder.UpdateData(
                table: "Enclosure",
                keyColumn: "EnclosureId",
                keyValue: 6,
                column: "ImageFileName",
                value: "Arctic.jpg");

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 9, 23, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 11, 5, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 9, 24, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 1, 22, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2145));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 10, 2, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 24, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 25, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 23, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2787));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 22, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 21, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 20, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 19, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2808));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 18, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 17, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 16, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 15, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2865));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 14, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 13, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 12, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 11, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 10, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 9, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2895));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 19, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 21, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 23, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 25, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 24, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 22, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(3204));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageFileName",
                table: "Enclosure");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "078ff8ed-a0ea-480b-adb4-1dd840015d8d", "AQAAAAIAAYagAAAAEPb51jUT39ue1031cUEW58A8aN7g9i1Z5Vt9lG12tD9qs4RwQ8A4/lwpM4nVMCk9OQ==", "a8c07529-4515-4b14-8e1b-e0bdf4d29aff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2dac9825-4936-464a-9cc8-b14cc9633eb1", "AQAAAAIAAYagAAAAEEPSFd9ILqz17CLaXaq5t6Kfy4Y0cUAAoBicoHrFHLA50FM8ps5tAxbx52csVZpepg==", "95cf02c4-344d-4b43-8500-0e663c9d673e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d6d5106-9e9d-423a-8d23-25ac82a1c278", "AQAAAAIAAYagAAAAEEpU7Lzy815HQno5cA1FGe12hg8Fm44OhojCS5KqT7l6MB3StqZ+/FXYYLWIguaATA==", "225aa0a8-06b0-4648-b04e-092844133844" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 24, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 6, 3, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 29, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 6, 8, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 26, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 6, 13, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 9, 20, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 11, 2, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 9, 21, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 1, 19, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 9, 29, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 21, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 22, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 20, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 19, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6057));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 18, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 17, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 16, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 15, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 14, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 13, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 12, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 11, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 10, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 9, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 8, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 7, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 6, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 18, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 20, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 22, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 21, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 19, 22, 1, 53, 82, DateTimeKind.Local).AddTicks(6337));
        }
    }
}
