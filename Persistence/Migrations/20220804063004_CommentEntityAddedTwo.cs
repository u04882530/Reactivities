using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class CommentEntityAddedTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropForeignKey(
            //     name: "FK_Comments_AspNetUsers_MyPropertyAuthorId",
            //     table: "Comments");

            // migrationBuilder.RenameColumn(
            //     name: "MyPropertyAuthorId",
            //     table: "Comments",
            //     newName: "AuthorId");

            // migrationBuilder.RenameIndex(
            //     name: "IX_Comments_MyPropertyAuthorId",
            //     table: "Comments",
            //     newName: "IX_Comments_AuthorId");

            // migrationBuilder.AddForeignKey(
            //     name: "FK_Comments_AspNetUsers_AuthorId",
            //     table: "Comments",
            //     column: "AuthorId",
            //     principalTable: "AspNetUsers",
            //     principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropForeignKey(
            //     name: "FK_Comments_AspNetUsers_AuthorId",
            //     table: "Comments");

            // migrationBuilder.RenameColumn(
            //     name: "AuthorId",
            //     table: "Comments",
            //     newName: "MyPropertyAuthorId");

            // migrationBuilder.RenameIndex(
            //     name: "IX_Comments_AuthorId",
            //     table: "Comments",
            //     newName: "IX_Comments_MyPropertyAuthorId");

            // migrationBuilder.AddForeignKey(
            //     name: "FK_Comments_AspNetUsers_MyPropertyAuthorId",
            //     table: "Comments",
            //     column: "MyPropertyAuthorId",
            //     principalTable: "AspNetUsers",
            //     principalColumn: "Id");
        }
    }
}
