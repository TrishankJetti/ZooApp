using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class IMages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageName",
                table: "Event",
                newName: "ImageFileName");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 4, 29, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 5, 9, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 4, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 5, 14, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 1, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(7823));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 5, 19, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "EventId", "Date", "Description", "ImageFileName", "Name", "TicketPrice" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 8, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(7643), "Guided safari tour through the zoo", "HI", "Zoo Safari", 25m },
                    { 2, new DateTime(2024, 6, 15, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(7688), "Educational talk on wildlife conservation", "HI", "Wildlife Conservation Talk", 10m },
                    { 3, new DateTime(2024, 6, 23, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(7691), "Experience the zoo after dark with special activities and tours", "HI", "Night at the Zoo", 30m },
                    { 4, new DateTime(2024, 6, 28, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(7693), "Guided tour focusing on observing various bird species in the zoo", "HI", "Bird Watching Tour", 15m },
                    { 5, new DateTime(2024, 7, 8, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(7695), "Learn about animal diets and behavior during feeding time", "HI", "Animal Feeding Demonstration", 20m }
                });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 27, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 28, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 26, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 25, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 24, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 23, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 22, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 21, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 20, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 19, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 18, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 17, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 16, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 15, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 14, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(8004));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 13, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 12, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 5, 27, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 5, 28, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 5, 26, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 5, 25, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 5, 24, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 5, 23, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 5, 22, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 5, 21, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 5, 20, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 5, 19, 16, 53, 36, 572, DateTimeKind.Local).AddTicks(8135));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5);

            migrationBuilder.RenameColumn(
                name: "ImageFileName",
                table: "Event",
                newName: "ImageName");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 4, 28, 9, 50, 16, 30, DateTimeKind.Local).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 5, 8, 9, 50, 16, 30, DateTimeKind.Local).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 3, 9, 50, 16, 30, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 5, 13, 9, 50, 16, 30, DateTimeKind.Local).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 4, 30, 9, 50, 16, 30, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 5, 18, 9, 50, 16, 30, DateTimeKind.Local).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 26, 9, 50, 16, 30, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 27, 9, 50, 16, 30, DateTimeKind.Local).AddTicks(9765));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 25, 9, 50, 16, 30, DateTimeKind.Local).AddTicks(9768));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 24, 9, 50, 16, 30, DateTimeKind.Local).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 23, 9, 50, 16, 30, DateTimeKind.Local).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 22, 9, 50, 16, 30, DateTimeKind.Local).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 21, 9, 50, 16, 30, DateTimeKind.Local).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 20, 9, 50, 16, 30, DateTimeKind.Local).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 19, 9, 50, 16, 30, DateTimeKind.Local).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 18, 9, 50, 16, 30, DateTimeKind.Local).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 17, 9, 50, 16, 30, DateTimeKind.Local).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 16, 9, 50, 16, 30, DateTimeKind.Local).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 15, 9, 50, 16, 30, DateTimeKind.Local).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 14, 9, 50, 16, 30, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 13, 9, 50, 16, 30, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 12, 9, 50, 16, 30, DateTimeKind.Local).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 11, 9, 50, 16, 30, DateTimeKind.Local).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 5, 26, 9, 50, 16, 30, DateTimeKind.Local).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 5, 27, 9, 50, 16, 30, DateTimeKind.Local).AddTicks(9991));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 5, 25, 9, 50, 16, 30, DateTimeKind.Local).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 5, 24, 9, 50, 16, 30, DateTimeKind.Local).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 5, 23, 9, 50, 16, 31, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 5, 22, 9, 50, 16, 31, DateTimeKind.Local).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 5, 21, 9, 50, 16, 31, DateTimeKind.Local).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 5, 20, 9, 50, 16, 31, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 5, 19, 9, 50, 16, 31, DateTimeKind.Local).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 5, 18, 9, 50, 16, 31, DateTimeKind.Local).AddTicks(14));
        }
    }
}
