using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class ImagesforEventsTest2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a5e5836-2cd6-41b9-934a-992aad00f9f7", "AQAAAAIAAYagAAAAEPxfrLTtSw1p0ZbgB/Xm3QD/fA5INWUhQjNq2YT2A+G6+OgK1r+LuSCLHo3o09cdPg==", "2abcc664-c690-4432-a1df-fd18e59ceca3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb2f7323-d83e-480f-80d5-1823600ed1c9", "AQAAAAIAAYagAAAAEI2CdPsjHgx6Z8nGeqWoWjGSD/kZRRPfd7WpS4kUs0NHQu00XqpRlueXDMVCdDVcBw==", "dd610c85-2a4f-49c1-803f-2255c13ac2ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a260ebbe-cb13-46c7-89f5-fd584dc75ca3", "AQAAAAIAAYagAAAAEP+vi4K/ZHT1fH2KOwJaxhQWGNH5jSgmV7m2gSBkyhlvzaKNqM8qccBnfkGtbWdouQ==", "32ad28ab-9a4b-4f3b-84d5-fea94694d540" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 3, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 5, 13, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 8, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 5, 18, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 5, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 5, 23, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 6, 12, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 6, 19, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 6, 27, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 2, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 12, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 31, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 1, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 30, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 29, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 28, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 27, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 26, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 25, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 24, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 23, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 22, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 21, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 20, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 19, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 18, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 17, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 16, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 5, 31, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 6, 1, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 5, 30, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 5, 29, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 5, 28, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 5, 27, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 5, 26, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 5, 25, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 5, 24, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 5, 23, 15, 46, 41, 76, DateTimeKind.Local).AddTicks(7475));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abd292a3-3fc1-4e7e-b304-c6a2457253e4", "AQAAAAIAAYagAAAAEFPC9kTAk2DPqbgvlVLlF04wsCwE0J3iW0n/gW434+IG0xfQegmxOExXv/CI7FpPmA==", "4c0432e4-8eb4-4ffe-8c45-af217d0fcacc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f25b2252-cc58-4923-9f98-ab8a526c028e", "AQAAAAIAAYagAAAAENcgh3V4Y+6cTZCFvwCOVXLd7EuoZv12fJhMjR/gvgl5K3XzXr77W9TAc6+hczA8Cg==", "fd039ca4-72e7-4f62-a3ec-d4d139d85869" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c09b7aa4-5174-4c39-b54e-dbce28de0c8a", "AQAAAAIAAYagAAAAEFx9fBaiLAjZ1JsY2KZrgYkH04ss2OWAE1xGjVbyyOnlemwzPq7w5c4ZRj1pawbTwA==", "856e53c8-b8e2-42b3-accf-93722d9ff276" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 3, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 5, 13, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 8, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 5, 18, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 5, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 5, 23, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 6, 12, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 6, 19, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 6, 27, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 2, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 12, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 31, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 1, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 30, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 29, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 28, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 27, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 26, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 25, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 24, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 23, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 22, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 21, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 20, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 19, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 18, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 17, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 16, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 5, 31, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(8028));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 6, 1, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 5, 30, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 5, 29, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 5, 28, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 5, 27, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 5, 26, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 5, 25, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 5, 24, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 5, 23, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(8088));
        }
    }
}
