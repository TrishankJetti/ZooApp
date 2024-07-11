using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class newLocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5e7b666-05c6-4251-9168-c1be743c1354", "AQAAAAIAAYagAAAAEAKVPHJq5ZarMVkelw1N66TGSDmTqwCPIs1hQ+zYabPGZ6bnsf8vPirn3MBFx3J8Tg==", "8fea3dbc-e4b2-467f-bc27-1536bb04c467" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a25e4a0-6557-4b06-9194-1f3cce6772a5", "AQAAAAIAAYagAAAAEDfxUKIlA9pjaQKlYaIL3xF9w4NGvejqcysmPtWEFf3yVaxDRkp4hokh+b6cvnnJYA==", "a11f634e-90fd-4c28-9c09-192673ddc07a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2399b791-a622-43b6-9284-2b157c19752c", "AQAAAAIAAYagAAAAEMvw2eP4+zhLg3q0h6Vs026oFHE6BvTAy6dmrPHyIMFC+HtOTYiMRQAzH3TSZUDsSQ==", "050d0d57-125d-4e7a-a8b4-a213c41fcb18" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 6, 9, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 6, 19, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 6, 14, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 6, 24, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 6, 11, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 6, 29, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 10, 6, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 11, 18, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 10, 7, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 2, 4, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1631));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 10, 15, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1633));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 7, 7, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 7, 8, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 7, 6, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1946));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 7, 5, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 7, 4, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 7, 3, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 7, 2, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 7, 1, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1958));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 30, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 29, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 28, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 27, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 26, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 25, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 24, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 23, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 22, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(1979));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 7, 2, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 7, 4, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 7, 6, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 7, 8, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 7, 7, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 7, 5, 15, 6, 30, 851, DateTimeKind.Local).AddTicks(2122));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
