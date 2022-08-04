using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class IMadeAMistake3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Activities_ActivityId",
                table: "Comments");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Activities_ActivityId",
                table: "Comments",
                column: "ActivityId",
                principalTable: "Activities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Activities_ActivityId",
                table: "Comments");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Activities_ActivityId",
                table: "Comments",
                column: "ActivityId",
                principalTable: "Activities",
                principalColumn: "Id");
        }
    }
}
