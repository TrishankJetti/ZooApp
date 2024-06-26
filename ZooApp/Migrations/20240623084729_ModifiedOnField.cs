using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedOnField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "VisitorLog",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f741f43d-fa15-443e-b63f-8395dfba3c83", "AQAAAAIAAYagAAAAEG7MuBaYu6O6ek9cvwjjIdzun2AaTyVOPYmWRXv924+8m27R37v3VVSq+d8QMRlmUA==", "346185fc-5c8f-4ac1-a20b-ff6c742d31f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae341b53-8b3b-4975-9c76-27b95df062b3", "AQAAAAIAAYagAAAAEAHfJHRWFGaLyYXypOu1AV9xKggV/lw2bqos+6z8h6clyyQwXrDZlMPciE6sfR6kug==", "9428628e-b66a-446d-a48d-46f3308fe8f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40921ecf-ceb9-4a32-851a-3c0c7791426b", "AQAAAAIAAYagAAAAEFJHvUWbyBk9rK2ESr2yvtxpkP/+6rNSjwLv8kGFi8NGs0GkLM9NNvje5SSXUCDqHw==", "c2dc445d-b0da-4312-88af-140adf7bbd35" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 24, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 6, 3, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 29, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 6, 8, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 26, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 6, 13, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 9, 20, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 11, 2, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 9, 21, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 1, 19, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 9, 29, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 21, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 22, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 20, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 19, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 18, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 17, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 16, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 15, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 14, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 13, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 12, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 11, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 10, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 9, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 8, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 7, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 6, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4785), null });

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 6, 18, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4789), null });

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 6, 20, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4792), null });

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 6, 22, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4794), null });

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 6, 21, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4797), null });

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 6, 19, 20, 47, 28, 590, DateTimeKind.Local).AddTicks(4800), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "VisitorLog");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b61a2417-55c4-4724-a104-a8492d2eac5b", "AQAAAAIAAYagAAAAEPjdqiNMYuy1LRwaag7sSViId5HTX/p9bEcOpwl2cKzM+nyECx6HR5+zqjX5WJCsTQ==", "5b1f332b-4213-4028-b850-8b39db531a80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4de3d43-f49c-4545-bb5b-8b8f839eafde", "AQAAAAIAAYagAAAAEK+cabDJP/f4oQGvUD8GKx45z8wADOjjEzgt0/XrXXHHhnsyj1tZlMZRpqe8uZQ6iA==", "b02aa479-af4d-41d3-8bc9-b22851d2b0e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62d504c2-31c0-4a22-9ff1-2974f1e64e3f", "AQAAAAIAAYagAAAAENxvCKRa9zbuW+mfldCfn5LnIKKIMT5Y9hFJBwwvFNys7ZKdmAU1Hrmzhrb1LpoYBQ==", "0d537f4d-afc2-4267-ab90-7197c50de41c" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 24, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 6, 3, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 29, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 6, 8, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 26, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 6, 13, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 9, 20, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 11, 2, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 9, 21, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 1, 19, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 9, 29, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 21, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 22, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 20, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 19, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 18, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 17, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 16, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 15, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 14, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 13, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 12, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 11, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 10, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 9, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 8, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 7, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 6, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 18, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 20, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 22, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 21, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 19, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(6838));
        }
    }
}
