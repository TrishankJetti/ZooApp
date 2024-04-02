using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooApp.Migrations
{
    /// <inheritdoc />
    public partial class ticetupadted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisitorEventAttendance_Event_EventId",
                table: "VisitorEventAttendance");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitorEventAttendance_Visitor_VisitorId1",
                table: "VisitorEventAttendance");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VisitorEventAttendance",
                table: "VisitorEventAttendance");

            migrationBuilder.RenameTable(
                name: "VisitorEventAttendance",
                newName: "VisitorAttendance");

            migrationBuilder.RenameIndex(
                name: "IX_VisitorEventAttendance_VisitorId1",
                table: "VisitorAttendance",
                newName: "IX_VisitorAttendance_VisitorId1");

            migrationBuilder.RenameIndex(
                name: "IX_VisitorEventAttendance_EventId",
                table: "VisitorAttendance",
                newName: "IX_VisitorAttendance_EventId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VisitorAttendance",
                table: "VisitorAttendance",
                column: "VisitorId");

            migrationBuilder.AddForeignKey(
                name: "FK_VisitorAttendance_Event_EventId",
                table: "VisitorAttendance",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitorAttendance_Visitor_VisitorId1",
                table: "VisitorAttendance",
                column: "VisitorId1",
                principalTable: "Visitor",
                principalColumn: "VisitorId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisitorAttendance_Event_EventId",
                table: "VisitorAttendance");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitorAttendance_Visitor_VisitorId1",
                table: "VisitorAttendance");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VisitorAttendance",
                table: "VisitorAttendance");

            migrationBuilder.RenameTable(
                name: "VisitorAttendance",
                newName: "VisitorEventAttendance");

            migrationBuilder.RenameIndex(
                name: "IX_VisitorAttendance_VisitorId1",
                table: "VisitorEventAttendance",
                newName: "IX_VisitorEventAttendance_VisitorId1");

            migrationBuilder.RenameIndex(
                name: "IX_VisitorAttendance_EventId",
                table: "VisitorEventAttendance",
                newName: "IX_VisitorEventAttendance_EventId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VisitorEventAttendance",
                table: "VisitorEventAttendance",
                column: "VisitorId");

            migrationBuilder.AddForeignKey(
                name: "FK_VisitorEventAttendance_Event_EventId",
                table: "VisitorEventAttendance",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitorEventAttendance_Visitor_VisitorId1",
                table: "VisitorEventAttendance",
                column: "VisitorId1",
                principalTable: "Visitor",
                principalColumn: "VisitorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
