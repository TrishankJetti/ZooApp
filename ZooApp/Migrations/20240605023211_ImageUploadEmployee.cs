using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class ImageUploadEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageFileName",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69b17988-93ba-4218-b27f-f46d985f5d1d", "AQAAAAIAAYagAAAAEIlgnv3YoJETZt6sJd+ZELIPJo5IeGAcTTLxAjFDxsHecmqUqap2tTfwh6wNWxt+pw==", "6187b998-25ca-45b8-af28-27a5b23a3596" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0f4a426-4b21-4156-a3ca-63de399b4b0d", "AQAAAAIAAYagAAAAEOLpb0ScPLCrxQP4m1BWdnGPxJQdsOQXUtOMHkt6mXJpAmlQtjmcsLHL97ITet38jg==", "a1166a0a-948a-49af-8206-c9262b3e279b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32e750fe-6dc5-44db-8d4b-ba5e9910f3f6", "AQAAAAIAAYagAAAAELj3WEqdeTgedms1QrdI47k2mhl8mY24q8Uxj6pgaxXIbRatkuJi7RjlA+Z6zY43FA==", "037030f3-984d-41ec-aa9c-dd11e3fb1d01" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "HireDate", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(4006), "Rob.jpg" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "HireDate", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 16, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(4019), "Rob.jpg" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "HireDate", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 11, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(4023), "Rob.jpg" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "HireDate", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 21, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(4033), "Rob.jpg" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "HireDate", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 8, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(4036), "Rob.jpg" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "HireDate", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 26, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(4047), "Rob.jpg" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 6, 15, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 6, 22, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 6, 30, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 5, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 15, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 3, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 4, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 2, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 1, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 31, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 30, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 29, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 28, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 27, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 26, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 25, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(4482));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 24, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 23, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 22, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 21, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 20, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 19, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 6, 3, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 6, 4, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 6, 2, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 6, 1, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 5, 31, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 5, 30, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 5, 29, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 5, 28, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 5, 27, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 5, 26, 14, 32, 9, 551, DateTimeKind.Local).AddTicks(4809));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageFileName",
                table: "Employee");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8547db2f-7fd4-42c9-91a8-d254a3d56ab6", "AQAAAAIAAYagAAAAEE7VPjgLhrq3LUT/eVyX7zuImZZkjrjo2+v0Z994CPqEjfhlsmOM9FkuBk2HviTkLQ==", "f24c48fc-3386-4834-9d53-f450383d13e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02fb6d85-463b-49cd-a7cb-268540fb34b4", "AQAAAAIAAYagAAAAEA5EaMycJJz74+oz9UpE/267akNwiC71cg4GnOIqINMz8UwVD9yTzvLxeMIN5oU5eQ==", "551c101b-4c61-4d34-928a-c7b8ff512d75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e7c4727-c5f1-4af5-bb08-204f5d6f506f", "AQAAAAIAAYagAAAAEI+4N796hEPXhahv7xDr9G61+4fmhfjozKMMznu0SA6vTqjIHvqll44joWUNLVV49g==", "269d8351-af2d-4db8-b4a4-1cc4d406668c" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 3, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 5, 13, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 8, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 5, 18, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 5, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 5, 23, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 6, 12, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 6, 19, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(789));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 6, 27, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(792));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 2, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 12, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 31, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 1, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 30, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 29, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 28, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 27, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 26, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 25, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 24, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(1051));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 23, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 22, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 21, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 20, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 19, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 18, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 17, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 16, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 5, 31, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 6, 1, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 5, 30, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 5, 29, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 5, 28, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(1172));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 5, 27, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 5, 26, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 5, 25, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 5, 24, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 5, 23, 15, 48, 31, 337, DateTimeKind.Local).AddTicks(1182));
        }
    }
}
