using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class NullableEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea762019-b798-409d-9699-798461645194", "AQAAAAIAAYagAAAAEPYZhBoyT3pBAc2mLy2w/F/HCwdt22YfeQpRI5JStVT02M0t0MkRkFumez73zFXCqA==", "63daae09-1a66-4369-9ec8-70cc90a9029f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae9d7dae-a9c5-40fd-90e7-5a4933d8597d", "AQAAAAIAAYagAAAAEDUU0TsKqrLHxO9pryFsQGEkykmlTu54LPsgfOLCwI3Y2tJlGm2av43d6jxx0rEwnw==", "313188b4-7093-4fd4-9c89-ab70dc5063fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1838764d-03f6-4afd-a836-c15369e6ac68", "AQAAAAIAAYagAAAAEBnuCgrIyxiq/kv4hwZPJEE4ML7Ojn3lIO5jMlyoJiDCMaN0IzLSVog7TYVqrJnHHA==", "ffb8ffab-29cc-48c5-b039-b4dc5a03bd0c" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 2, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 5, 12, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 7, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 5, 17, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 4, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 5, 22, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 6, 11, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 6, 18, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 6, 26, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 1, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 11, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 30, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 31, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 29, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 28, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 27, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 26, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 25, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(4991));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 24, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 23, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 22, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 21, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 20, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 19, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 18, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 17, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 16, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 15, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 5, 30, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 5, 31, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 5, 29, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 5, 28, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(5255));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 5, 27, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 5, 26, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 5, 25, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(5261));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 5, 24, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(5263));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 5, 23, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 5, 22, 19, 8, 56, 676, DateTimeKind.Local).AddTicks(5267));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0ba6541-b5fa-4ad5-9076-435a01d01eb0", "AQAAAAIAAYagAAAAEIt7RHioVeiHMH2FOXae9jbc/X2ovzU9BiwfMAHvLsMkLAFmnkxNa3wqfHXBeZioYg==", "cfaa3d75-d757-4fc6-b817-b5c1264c0f91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2342a4d2-e933-43f8-98e4-e32ea003d354", "AQAAAAIAAYagAAAAEF7NBwrNshpAa/nDIRkkpUWKo7mIDrU0zCVBXXogpEQQNXuQen7xKI7dcD3rILLnKA==", "b2604b42-6735-4413-aa59-af08d30b2dc9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "299536ca-17a0-4174-b62c-869e17026489", "AQAAAAIAAYagAAAAEPDMyfF/Y07ANTef4WdvIXjRK3ivovjjhS7FJfDCAxmiEptynSQIiFDGdUPLcOs1Gg==", "708cb355-d8ea-407d-b56e-7fbcc0d01dfe" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 2, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 5, 12, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1162));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 7, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1165));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 5, 17, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 4, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 5, 22, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 6, 11, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 6, 18, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 6, 26, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 1, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 11, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 30, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 31, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 29, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 28, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1332));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 27, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 26, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 25, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 24, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 23, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 22, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 21, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 20, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 19, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 18, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 17, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1352));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 16, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 15, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1356));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 5, 30, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1495));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 5, 31, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 5, 29, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 5, 28, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 5, 27, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 5, 26, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 5, 25, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 5, 24, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 5, 23, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 5, 22, 18, 44, 7, 635, DateTimeKind.Local).AddTicks(1512));
        }
    }
}
