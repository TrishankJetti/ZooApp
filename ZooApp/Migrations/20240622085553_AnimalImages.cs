using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class AnimalImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageFileName",
                table: "Animal",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 1,
                column: "ImageFileName",
                value: "Lion.jpg");

            migrationBuilder.UpdateData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 2,
                column: "ImageFileName",
                value: "Elephant.jpg");

            migrationBuilder.UpdateData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 3,
                column: "ImageFileName",
                value: "Parrot.jpg");

            migrationBuilder.UpdateData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 4,
                column: "ImageFileName",
                value: "Tiger.jpg");

            migrationBuilder.UpdateData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 5,
                column: "ImageFileName",
                value: "Gorilla.jpg");

            migrationBuilder.UpdateData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 6,
                column: "ImageFileName",
                value: "Penguin.jpg");

            migrationBuilder.UpdateData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 7,
                column: "ImageFileName",
                value: "Kangaroo.jpg");

            migrationBuilder.UpdateData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 8,
                column: "ImageFileName",
                value: "Crocodile.jpg");

            migrationBuilder.UpdateData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 9,
                column: "ImageFileName",
                value: "Zebra.jpg");

            migrationBuilder.UpdateData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 10,
                column: "ImageFileName",
                value: "Panda.jpg");

            migrationBuilder.UpdateData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 11,
                column: "ImageFileName",
                value: "Giraffe.jpg");

            migrationBuilder.UpdateData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 12,
                column: "ImageFileName",
                value: "Lemur.jpg");

            migrationBuilder.UpdateData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 13,
                column: "ImageFileName",
                value: "PolarBear.jpg");

            migrationBuilder.UpdateData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 14,
                column: "ImageFileName",
                value: "Hippo.jpg");

            migrationBuilder.UpdateData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 15,
                column: "ImageFileName",
                value: "Sloth.jpg");

            migrationBuilder.UpdateData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 16,
                column: "ImageFileName",
                value: "Wolf.jpg");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ca2ffd4-d6aa-42bf-a48f-11b8e3844c20", "AQAAAAIAAYagAAAAEGy/QMLtgipXMucBoESGN/JCkVafUZOMhCuW/3FROfIt83vH6RJSl0UoZYl3Ph0Ksg==", "c00a055d-eef0-46b7-b66a-1de32e6b92a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49fcf8f4-1443-430e-b910-42320dc38b09", "AQAAAAIAAYagAAAAEFk9F03uct5XpEDd1ve0BrWYICasVJGE9TA7Fn9gc+pRm1IyYZPOfdbuCVn3iD7D8w==", "dcffbca4-8002-4c3a-88af-58254de7345a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7d7ef44-f64d-4f66-b572-9bc8bc16d0bb", "AQAAAAIAAYagAAAAEJdHkWARtQTpxj+ATGpZGL89U7HPVNLvETw4/H6Av8dO+gLhQ/5Vl8Xaff7JtLjZIQ==", "0dca16ac-bb5d-47f2-955f-21303650877c" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 23, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 6, 2, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 28, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 6, 7, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 25, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 6, 12, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 7, 2, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 7, 9, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 7, 17, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 22, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 8, 1, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7562));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 20, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 21, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 19, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 18, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 17, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 16, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 15, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 14, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 13, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 12, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7991));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 11, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 10, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 9, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 8, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 7, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 6, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(8004));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 5, 20, 55, 52, 83, DateTimeKind.Local).AddTicks(8005));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageFileName",
                table: "Animal");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98afd960-38ee-4c6f-b057-596d0f9e940a", "AQAAAAIAAYagAAAAENGDJrfJu9X0X6s3s4UU4vzwSSwlWmZuOXUCE7tE6hrMyT9gXKRy/ypn6ey4rIAHAg==", "9d808b0a-4556-4526-b626-9fd6995ef09a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62225784-cf8f-4a08-ab63-0306b0f11323", "AQAAAAIAAYagAAAAEAdCkfCjSp752Qw/G1L5GY/gOiM3UGHGQG65jo4luV+mnz3bGh4yhyskiCRVsr/BQQ==", "1c3791ea-5450-4a61-840c-83e54260d14d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a719f82-eef0-4c7f-9a8d-e32420ee4613", "AQAAAAIAAYagAAAAEIo2qJv6cH6hFdNKZvBYv9OYOnsTvDyiJYO9MJVvpbYX1UVpdHgW6JocZOsRjpYSLQ==", "f5e55bf1-0548-49e1-96d6-a7ee65be8a2b" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 5, 22, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 6, 1, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 5, 27, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 6, 6, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3113));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 5, 24, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 6, 11, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 7, 1, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 7, 8, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 7, 16, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 21, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 31, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 19, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 20, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 18, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 17, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 16, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 15, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 14, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 13, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 12, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 11, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 10, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 9, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 8, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 7, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 6, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 5, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "DateOfPurchase",
                value: new DateTime(2024, 6, 4, 19, 13, 21, 391, DateTimeKind.Local).AddTicks(3399));
        }
    }
}
