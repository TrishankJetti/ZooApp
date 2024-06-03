using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class ImagesforEventsTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Date", "ImageFileName" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(7371), "Guide.jpg" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "Date", "ImageFileName" },
                values: new object[] { new DateTime(2024, 6, 19, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(7422), "EducationalTalk.jpg" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "Date", "ImageFileName" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(7426), "ZooAfterDark.jpg" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                columns: new[] { "Date", "ImageFileName" },
                values: new object[] { new DateTime(2024, 7, 2, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(7428), "BirdTour.jpg" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                columns: new[] { "Date", "ImageFileName" },
                values: new object[] { new DateTime(2024, 7, 12, 15, 42, 46, 910, DateTimeKind.Local).AddTicks(7431), "AnimalDiet.jpg" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Date", "ImageFileName" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(816), "HI" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                columns: new[] { "Date", "ImageFileName" },
                values: new object[] { new DateTime(2024, 7, 2, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(818), "HI" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                columns: new[] { "Date", "ImageFileName" },
                values: new object[] { new DateTime(2024, 7, 12, 15, 29, 47, 500, DateTimeKind.Local).AddTicks(821), "HI" });

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
    }
}
