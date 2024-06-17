using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class AppropriateVisitorIndexBasedonUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "Visitor",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

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
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 1,
                columns: new[] { "CreatedByUserId", "Name" },
                values: new object[] { "1", "Alice Johnson" });

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 2,
                columns: new[] { "CreatedByUserId", "Name" },
                values: new object[] { "1", "Bob Smith" });

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 3,
                column: "CreatedByUserId",
                value: "1");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 4,
                column: "CreatedByUserId",
                value: "1");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 5,
                column: "CreatedByUserId",
                value: "1");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 6,
                column: "CreatedByUserId",
                value: "1");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 7,
                column: "CreatedByUserId",
                value: "1");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 8,
                column: "CreatedByUserId",
                value: "1");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 9,
                column: "CreatedByUserId",
                value: "1");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 10,
                column: "CreatedByUserId",
                value: "1");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 11,
                column: "CreatedByUserId",
                value: "2");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 12,
                column: "CreatedByUserId",
                value: "3");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 13,
                column: "CreatedByUserId",
                value: "1");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 14,
                column: "CreatedByUserId",
                value: "2");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 15,
                column: "CreatedByUserId",
                value: "2");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 16,
                column: "CreatedByUserId",
                value: "2");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 17,
                column: "CreatedByUserId",
                value: "2");

            migrationBuilder.InsertData(
                table: "Visitor",
                columns: new[] { "VisitorId", "Address", "CreatedByUserId", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 18, "321 Oak St", "3", "grace@example.com", "Grace Lee", "707-707-7070" },
                    { 19, "654 Elm St", "3", "jack@example.com", "Jack Wilson", "808-808-8080" },
                    { 20, "987 Pine Ave", "3", "lily@example.com", "Lily Smith", "909-909-9090" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Visitor_CreatedByUserId",
                table: "Visitor",
                column: "CreatedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Visitor_AspNetUsers_CreatedByUserId",
                table: "Visitor",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visitor_AspNetUsers_CreatedByUserId",
                table: "Visitor");

            migrationBuilder.DropIndex(
                name: "IX_Visitor_CreatedByUserId",
                table: "Visitor");

            migrationBuilder.DeleteData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 20);

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Visitor");

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
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 1,
                column: "Name",
                value: "Alice");

            migrationBuilder.UpdateData(
                table: "Visitor",
                keyColumn: "VisitorId",
                keyValue: 2,
                column: "Name",
                value: "Bob");

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
    }
}
