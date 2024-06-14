using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class allownulls12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageFileName",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6e2ac78-b9cf-41d5-b7d7-8ef4cff4bce0", "AQAAAAIAAYagAAAAEKmMl6RtIS79MKQcURIIx8MZYA+joRrfsYQknSX/QU7F9ZSFGFlm8Vo92FmO5xMPHA==", "e359f933-22ff-42f3-b5a0-339f28df6eca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72b689bb-6d08-447a-bf90-55111ff099d7", "AQAAAAIAAYagAAAAEI+LkmOh86ios4fPMvfb4/v1gcncAB1uk4Gbc58vacoWOvEXlBxE5oGLblwRDzFi+w==", "d9900f72-f9cf-47dc-ae13-ddd16bd58994" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "634debd3-e9f6-4310-98cc-a1223f6b1955", "AQAAAAIAAYagAAAAELRvtpOy01Whpumtl3QTF68Wnhoa1VXiTG1uCqa2aB2zL12ZhOIkzboPdcIw/yl3NA==", "8f790de7-dcde-48c6-aeaf-f07c2dc31576" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 16, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 5, 26, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 21, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 5, 31, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 18, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 6, 5, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 6, 25, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 7, 2, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 7, 10, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 15, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 25, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 13, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 14, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 12, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 11, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 10, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 9, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 8, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1564));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 7, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 6, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 5, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 4, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 3, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 2, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 1, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 31, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1581));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 30, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1583));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 29, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1585));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 6, 13, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 6, 14, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 6, 12, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 6, 11, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 6, 10, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 6, 9, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 6, 8, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 6, 7, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 6, 6, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 6, 5, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1726));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageFileName",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d366ac41-144d-4faf-8202-aed2f3620b64", "AQAAAAIAAYagAAAAEG8XsPvB2+oOzIeqrVqZZ24CUS+0/zhiKIla8gPA5w16hBVfNiYrYVKbch2dL8p4nw==", "274c19a5-1f87-4808-bc63-09ff41a20801" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90485a49-5c80-41f0-88c9-6bda4432f98f", "AQAAAAIAAYagAAAAEGK7VBWoafGGlN/fk9BGb7bYazoHhLQMNUmsrz5vZqVpjbbUJJIfkgPY4O5lWXYypg==", "a63f0893-a012-4172-a4cc-816fc793599e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dcd75ed0-695e-4c33-968e-24007deea45c", "AQAAAAIAAYagAAAAEPDR0yhZMlsQ1k2br/ZCC82SI4BbBaU46r33UcqwVxKlIlHuyLL/g09HLPLrv9EUrA==", "51906ab7-f1b0-47ba-b4b9-828384032afc" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 16, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 5, 26, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 21, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 5, 31, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 18, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 6, 5, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 6, 25, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 7, 2, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 7, 10, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 15, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 25, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 13, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 14, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 12, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 11, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 10, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 9, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 8, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 7, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 6, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 5, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 4, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 3, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 2, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 1, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 31, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 30, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 29, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 6, 13, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 6, 14, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 6, 12, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 6, 11, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 6, 10, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 6, 9, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 6, 8, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 6, 7, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 6, 6, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 6, 5, 9, 37, 41, 301, DateTimeKind.Local).AddTicks(6647));
        }
    }
}
