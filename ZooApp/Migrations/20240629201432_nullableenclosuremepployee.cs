using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class nullableenclosuremepployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Enclosure_EnclosureId",
                table: "Employee");

            migrationBuilder.AlterColumn<int>(
                name: "EnclosureId",
                table: "Employee",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98869e1a-334b-4726-9ee0-9a72f4e0bd1e", "AQAAAAIAAYagAAAAEN7srMyB7PbT6j7CiXSqYtzJAVrYenCMFm8pcMM0Y39Zk73CApegmTK06J4hApI7JA==", "f36278cb-95f2-4528-85f5-c0c5c5d1493c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8729859a-156c-4855-a9ca-b19917cc1e75", "AQAAAAIAAYagAAAAEAioXsT6zdHYywQp26vQiCdfotBFsfsFbkmqQfNEl4RUR28m/1idMrCftrHON5fUSg==", "199b2e56-8b30-4474-bb5c-05fd34d1008e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14114b55-351c-447f-8160-21c355f7f618", "AQAAAAIAAYagAAAAEPnKjk7hJiUXmjjNOVEdnIzSwNG9+Ih4EaTb3tWDiijj8rPXaDXtB7N57eYl5V2R9w==", "71d94343-6da0-43bf-b49a-5e2005ef20d1" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 31, 8, 14, 31, 944, DateTimeKind.Local).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 6, 10, 8, 14, 31, 944, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 6, 5, 8, 14, 31, 944, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 6, 15, 8, 14, 31, 944, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 6, 2, 8, 14, 31, 944, DateTimeKind.Local).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 6, 20, 8, 14, 31, 944, DateTimeKind.Local).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 9, 27, 8, 14, 31, 944, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 11, 9, 8, 14, 31, 944, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 9, 28, 8, 14, 31, 944, DateTimeKind.Local).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 1, 26, 8, 14, 31, 944, DateTimeKind.Local).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 10, 6, 8, 14, 31, 944, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 28, 8, 14, 31, 944, DateTimeKind.Local).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 29, 8, 14, 31, 944, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 27, 8, 14, 31, 944, DateTimeKind.Local).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 26, 8, 14, 31, 944, DateTimeKind.Local).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 25, 8, 14, 31, 944, DateTimeKind.Local).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 24, 8, 14, 31, 944, DateTimeKind.Local).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 23, 8, 14, 31, 944, DateTimeKind.Local).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 22, 8, 14, 31, 944, DateTimeKind.Local).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 21, 8, 14, 31, 944, DateTimeKind.Local).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 20, 8, 14, 31, 944, DateTimeKind.Local).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 19, 8, 14, 31, 944, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 18, 8, 14, 31, 944, DateTimeKind.Local).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 17, 8, 14, 31, 944, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 16, 8, 14, 31, 944, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 15, 8, 14, 31, 944, DateTimeKind.Local).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 14, 8, 14, 31, 944, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 13, 8, 14, 31, 944, DateTimeKind.Local).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 23, 8, 14, 31, 944, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 25, 8, 14, 31, 944, DateTimeKind.Local).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 27, 8, 14, 31, 944, DateTimeKind.Local).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 29, 8, 14, 31, 944, DateTimeKind.Local).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 28, 8, 14, 31, 944, DateTimeKind.Local).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 26, 8, 14, 31, 944, DateTimeKind.Local).AddTicks(7893));

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Enclosure_EnclosureId",
                table: "Employee",
                column: "EnclosureId",
                principalTable: "Enclosure",
                principalColumn: "EnclosureId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Enclosure_EnclosureId",
                table: "Employee");

            migrationBuilder.AlterColumn<int>(
                name: "EnclosureId",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07a47c43-1947-4382-93c2-de08186d0cfb", "AQAAAAIAAYagAAAAEBG977AUab4JxcNF4xCVVMuUXOBo7ycygskQx/mr2TS71LHI3qsF1RnVlReaE6axdA==", "6d24e9fd-32e2-46c7-9f5f-b6fc02e01a4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "837c8889-eb3b-4c00-ad2a-58ab2b407492", "AQAAAAIAAYagAAAAELYxm3wutd8YhCy4Ryym6HvZqXWufBI2CjW/358H3WCgA0FRHdXMNwYS48kQ7HZtsQ==", "44404b72-f6a0-45e6-aabc-5a80f978fc7d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3bf71e78-2554-4d08-98fb-c1be0566084e", "AQAAAAIAAYagAAAAELqg9Ph7SVj4aeHim35nMWbfwI0aoB2EhWhD1RgnFgwS3iP+Hzx9IU0ArS+kug+kVQ==", "c3b82911-933a-4cdf-82f3-403415bdb556" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 27, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 6, 6, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 6, 1, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 6, 11, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 29, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 6, 16, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 9, 23, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 11, 5, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 9, 24, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 1, 22, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2145));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 10, 2, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 24, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 25, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 23, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2787));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 22, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 21, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 20, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 19, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2808));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 18, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 17, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 16, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 15, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2865));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 14, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 13, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 12, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 11, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 10, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 9, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(2895));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 19, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 21, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 23, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 25, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 24, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 22, 23, 34, 1, 59, DateTimeKind.Local).AddTicks(3204));

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Enclosure_EnclosureId",
                table: "Employee",
                column: "EnclosureId",
                principalTable: "Enclosure",
                principalColumn: "EnclosureId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
