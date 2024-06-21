using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeCannotBeNullRetry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9694f9a9-e491-46c7-8c0a-52a7e67ec64e", "AQAAAAIAAYagAAAAEIuXpR9WVHJsgptFZCpWR/4c4wL5/YYEZ0+8gANWtAnXPBx5MsYIc1m1hxB4e6dpnw==", "1b75f7ea-086a-4386-9f79-12bd1fb6f0c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7655d59b-3781-4a87-b160-88e420518658", "AQAAAAIAAYagAAAAELdjeNsf/xaSg64yLfQhhYmoX73NWzoJbAv1LT1fdmS604gBsU3tzG4i/YL8KWXcKg==", "0c4124c2-98aa-42db-93cf-3f4cfc871d2e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1858605-e8b8-4092-b753-67cb8fd03f73", "AQAAAAIAAYagAAAAEJmaohfCh6tIP3e4Wepft06myfPlu8ht2n29d/yLuT+16/TZTVI8KhWN0Aff05Rp+Q==", "f43b24bb-fa0d-4685-a269-454364312d6e" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 18, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 5, 28, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 23, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 6, 2, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 20, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 6, 7, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 6, 27, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 7, 4, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 7, 12, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 17, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 27, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 15, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 16, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 14, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 13, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 12, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 11, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 10, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 9, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 8, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 7, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 6, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 5, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 4, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 3, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 2, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 1, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 31, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 6, 15, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 6, 16, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 6, 14, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 6, 13, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 6, 12, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 6, 11, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 6, 10, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 6, 9, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 6, 8, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 6, 7, 18, 52, 7, 132, DateTimeKind.Local).AddTicks(5575));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62d442c3-7d8d-4a19-9351-4faab3488e48", "AQAAAAIAAYagAAAAEKY3oPZ8DqyqVdbdP/h/X+unjymB4TC6RciQxnIqml8zUXmArHHcH3yqNvbKUP1ISQ==", "dc7ff59b-79fa-4253-baf5-1e47bc430608" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6abe2bd-34e9-4104-b074-9bd4992a0f6d", "AQAAAAIAAYagAAAAEHMGfZidtEW6NTFNpRDFh7iB+NE2rWV6ph3kg5hz9Gk4vCvPxzFLvUbQNAuKicfeBg==", "4c0c892f-34e0-4429-b980-059080df882b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0773ad80-77f0-4cda-9e9f-a3e5410cfe4e", "AQAAAAIAAYagAAAAEO4iIfIlhvVNThvZy8eOPzOjOQTA9x7bwW0EKgFz5x0Jr0dr8qvrLijCg+fDvGLAow==", "5386a6f7-dd28-4a4b-b5cd-d818292d7c8e" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 18, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 5, 28, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 23, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 6, 2, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7489));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 20, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 6, 7, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 6, 27, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 7, 4, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 7, 12, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 17, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 27, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7439));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 15, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 16, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 14, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 13, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 12, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 11, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 10, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 9, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 8, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 7, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 6, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 5, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 4, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 3, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 2, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 1, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 31, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 6, 15, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 6, 16, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 6, 14, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 6, 13, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 6, 12, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 6, 11, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 6, 10, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 6, 9, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 6, 8, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 6, 7, 18, 20, 29, 293, DateTimeKind.Local).AddTicks(7977));
        }
    }
}
