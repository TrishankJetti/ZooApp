using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class NullEnclosure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animal_Enclosure_EnclosureId",
                table: "Animal");

            migrationBuilder.AlterColumn<int>(
                name: "EnclosureId",
                table: "Animal",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51f86906-9e82-403e-b033-db074bce8557", "AQAAAAIAAYagAAAAEFaKaDJXQyYmx6cwkeY7i4037i9efLHpjMiy4UAawlxXKsnp1ENzXGMslj6YCClXZA==", "da51a12c-f843-495f-9fad-d3e71b5a3c87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a749b8a-775c-4a9e-a6ba-286b14fafefc", "AQAAAAIAAYagAAAAELzh7+8/iGMq/1pn2o5323/+psH4SKIddgsWiixrwhMhwz5PGcUn4S9DEv226U6OiA==", "7012d7fe-8cf9-4401-aa17-9a83fb3a7952" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6288a7f0-790a-42fc-afee-b8a37425fed6", "AQAAAAIAAYagAAAAEEIpn/2V2ygwpfXeU2Bl4n/vYI/5cOy2xqbUc1o79QOixYCjsBDUsqZdU9FvpTwqRw==", "36828a91-6aea-47ea-a900-02e5b10371cd" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 6, 5, 12, 15, 51, 859, DateTimeKind.Local).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 6, 15, 12, 15, 51, 859, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 6, 10, 12, 15, 51, 859, DateTimeKind.Local).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 6, 20, 12, 15, 51, 859, DateTimeKind.Local).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 6, 7, 12, 15, 51, 859, DateTimeKind.Local).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 6, 25, 12, 15, 51, 859, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 10, 2, 12, 15, 51, 859, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 11, 14, 12, 15, 51, 859, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 10, 3, 12, 15, 51, 859, DateTimeKind.Local).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 1, 31, 12, 15, 51, 859, DateTimeKind.Local).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 10, 11, 12, 15, 51, 859, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 7, 3, 12, 15, 51, 859, DateTimeKind.Local).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 7, 4, 12, 15, 51, 859, DateTimeKind.Local).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 7, 2, 12, 15, 51, 859, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 7, 1, 12, 15, 51, 859, DateTimeKind.Local).AddTicks(1425));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 30, 12, 15, 51, 859, DateTimeKind.Local).AddTicks(1429));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 29, 12, 15, 51, 859, DateTimeKind.Local).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 28, 12, 15, 51, 859, DateTimeKind.Local).AddTicks(1436));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 27, 12, 15, 51, 859, DateTimeKind.Local).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 26, 12, 15, 51, 859, DateTimeKind.Local).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 25, 12, 15, 51, 859, DateTimeKind.Local).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 24, 12, 15, 51, 859, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 23, 12, 15, 51, 859, DateTimeKind.Local).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 22, 12, 15, 51, 859, DateTimeKind.Local).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 21, 12, 15, 51, 859, DateTimeKind.Local).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 20, 12, 15, 51, 859, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 19, 12, 15, 51, 859, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 18, 12, 15, 51, 859, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 28, 12, 15, 51, 859, DateTimeKind.Local).AddTicks(1773));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 30, 12, 15, 51, 859, DateTimeKind.Local).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 7, 2, 12, 15, 51, 859, DateTimeKind.Local).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 7, 4, 12, 15, 51, 859, DateTimeKind.Local).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 7, 3, 12, 15, 51, 859, DateTimeKind.Local).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 7, 1, 12, 15, 51, 859, DateTimeKind.Local).AddTicks(1798));

            migrationBuilder.AddForeignKey(
                name: "FK_Animal_Enclosure_EnclosureId",
                table: "Animal",
                column: "EnclosureId",
                principalTable: "Enclosure",
                principalColumn: "EnclosureId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animal_Enclosure_EnclosureId",
                table: "Animal");

            migrationBuilder.AlterColumn<int>(
                name: "EnclosureId",
                table: "Animal",
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
                name: "FK_Animal_Enclosure_EnclosureId",
                table: "Animal",
                column: "EnclosureId",
                principalTable: "Enclosure",
                principalColumn: "EnclosureId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
