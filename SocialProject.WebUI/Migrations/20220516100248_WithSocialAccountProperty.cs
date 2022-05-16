using Microsoft.EntityFrameworkCore.Migrations;

namespace SocialProject.WebUI.Migrations
{
    public partial class WithSocialAccountProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Facebook",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Github",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Google",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Instagram",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Linkedin",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Twitter",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Facebook",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Github",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Google",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Instagram",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Linkedin",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Twitter",
                table: "AspNetUsers");
        }
    }
}
