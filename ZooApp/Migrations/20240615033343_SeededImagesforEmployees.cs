using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class SeededImagesforEmployees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "363222d3-3db1-44bf-9c2b-4719ed74336b", "AQAAAAIAAYagAAAAECJaINIbjNO6tCjunpibZmRERFbCY2auu0Oe0vqUy34rMVJN8/3nAZ8sH34nqSWWVg==", "2b116b80-6677-4b74-b998-b139e3f6b93a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2df8e25-8689-4f63-b778-baeb271917c2", "AQAAAAIAAYagAAAAEOH3B9IyUje83K7UpDpdaaZnjBkOqFVePjcrG8OxIsMW43XyMKQc2r1vDHgwAPh2UQ==", "f2f325a1-67f4-4c10-9176-37294e296546" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca2e0497-4c15-4425-b68a-1695a6c9a065", "AQAAAAIAAYagAAAAEO3QuaKyr1psD96AbcAZWhWwloAU9T/NPPXOaPDxZ1CGHK/rmmsIQT8mr7FO5tyCzg==", "890e8946-fee9-4df7-b61e-3908bc457efd" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "HireDate", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 16, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(3972), "JohnDoe.jpg" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "HireDate", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 26, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(3990), "JaneSmith.jpg" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "HireDate", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(3997), "MichaelJohnson.jpg" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "HireDate", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 31, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4007), "EmilyWilson.jpg" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "HireDate", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 18, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4014), "ChristopherLee.jpg" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "HireDate", "ImageFileName" },
                values: new object[] { new DateTime(2024, 6, 5, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4026), "JessicaBrown.jpg" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 6, 25, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 7, 2, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 7, 10, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 15, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 25, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 13, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 14, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 12, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 11, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 10, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 9, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 8, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 7, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 6, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 5, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 4, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 3, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 2, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 1, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 31, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 30, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 29, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 6, 13, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 6, 14, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 6, 12, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 6, 11, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 6, 10, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 6, 9, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 6, 8, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 6, 7, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 6, 6, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 6, 5, 15, 33, 42, 565, DateTimeKind.Local).AddTicks(4944));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "HireDate", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1283), "Rob.jpg" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "HireDate", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1287), "Rob.jpg" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "HireDate", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 21, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1290), "Rob.jpg" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "HireDate", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 31, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1294), "Rob.jpg" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "HireDate", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 18, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1296), "Rob.jpg" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "HireDate", "ImageFileName" },
                values: new object[] { new DateTime(2024, 6, 5, 9, 40, 3, 675, DateTimeKind.Local).AddTicks(1299), "Rob.jpg" });

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
    }
}
