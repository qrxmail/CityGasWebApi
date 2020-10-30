using Microsoft.EntityFrameworkCore.Migrations;

namespace CityGasWebApi.Migrations
{
    public partial class workticketsfiled : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "OilLoadedMax",
                table: "WorkTicket",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OilLoadedMax",
                table: "WorkTicket");
        }
    }
}
