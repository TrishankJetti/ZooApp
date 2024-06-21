using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeCanBeNUll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 6, 15, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 6, 16, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 6, 14, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 6, 13, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 6, 12, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 6, 11, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 6, 10, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 6, 9, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 6, 8, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 6, 7, 19, 43, 42, 335, DateTimeKind.Local).AddTicks(7764));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2afdd56-09d7-4b1e-b625-589d6bc3db75", "AQAAAAIAAYagAAAAEC8TAGV/LeQkbHjv/9/BE+sKdxx/ZxhRnwU0rQz/gQ0UegTdwo4aAmXXQ72HL9xHJg==", "30406295-b1a8-495c-b1b9-a2869947643f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19866732-66a8-49b2-8b29-b5684da47f90", "AQAAAAIAAYagAAAAEEmE79RElXIxMX8nV2r91y7KijV+d8qvgbEHLfMpGMWXCHcNyj3o1lXNyCuuz9E0kQ==", "3515cdc3-8be9-4775-a06a-5a769080dbad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c47ee7ce-b583-411c-b922-503b8632aeb6", "AQAAAAIAAYagAAAAEFxMCSKo97R6ZIEpJZfRP2ciLj0VzHOH+CEhrIIXlq1hjoUjkSkQiNijF432Y/RPJg==", "c725f04d-1f32-4ea2-b28c-d3d7f79fcc6a" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 18, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1098));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 5, 28, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 23, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 6, 2, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 20, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 6, 7, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 6, 27, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 7, 4, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 7, 12, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 17, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 27, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 15, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 16, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 14, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 13, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 12, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 11, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 10, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 9, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1411));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 8, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 7, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 6, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 5, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 4, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 3, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1422));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 2, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1424));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 1, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 31, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 6, 15, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 6, 16, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 6, 14, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 6, 13, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 6, 12, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 6, 11, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 6, 10, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 6, 9, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 6, 8, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 6, 7, 19, 41, 8, 957, DateTimeKind.Local).AddTicks(1558));
        }
    }
}
