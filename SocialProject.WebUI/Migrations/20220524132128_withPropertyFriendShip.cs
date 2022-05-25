using Microsoft.EntityFrameworkCore.Migrations;

namespace SocialProject.WebUI.Migrations
{
    public partial class withPropertyFriendShip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Accepted",
                table: "FriendShips",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Accepted",
                table: "FriendShips");
        }
    }
}
