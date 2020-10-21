using Microsoft.EntityFrameworkCore.Migrations;

namespace CityGasWebApi.Migrations
{
    public partial class addfield_user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Mobile",
                table: "User",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mobile",
                table: "User");
        }
    }
}
