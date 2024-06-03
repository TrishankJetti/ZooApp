using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedingIMagesTest1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d9855d8-5802-4aa1-964f-03da8fb0814a", "AQAAAAIAAYagAAAAENSanrY/X1Ryqhx2wRutu8cOHmCIiDn3SXl/UOdiBxUgtVNTn5Guji2cr4WNpoCnOQ==", "fe953cf1-2860-406c-a5e4-61bcb4b7276d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1dca6ca5-c237-421a-beaa-323737d03890", "AQAAAAIAAYagAAAAEPg2UaffUx7GMhpcIFqhP+taL0YaFlOeeesd50PIwBNTJfKWWpN7sNDttPU2xuBNRg==", "f655024c-a5f1-46e5-9bb5-d0ea6dff7e22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8dffb04-cd18-47ab-bf66-458dd191df42", "AQAAAAIAAYagAAAAECicd9yY5IEKQf4gjJp0ntma2hbkfu66SAcxUITTmCC/w173lrU4W4tWIfuA56aEkQ==", "3b96388a-5f1c-46f4-b368-5290c98d37f0" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 3, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 5, 13, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 8, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 5, 18, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(959));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 5, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(962));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 5, 23, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "Date", "ImageFileName" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(758), "Guide" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "Date", "ImageFileName" },
                values: new object[] { new DateTime(2024, 6, 19, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(813), "EducationalTalk" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 6, 27, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 2, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 12, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 31, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 1, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 30, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 29, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(1155));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 28, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(1167));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 27, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 26, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(1172));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 25, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 24, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 23, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 22, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 21, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 20, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 19, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 18, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 17, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 16, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 5, 31, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 6, 1, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(1411));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 5, 30, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 5, 29, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 5, 28, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 5, 27, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 5, 26, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 5, 25, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 5, 24, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 5, 23, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(1456));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9debad52-4835-42a3-b02d-4856ede72fdf", "AQAAAAIAAYagAAAAEAbDuOiw1fbbGvoXfayyS0t95V3xWz3hympr/O0Ejfi6KPFdG2MAfsFrtWSkqg0LVQ==", "633d7a63-7e14-4036-b94a-b0e1a19707e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8480559-0426-425e-8687-9dbd6fca522a", "AQAAAAIAAYagAAAAEOBA9WZ7qEdc3/GuVl8cwo7/J0iGMqOT81VworBL7ib/FBLmWN5CX3pvCuVeIb3XFQ==", "acf47a2c-d3fa-4486-ae6a-6f3f49044382" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8911c0e4-50dc-4154-a609-e608f664765f", "AQAAAAIAAYagAAAAEES3ELjr1UtjxRXzdTC9yE4ARASqP9ZOmqqoBsCwU3/mgva76SurF4u7il14UD+aDg==", "acec0cf8-eb29-4808-acda-94189dba68f8" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 3, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 5, 13, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 8, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 5, 18, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 5, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 5, 23, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "Date", "ImageFileName" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 21, 6, 159, DateTimeKind.Local).AddTicks(9916), "Guide.jpg" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "Date", "ImageFileName" },
                values: new object[] { new DateTime(2024, 6, 19, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(56), "HI" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 6, 27, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 2, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(62));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 12, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 31, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 1, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(291));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 30, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(293));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 29, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 28, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 27, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 26, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 25, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 24, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 23, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 22, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 21, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 20, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 19, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 18, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 17, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 5, 16, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 1,
                column: "DateVisited",
                value: new DateTime(2024, 5, 31, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 2,
                column: "DateVisited",
                value: new DateTime(2024, 6, 1, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 3,
                column: "DateVisited",
                value: new DateTime(2024, 5, 30, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 4,
                column: "DateVisited",
                value: new DateTime(2024, 5, 29, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 5,
                column: "DateVisited",
                value: new DateTime(2024, 5, 28, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 6,
                column: "DateVisited",
                value: new DateTime(2024, 5, 27, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 7,
                column: "DateVisited",
                value: new DateTime(2024, 5, 26, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 8,
                column: "DateVisited",
                value: new DateTime(2024, 5, 25, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 9,
                column: "DateVisited",
                value: new DateTime(2024, 5, 24, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "VisitorLog",
                keyColumn: "VisitorLogId",
                keyValue: 10,
                column: "DateVisited",
                value: new DateTime(2024, 5, 23, 15, 21, 6, 160, DateTimeKind.Local).AddTicks(509));
        }
    }
}
