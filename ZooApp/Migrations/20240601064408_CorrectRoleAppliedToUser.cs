using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class CorrectRoleAppliedToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "3" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "3" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "3" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2", "3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6cf821e-e9b8-4ad0-9d08-34017027ad87", "AQAAAAIAAYagAAAAEOMSx5Lx32/Rluz0gYFR1gpr13vdJdT5z/jEY8vstUXHSPWZslwU2oBpDlnCCczZlA==", "05064542-d6a8-4a5b-9d56-7d5b1ff877d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eea20c2e-82d4-46db-9a56-b273b6193083", "AQAAAAIAAYagAAAAEHQp3aVNSU2svjboeId97z9HF7dgqRgOiu9HnLbNvYgCvRO3Dq4nunx0z/sNz6O7lA==", "1848f713-34f0-4e18-97f1-f03af2832231" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2777944-cf34-4c08-a903-411cdf8f713c", "AQAAAAIAAYagAAAAEOBPGAEqr/9tNuPo2t9+FRGq2lS0UqF/g3uktMjcx3mmlkD+MfPyDiY/mw6tZZr6bQ==", "c037bb9f-47c6-416b-b8b2-f78a8e8ea75a" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 2, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 5, 12, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 7, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 5, 17, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(582));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 4, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 5, 22, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 6, 11, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 6, 18, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 6, 26, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 1, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 11, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 30, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 31, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 29, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 28, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 27, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 26, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 25, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 24, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 23, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 22, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 21, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 20, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 19, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 18, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 17, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 16, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 15, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 5, 30, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 5, 31, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 5, 29, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 5, 28, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 5, 27, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 5, 26, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 5, 25, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 5, 24, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 5, 23, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 5, 22, 18, 41, 13, 598, DateTimeKind.Local).AddTicks(934));
        }
    }
}
