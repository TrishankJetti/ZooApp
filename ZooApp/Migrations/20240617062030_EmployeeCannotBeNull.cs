using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeCannotBeNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aed1e93d-adf9-4989-b1f3-1c14ad2a2744", "AQAAAAIAAYagAAAAEG2J3aRwY/yqcD8sV1BoDeidqqot6uzWyABT8o8usTK4bTzU0Xc5B8Z4EKGsUYUV8Q==", "7c713025-dd83-470e-b730-29dde2fd116e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42381acc-656f-43ef-8539-edce1212f008", "AQAAAAIAAYagAAAAEMNAos/h1iQDEIYMPOIy9+xB8NxvYAW+2xKtF/IpklR1kTEcEKqDWvIZJX03PbU2aw==", "e4a1cd97-1ede-41c5-a8ee-dd8dcaf78d5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "026029d8-ff51-4fa0-b3ad-c7395022f21a", "AQAAAAIAAYagAAAAEN0wuth/AibbajU0+cFCcSRU0q35wNSEp/YY4VHFcnB8nJPCDqVVrH4izIa8YNTuhw==", "8738eed0-31ad-4534-98b5-b0a6169e994a" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 17, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 5, 27, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 22, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 6, 1, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 19, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 6, 6, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 6, 26, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 7, 3, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 7, 11, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 16, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 26, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(3595));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 14, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 15, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 13, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 12, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 11, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 10, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 9, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 8, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 7, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 6, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 5, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 4, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 3, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 2, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 1, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 31, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 30, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 6, 14, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 6, 15, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 6, 13, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 6, 12, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 6, 11, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 6, 10, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 6, 9, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 6, 8, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 6, 7, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 6, 6, 21, 1, 32, 730, DateTimeKind.Local).AddTicks(4174));
        }
    }
}
