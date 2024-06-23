using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class Comments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "VisitorLog",
                columns: new[] { "VisitorLogId", "Comments", "CreatedOn", "Review", "VisitorId" },
                values: new object[,]
                {
                    { 1, "Had a wonderful time seeing the lions.", new DateTime(2024, 6, 16, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(6775), 0, 1 },
                    { 2, "The enclosures were clean and animals seemed happy.", new DateTime(2024, 6, 18, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(6816), 0, 2 },
                    { 3, "It was okay, but a bit crowded.", new DateTime(2024, 6, 20, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(6823), 2, 3 },
                    { 4, "The event was informative, but too long.", new DateTime(2024, 6, 22, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(6829), 2, 4 },
                    { 5, "Had issues finding parking.", new DateTime(2024, 6, 21, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(6833), 1, 5 },
                    { 6, "Loved the penguin show!", new DateTime(2024, 6, 19, 12, 54, 18, 676, DateTimeKind.Local).AddTicks(6838), 0, 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ca2ffd4-d6aa-42bf-a48f-11b8e3844c20", "AQAAAAIAAYagAAAAEGy/QMLtgipXMucBoESGN/JCkVafUZOMhCuW/3FROfIt83vH6RJSl0UoZYl3Ph0Ksg==", "c00a055d-eef0-46b7-b66a-1de32e6b92a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49fcf8f4-1443-430e-b910-42320dc38b09", "AQAAAAIAAYagAAAAEFk9F03uct5XpEDd1ve0BrWYICasVJGE9TA7Fn9gc+pRm1IyYZPOfdbuCVn3iD7D8w==", "dcffbca4-8002-4c3a-88af-58254de7345a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7d7ef44-f64d-4f66-b572-9bc8bc16d0bb", "AQAAAAIAAYagAAAAEJdHkWARtQTpxj+ATGpZGL89U7HPVNLvETw4/H6Av8dO+gLhQ/5Vl8Xaff7JtLjZIQ==", "0dca16ac-bb5d-47f2-955f-21303650877c" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 23, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 6, 2, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 28, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 6, 7, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 25, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 6, 12, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 7, 2, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 7, 9, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 7, 17, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 22, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 8, 1, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7562));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 20, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 21, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 19, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 18, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 17, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 16, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 15, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 14, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 13, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 12, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7991));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 11, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 10, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 9, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 8, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 7, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 6, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(8004));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 5, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(8005));
        }
    }
}
