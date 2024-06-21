using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class CommentsUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10);

            migrationBuilder.RenameColumn(
                name: "DateVisited",
                table: "VisitorLog",
                newName: "CreatedOn");

            migrationBuilder.AddColumn<int>(
                name: "Review",
                table: "VisitorLog",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Review",
                table: "VisitorLog");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "VisitorLog",
                newName: "DateVisited");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76f95c9b-0ec4-460f-909e-ec07da8b4e17", "AQAAAAIAAYagAAAAEEStRHAyk8Oiga+J0SNGzvcXhu4EV2LnLeBeqWwc1EFQdrSmj9itW2CNAX7ptpbFgg==", "37200a30-f1fb-42f4-ab58-75e9607eba01" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24305609-89a2-4c35-9350-cc0fc57a99e9", "AQAAAAIAAYagAAAAECobufMe//Z4WvE6s4ySjhOJ5TwKYRBdF5WlxLyZcMsj/3CKGAD+Aq+vj8GheTgv0w==", "08bf27a4-a06b-4121-8c8e-d26dbd1cd1fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e93d468-c60f-4eec-b27d-7c488dbb388e", "AQAAAAIAAYagAAAAEGwm1Ic2070WTHPygEYGaWOhb9vxObudAz9gAft0v4jEfTRrs/3J0bNeI4GsIiKU3g==", "32a691ea-c1e1-43f8-9708-8ef6de127ea9" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 18, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 5, 28, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 23, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 6, 2, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 20, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 6, 7, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 6, 27, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 7, 4, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 7, 12, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 17, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 27, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 15, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 16, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 14, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 13, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 12, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 11, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 10, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 9, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 8, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 7, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 6, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 5, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 4, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 3, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7575));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 2, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 1, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 31, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7581));

            migrationBuilder.InsertData(
                table: "VisitorLog",
                columns: new[] { "VisitorLogId", "Comments", "DateVisited", "VisitorId" },
                values: new object[,]
                {
                    { 1, "Enjoyed the zoo!", new DateTime(2024, 6, 15, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7747), 1 },
                    { 2, "Great experience!", new DateTime(2024, 6, 16, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7749), 2 },
                    { 3, "Had a wonderful time with family!", new DateTime(2024, 6, 14, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7751), 3 },
                    { 4, "Educational and fun!", new DateTime(2024, 6, 13, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7753), 4 },
                    { 5, "Loved the animal exhibits!", new DateTime(2024, 6, 12, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7755), 5 },
                    { 6, "Amazing zoo experience!", new DateTime(2024, 6, 11, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7757), 6 },
                    { 7, "Fantastic day out!", new DateTime(2024, 6, 10, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7759), 7 },
                    { 8, "Will visit again soon!", new DateTime(2024, 6, 9, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7761), 8 },
                    { 9, "Kids loved the animals!", new DateTime(2024, 6, 8, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7762), 9 },
                    { 10, "Highly recommended!", new DateTime(2024, 6, 7, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7764), 10 }
                });
        }
    }
}
