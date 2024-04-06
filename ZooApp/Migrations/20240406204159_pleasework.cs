using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class pleasework : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.CreateTable(
                name: "VisitorEventAttendance",
                columns: table => new
                {
                    VisitorEventAttendanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitorId = table.Column<int>(type: "int", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitorEventAttendance", x => x.VisitorEventAttendanceId);
                    table.ForeignKey(
                        name: "FK_VisitorEventAttendance_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VisitorEventAttendance_Visitor_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "Visitor",
                        principalColumn: "VisitorId",
                        onDelete: ReferentialAction.Cascade);
                });




            migrationBuilder.InsertData(
                table: "Enclosure",
                columns: new[] { "EnclosureId", "Capacity", "Habitat", "Name" },
                values: new object[,]
                {
                    { 1, 5, "Savannah", "Lion Enclosure" },
                    { 2, 10, "Jungle", "Elephant Enclosure" }
                });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "EventId", "Date", "Description", "Name", "TicketPrice" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 17, 8, 41, 58, 729, DateTimeKind.Local).AddTicks(399), "Guided safari tour through the zoo", "Zoo Safari", 25m },
                    { 2, new DateTime(2024, 4, 24, 8, 41, 58, 729, DateTimeKind.Local).AddTicks(484), "Educational talk on wildlife conservation", "Wildlife Conservation Talk", 10m }
                });

            migrationBuilder.InsertData(
                table: "Visitor",
                columns: new[] { "VisitorId", "Address", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "123 Main St", "alice@example.com", "Alice", "123-456-7890" },
                    { 2, "456 Elm St", "bob@example.com", "Bob", "987-654-3210" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "EnclosureId", "HireDate", "Name", "Phone", "Role", "Salary" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 3, 8, 8, 41, 58, 729, DateTimeKind.Local).AddTicks(757), "John Doe", "123-456-7890", 0, 50000m },
                    { 2, 2, new DateTime(2024, 3, 18, 8, 41, 58, 729, DateTimeKind.Local).AddTicks(768), "Jane Smith", "987-654-3210", 1, 70000m }
                });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "TicketId", "DateOfPurchase", "EventId", "VisitorId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 5, 8, 41, 58, 729, DateTimeKind.Local).AddTicks(946), 1, 1 },
                    { 2, new DateTime(2024, 4, 6, 8, 41, 58, 729, DateTimeKind.Local).AddTicks(952), 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "VisitorEventAttendance",
                columns: new[] { "VisitorEventAttendanceId", "EventId", "VisitorId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "VisitorLog",
                columns: new[] { "VisitorLogId", "Comments", "DateVisited", "VisitorId" },
                values: new object[,]
                {
                    { 1, "Enjoyed the zoo!", new DateTime(2024, 4, 5, 8, 41, 58, 729, DateTimeKind.Local).AddTicks(1062), 1 },
                    { 2, "Great experience!", new DateTime(2024, 4, 6, 8, 41, 58, 729, DateTimeKind.Local).AddTicks(1068), 2 }
                });

            migrationBuilder.InsertData(
                table: "Animal",
                columns: new[] { "AnimalId", "Age", "Diet", "EmployeeId", "EnclosureId", "Name", "Sex", "Species" },
                values: new object[,]
                {
                    { 1, 5, 0, 1, 1, "Lion", 0, "Panthera leo" },
                    { 2, 10, 2, 2, 2, "Elephant", 1, "Loxodonta africana" }
                });

            migrationBuilder.InsertData(
                table: "AnimalEmployee",
                columns: new[] { "AnimalEmployeeId", "AnimalId", "EmployeeId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 }
                });

        }
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalEmployee");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "VisitorEventAttendance");

            migrationBuilder.DropTable(
                name: "VisitorLog");

            migrationBuilder.DropTable(
                name: "Animal");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Visitor");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Enclosure");
        }
    }
}
