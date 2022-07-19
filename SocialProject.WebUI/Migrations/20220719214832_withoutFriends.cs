using Microsoft.EntityFrameworkCore.Migrations;

namespace SocialProject.WebUI.Migrations
{
    public partial class withoutFriends : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_CustomIdentityUserId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CustomIdentityUserId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CustomIdentityUserId",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomIdentityUserId",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CustomIdentityUserId",
                table: "AspNetUsers",
                column: "CustomIdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_CustomIdentityUserId",
                table: "AspNetUsers",
                column: "CustomIdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
